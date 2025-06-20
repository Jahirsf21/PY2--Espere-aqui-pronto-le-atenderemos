using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading;
using EspereAqui.LogicadeNegocios.EstructurasJson;
using EspereAqui.UI;

namespace EspereAqui.LogicadeNegocios
{
    //Class Clinica
    //Manage Consultorios, patients, and specialties
    //Allows you to upload data and automatically create Consultorios and patients
    //Allows you to control the simulation, pause, resume, and stop.
    public class Clinica
    {
        public List<Consultorio> Consultorios { get; set; }
        public List<Paciente> FilaClinica { get; set; }
        public List<Especialidad> Especialidades { get; set; }
        public Action<string> Logger { get; set; }
        private ManualResetEventSlim _pauseEvent = new ManualResetEventSlim(true);
        public CancellationTokenSource _fitnessCancellationTokenSource;

        public Action OnSimulationFinished { get; set; }

        //Class constructor
        //Initializes all attributes, Consultorio list, patient list, specialty list.
        public Clinica()
        {
            Consultorios = new List<Consultorio>();
            FilaClinica = new List<Paciente>();
            Especialidades = new List<Especialidad>();
            CargarEspecialidadesPorDefecto();
        }

        //Function getNextId, returns the last id based on the number of Consultorios created.
        public int getNextId()
        {
            int id = 1;
            if (this.Consultorios.Count() != 0)
            {
                id = Consultorios[Consultorios.Count - 1].Id + 1;
            }
            return id;
        }

        //Function CargarEspecialidadesPorDefecto, loads a default list of specialties to start the clinic with.
        private void CargarEspecialidadesPorDefecto()
        {
            var nombresPorDefecto = new List<string> {
                "Medicina general", "Odontología", "Cardiología", "Pediatría",
                "Urología", "Ginecología", "Dermatología", "Oftalmología", "Nutriólogo"
            };

            foreach (var nombre in nombresPorDefecto)
            {
                AgregarEspecialidad(new Especialidad(nombre));
            }
        }
    

        //Function AgregarPacienteFila, receives a patient type object and adds it to the clinic row, and a message is added to the interface log.
        public void AgregarPacienteFila(Paciente paciente)
        {
            if (!FilaClinica.Contains(paciente))
            {
                FilaClinica.Add(paciente);
            }
        }

        //Function AgregarConsultorio, receives an Consultorio type object and adds it to the clinic's Consultorio list.
        public void AgregarConsultorio(Consultorio consultorio)
        {
            if (!Consultorios.Contains(consultorio))
            {
                Consultorios.Add(consultorio);
            }
        }

        //Function AgregarEspecialidad, receives a specialty type object and adds it to the clinic's specialty list.
        public void AgregarEspecialidad(Especialidad especialidad)
        {
            if (!Especialidades.Any(e => e.nombre == especialidad.nombre))
            {
                Especialidades.Add(especialidad);
            }
        }

        //Function AgregarPacienteAFilaConsultorio, always tries to assign the best Consultorio to a patient.
        //Assigns a patient to an Consultorio queue based on the pending specialty.
        //If there are no Consultorios for either of their pending specialties, the priority for care is increased.
        //If they have two specialties and there is no Consultorio available for the first specialty, it will attempt to assign them to a queue with the second specialty.
        //Records all actions in the log
        public void AgregarPacienteAFilaConsultorio(Paciente paciente)
        {
            Especialidad especialidadActual = paciente.ObtenerSiguienteEspecialidad();
            if (especialidadActual == null) return;

            List<Consultorio> disponibles = ObtenerConsultoriosEspecialidad(especialidadActual, paciente.mutado);
            Consultorio consultorio = ObtenerConsultorioOptimo(disponibles);

            if (consultorio == null)
            {
                if (paciente.EspecialidadesPendientes.Count() == 2)
                {
                    this.AtenderSegundaEspecialidad(paciente);
                }
                else
                {
                    if (!FilaClinica.Contains(paciente))
                    {
                        this.AgregarPacienteFila(paciente);
                    }
                    if (paciente.Prioridad < 5)
                    {
                        paciente.Prioridad++;
                        Logger?.Invoke($"ESPERA: No hay consultorio para {paciente.Nombre} ({especialidadActual.nombre}). Prioridad aumentada a {paciente.Prioridad}.");
                    }
                }
            }
            else
            {
                consultorio.AgregarPacienteFila(paciente);
                this.FilaClinica.Remove(paciente);
                Logger?.Invoke($"ASIGNADO: Paciente {paciente.Nombre} puesto en fila de C-{consultorio.Id} para {especialidadActual.nombre}.");

            }
        }

        //Function AtenderSegundaEspecialidad, Attempts to see the patient with the second pending specialty. If the Consultorio doesn't exist, it returns the patient to the clinic queue and increases its priority. If the Consultorio exists, it sees the patient regularly.
        //Actions are recorded in the log.
        public void AtenderSegundaEspecialidad(Paciente paciente)
        {
            Especialidad especialidadActual = paciente.EspecialidadesPendientes[1].Especialidad;
            if (especialidadActual == null) return;

            List<Consultorio> disponibles = ObtenerConsultoriosEspecialidad(especialidadActual, paciente.mutado);
            Consultorio consultorio = ObtenerConsultorioOptimo(disponibles);

            if (consultorio == null)
            {
                if (!FilaClinica.Contains(paciente))
                {
                    this.AgregarPacienteFila(paciente);
                }
                if (paciente.Prioridad < 5)
                {
                    paciente.Prioridad++;
                    Logger?.Invoke($"ESPERA: No hay consultorio para {paciente.Nombre} ({especialidadActual.nombre}). Prioridad aumentada a {paciente.Prioridad}.");
                }
            }
            else
            {
                paciente.cambiarOrdenEspecialidades();
                consultorio.AgregarPacienteFila(paciente);
                this.FilaClinica.Remove(paciente);
                Logger?.Invoke($"ASIGNADO: Paciente {paciente.Nombre} puesto en fila de C-{consultorio.Id} para {especialidadActual.nombre}.");

            }
        }


        //Function ObtenerConsultoriosEspecialidad, Receives a specialty type object and returns a list of Consultorio that contain that specialty.
        // With the bool mutation, if it is true, what it does is give an Consultorio that does not have the required specialty.
        public List<Consultorio> ObtenerConsultoriosEspecialidad(Especialidad especialidad, bool mutacion)
        {
            List<Consultorio> resultado = new List<Consultorio>();
            foreach (Consultorio cons in this.Consultorios)
            {
                if (cons.Contiene(especialidad)) resultado.Add(cons);
            }
            if (mutacion)
            {
                foreach (Consultorio cons in this.Consultorios)
                {
                    if (!cons.Contiene(especialidad))
                    {
                        resultado.Add(cons);
                        return resultado;
                    }
                }
            }
            return resultado;
        }


        //Function Automatizar, creates a list of objects of type patient and Consultorio randomly.
        public void Automatizar()
        {
            Random random = new Random();

            List<string> nombres = new List<string> { "Ana", "María", "Lucía", "Sofía", "Laura", "Luis", "Carlos", "Pedro", "Miguel", "Andrés" };
            List<string> apellidos = new List<string> { "García", "Martínez", "López", "Hernández", "Pérez", "Ramírez", "Torres", "Sánchez", "Flores", "Morales" };

            for (int i = 0; i <= random.Next(10); i++)
            {
                List<String> listaEspecialidades = [
                "Medicina general", "Odontología", "Cardiología", "Pediatría",
                "Urología", "Ginecología", "Dermatología", "Oftalmología", "Nutriólogo"
                ];
                int temp = random.Next(10);
                string nombre = nombres[temp];
                string apellido = apellidos[random.Next(10)];
                List<Especialidad> especialidadesAAgregar = new List<Especialidad>();
                int cantEsp = random.Next(1, 3);
                for (int e = 0; e < cantEsp; e++)
                {
                    string Esptemp = listaEspecialidades[random.Next(listaEspecialidades.Count())];
                    especialidadesAAgregar.Add(new Especialidad(Esptemp));
                    listaEspecialidades.Remove(Esptemp);
                }

                string genero = "Mujer";
                if (temp > 4) genero = "Hombre";

                Paciente pac = new Paciente(nombre, apellido, genero, especialidadesAAgregar);
                this.AgregarPacienteFila(pac);
            }

            for (int i = 0; i <= random.Next((10)); i++)
            {
                List<String> listaEspecialidades = [
                "Medicina general", "Odontología", "Cardiología", "Pediatría",
                "Urología", "Ginecología", "Dermatología", "Oftalmología", "Nutriólogo"
                ];
                int temp = random.Next(9);
                List<Especialidad> especialidadesAAgregar = new List<Especialidad>();
                int cantEsp = random.Next(1, 3);
                for (int e = 0; e < cantEsp; e++)
                {
                    string Esptemp = listaEspecialidades[temp];
                    especialidadesAAgregar.Add(new Especialidad(Esptemp));
                    listaEspecialidades.Remove(Esptemp);
                }
                Consultorio consultorio = new Consultorio(especialidadesAAgregar, new List<Paciente>(), getNextId());
                this.Consultorios.Add(consultorio);
            }
        }

        //Function ObtenerConsultorioOptimo, Receive a list of Consultorios and determine which is the best Consultorios
        //taking into account the number of patients and the consultation time for the specialties.
        public Consultorio ObtenerConsultorioOptimo(List<Consultorio> consultorios)
        {
            if (consultorios.Count == 0) return null;
            Consultorio mejor = consultorios[0];
            foreach (Consultorio cons in consultorios)
            { 
                int tiempoActual = this.CalcularTiempo(cons);
                int tiempoMejor = this.CalcularTiempo(mejor);
                if (tiempoActual < tiempoMejor) mejor = cons;
            }
            return mejor;
        }

        //Function CalculateTime calculates the total time required to see all patients in the Consultorio,
        //for each specialty, adding the number of patients by the consultation time for that specialty.
        public int CalcularTiempo(Consultorio consultorio)
        {
            int resultado = 0;
            int cantidadPacientes;
            foreach (Especialidad esp in consultorio.Especialidades)
            {
                cantidadPacientes = consultorio.ObtenerCantidadPacientesEspecialidad(esp);
                resultado += cantidadPacientes * esp.tiempoConsulta;
            }
            return resultado;
        }


        //Function OrdenarPacientesPorPrioridad, Sort the clinic's patient list by highest priority.
        public List<Paciente> OrdenarPacientesPorPrioridad()
        {
            return this.FilaClinica.OrderByDescending(paciente => paciente.Prioridad).ToList();
        }


        //Function EliminarConsultorio, Receives an object of type Consultorio and removes it from the clinic's list of Consultorios.
        //Record the event in the log.
        public void EliminarConsultorio(Consultorio cons)
        {
            Logger?.Invoke($"ADMIN: Se ha eliminado el consultorio C-{cons.Id}. Pacientes devueltos a la fila general.");
            this.Consultorios.Remove(cons);
            foreach (Paciente paciente in cons.Pacientes)
            {
                paciente.Prioridad++;
            }
            this.FilaClinica.AddRange(cons.Pacientes);
        }

        //Function PausarSimulacion, Pauses the clinic simulation, temporarily stopping patient assignment and care
        //Record the event in the log.
        public void PausarSimulacion()
        {
            _pauseEvent.Reset();
            Logger?.Invoke("SISTEMA: Simulación pausada.");
        }

        //Function ReanudarSimulacion, Resumes the clinic simulation, allowing for continued patient assignment and care.
        //Record the event in the log.
        public void ReanudarSimulacion()
        {
            _pauseEvent.Set();
            Logger?.Invoke("SISTEMA: Simulación reanudada");
        }


        //Function DetenerTodosLosProcesos,Stops all processes in the clinic simulation.
        // Cancels running threads, clears patient, Consultorio, and specialty lists,
        public void DetenerTodosLosProcesos()
        {
            _fitnessCancellationTokenSource?.Cancel();
            _pauseEvent.Set();
            this.FilaClinica.Clear();
            this.Consultorios.Clear();
            Especialidades.Clear();
        }

        //Function IniciarFitness, Start the clinic fitness simulation.
        //Create a new cancellation token, assign the completion callback, and begin the simulation process.
        public void IniciarFitness(Action onUIRefresh, Action onSimulationFinishedCallback)
        {
            _fitnessCancellationTokenSource = new CancellationTokenSource();
            this.OnSimulationFinished = onSimulationFinishedCallback;
            Fitness(onUIRefresh, _fitnessCancellationTokenSource.Token);
        }

        //Function Fitness, Run the clinic simulation.
        //Assign patients to Consultorios and manage their care automatically, always seeking the best appointment time.
        //Allows you to pause, resume, and cancel the simulation using events and tokens.
        //Update the user interface and execute a callback when the simulation ends.
        //Record the events in the log.
        public void Fitness(Action onUIRefresh, CancellationToken cancellationToken)
        {
            Action<Paciente> manejarPacienteAtendido = (paciente) =>
            {
                if (paciente != null)
                {
                    if (paciente.TieneEspecialidadesPendientes())
                    {
                        this.AgregarPacienteFila(paciente);
                        onUIRefresh?.Invoke();
                    }
                    else
                    {
                        Logger?.Invoke($"FINALIZADO: Paciente {paciente.Nombre} {paciente.Apellido} ha completado todas sus consultas.");
                    }
                }
                onUIRefresh?.Invoke();
            };

            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        _pauseEvent.Wait(cancellationToken);
                        if (cancellationToken.IsCancellationRequested) break;

                        if (this.FilaClinica.Any())
                        {
                            for (int i = 0; i < FilaClinica.Count(); i++)
                            {
                                Paciente pacienteAAsignar;
                                lock (FilaClinica)
                                {
                                    FilaClinica = this.OrdenarPacientesPorPrioridad();
                                    pacienteAAsignar = FilaClinica[i];
                                }

                                if (pacienteAAsignar != null)
                                {
                                    this.AgregarPacienteAFilaConsultorio(pacienteAAsignar);
                                    onUIRefresh?.Invoke();
                                }
                                Thread.Sleep(3000);
                            }

                        }

                        bool noHayPacientesEnFilaGeneral = !this.FilaClinica.Any();
                        bool ningunConsultorioOcupado = !this.Consultorios.Any(c => c.pacienteActual != null || c.Pacientes.Any());

                        if (noHayPacientesEnFilaGeneral && ningunConsultorioOcupado)
                        {
                            Logger?.Invoke("SISTEMA: ¡Todos los pacientes han sido atendidos! La simulación ha finalizado.");
                            OnSimulationFinished?.Invoke();
                            break;
                        }
                        Thread.Sleep(1000);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                }
            }).Start();
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                while (!cancellationToken.IsCancellationRequested)
                {
                    try
                    {
                        _pauseEvent.Wait(cancellationToken);
                        if (cancellationToken.IsCancellationRequested) break;

                        var consultoriosActuales = this.Consultorios.ToList();
                        foreach (Consultorio cons in consultoriosActuales)
                        {
                            if (cancellationToken.IsCancellationRequested) break;

                            Thread.Sleep(2000);
                            cons.AtenderPaciente(manejarPacienteAtendido, this.Logger);
                        }
                        Thread.Sleep(2000);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                }
            }).Start();
        }


        //Function CargarDatosDesdeJson, Load specialty and patient data from a JSON file.
        //Parse the file contents and add or update specialties and patients in the patient and specialty lists.
        //Record the events in the log
        public void CargarDatosDesdeJson(string rutaArchivo)
        {
            try
            {
                string contenidoJson = File.ReadAllText(rutaArchivo);
                var datosCargados = JsonSerializer.Deserialize<DatosClinicaJson>(contenidoJson);

                if (datosCargados == null)
                {
                    Logger?.Invoke("ERROR: El archivo JSON está vacío o tiene un formato incorrecto.");
                    return;
                }
                this.FilaClinica.Clear();
                Logger?.Invoke("SISTEMA: Se ha limpiado la lista de pacientes para una nueva carga.");

                if (datosCargados.Especialidades != null)
                {
                    foreach (var espJson in datosCargados.Especialidades)
                    {
                        var espExistente = Especialidades.FirstOrDefault(e => e.nombre == espJson.Nombre);
                        if (espExistente != null)
                        {
                            espExistente.tiempoConsulta = espJson.TiempoConsulta;
                            Logger?.Invoke($"ACTUALIZADO: El tiempo de '{espJson.Nombre}' es ahora {espJson.TiempoConsulta} min.");
                        }
                        else
                        {
                            var nuevaEspecialidad = new Especialidad(espJson.Nombre)
                            {
                                tiempoConsulta = espJson.TiempoConsulta
                            };
                            AgregarEspecialidad(nuevaEspecialidad);
                            Logger?.Invoke($"NUEVA ESP: Se añadió '{nuevaEspecialidad.nombre}' con un tiempo de {nuevaEspecialidad.tiempoConsulta} min.");
                        }
                    }
                }
                if (datosCargados.Pacientes != null)
                {
                    foreach (var pacJson in datosCargados.Pacientes)
                    {
                        List<Especialidad> especialidadesPaciente = new List<Especialidad>();
                        foreach (var nombreEsp in pacJson.EspecialidadesRequeridas)
                        {
                            var esp = Especialidades.FirstOrDefault(e => e.nombre == nombreEsp);

                            if (esp == null)
                            {
                                esp = new Especialidad(nombreEsp);
                                AgregarEspecialidad(esp);
                                Logger?.Invoke($"Especialidad creada: La especialidad '{nombreEsp}' no estaba en la lista y fue creada con un tiempo por defecto");
                            }
                            especialidadesPaciente.Add(esp);
                        }

                        if (especialidadesPaciente.Any())
                        {
                            var nuevoPaciente = new Paciente(pacJson.Nombre, pacJson.Apellido, pacJson.Genero, especialidadesPaciente)
                            {
                                Prioridad = pacJson.Prioridad
                            };
                            AgregarPacienteFila(nuevoPaciente);
                            Logger?.Invoke($"PACIENTE: {nuevoPaciente.Nombre} {nuevoPaciente.Apellido} con prioridad {nuevoPaciente.Prioridad} cargado.");
                        }
                    }
                }


                Logger?.Invoke($"ÉXITO: Se han cargado los datos desde el archivo JSON.");
            }
            catch (Exception ex)
            {
                Logger?.Invoke($"ERROR AL CARGAR JSON: {ex.Message}");
            }
        }

        //Function Genetico, Select the two Consultorios with the fewest patients and perform a crossover between them.
        //Additionally, with a probability of 1 in 1 million, you can mark a patient in the row as mutated.
        public void Genetico()
        {
            List<Consultorio> ordenados = this.Consultorios.Where(cons => cons.Pacientes.Count > 0)
            .OrderBy(cons => cons.Pacientes.Count()).ToList();
            if (ordenados.Count() > 1)
            {
                Consultorio mejor = ordenados[0];
                Consultorio segundoMejor = ordenados[1];
                if (mejor != segundoMejor && (mejor.Pacientes.Count() + segundoMejor.Pacientes.Count() <= 15))
                {
                    this.Cruce(mejor, segundoMejor);
                }
            }


            Random rand = new Random();
            int num = rand.Next(1000000);
            if (num == 105347 && this.Consultorios.Count() != 0)
            {
                num = rand.Next(this.FilaClinica.Count());
                this.FilaClinica[num].mutado = true;
            }
        }

        //Function Cruce, Performs a crossover between two Consultorios, combining their patients and specialties into a new Consultorio.
        //Removes the original Consultorios from the list and adds the new resulting Consultorio.
        public void Cruce(Consultorio cons1, Consultorio cons2)
        {
            this.Consultorios.Remove(cons1);
            this.Consultorios.Remove(cons2);
            cons1.Pacientes.AddRange(cons2.Pacientes);
            cons1.Especialidades.AddRange(cons2.Especialidades);
            List<Paciente> nuevaFila = cons1.Pacientes;
            List<Especialidad> nuevaListaEspecialidad = cons1.Especialidades;
            Consultorio nuevoCons = new Consultorio(nuevaListaEspecialidad, nuevaFila, getNextId());
            this.Consultorios.Add(nuevoCons);
        }
    }
    }
     

