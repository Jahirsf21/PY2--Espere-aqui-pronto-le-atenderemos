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
    public class Clinica
    {
        public List<Consultorio> Consultorios { get; set; }
        public List<Paciente> FilaClinica { get; set; }
        public List<Especialidad> Especialidades { get; set; }
        public Action<string> Logger { get; set; }
        private ManualResetEventSlim _pauseEvent = new ManualResetEventSlim(true);
        public CancellationTokenSource _fitnessCancellationTokenSource;

        public Action OnSimulationFinished { get; set; }
        
        public Clinica()
        {
            Consultorios = new List<Consultorio>();
            FilaClinica = new List<Paciente>();
            Especialidades = new List<Especialidad>();
            CargarEspecialidadesPorDefecto();
        }

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

        public void AgregarPacienteFila(Paciente paciente)
        {
            if (!FilaClinica.Contains(paciente))
            {
                FilaClinica.Add(paciente);
                Logger?.Invoke($"INGRESO: Paciente {paciente.Nombre} {paciente.Apellido} ha entrado a la clínica.");
            }
        }

        public void AgregarConsultorio(Consultorio consultorio)
        {
            if (!Consultorios.Contains(consultorio))
            {
                Consultorios.Add(consultorio);
            }
        }

        public void AgregarEspecialidad(Especialidad especialidad)
        {
            if (!Especialidades.Any(e => e.nombre == especialidad.nombre))
            {
                Especialidades.Add(especialidad);
            }
        }

        public void AgregarPacienteAFilaConsultorio(Paciente paciente)
        {
            Especialidad especialidadActual = paciente.ObtenerSiguienteEspecialidad();
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
                consultorio.AgregarPacienteFila(paciente);
                this.FilaClinica.Remove(paciente);
                Logger?.Invoke($"ASIGNADO: Paciente {paciente.Nombre} puesto en fila de C-{consultorio.Id} para {especialidadActual.nombre}.");
                
            }
        }

        public List<Consultorio> ObtenerConsultoriosEspecialidad(Especialidad especialidad, bool mutacion)
        {
            List<Consultorio> resultado = new List<Consultorio>();
            foreach (Consultorio cons in this.Consultorios)
            {
                if (cons.Contiene(especialidad)) resultado.Add(cons);
            }
            if (mutacion){
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

        public void Automatizar()
        {
            Random random = new Random();
            List<String> listaEspecialidades = [
                "Medicina general", "Odontología", "Cardiología", "Pediatría",
                "Urología", "Ginecología", "Dermatología", "Oftalmología", "Nutriólogo"
            ];

            List<string> nombres = new List<string> { "Ana", "María", "Lucía", "Sofía", "Laura", "Luis", "Carlos", "Pedro", "Miguel", "Andrés" };
            List<string> apellidos = new List<string> { "García", "Martínez", "López", "Hernández", "Pérez", "Ramírez", "Torres", "Sánchez", "Flores", "Morales" };

            for (int i = 0; i < random.Next(10); i++)
            {
                int temp = random.Next(10);
                string nombre = nombres[temp];
                string apellido = apellidos[random.Next(10)];
                List<Especialidad> especialidadesAAgregar = new List<Especialidad>();
                int cantEsp = random.Next(1, 2);
                for (int e = 0; e < cantEsp; e++)
                {
                    especialidadesAAgregar.Add(new Especialidad(listaEspecialidades[random.Next(9)]));
                }

                string genero = "Mujer";
                if (temp > 4) genero = "Hombre";
                
                Paciente pac = new Paciente(nombre, apellido, genero, especialidadesAAgregar);
                this.AgregarPacienteFila(pac);
            }
        }

        public Consultorio ObtenerConsultorioOptimo(List<Consultorio> consultorios)
        {
            if (consultorios.Count == 0) return null;
            Consultorio mejor = consultorios[0];
            foreach (Consultorio cons in consultorios)
            {
                int tiempoActual = cons.ObtenerLongitudFila() * this.CalcularTiempo(cons);
                int tiempoMejor = mejor.ObtenerLongitudFila() * this.CalcularTiempo(mejor);
                if (tiempoActual < tiempoMejor) mejor = cons;
            }
            return mejor;
        }

        public int CalcularTiempo(Consultorio consultorio)
        {
            int resultado = 0;
            foreach (Especialidad esp in consultorio.Especialidades)
                resultado += esp.tiempoConsulta;
            return resultado;
        }

        public List<Paciente> OrdenarPacientesPorPrioridad()
        {
            return this.FilaClinica.OrderByDescending(paciente => paciente.Prioridad).ToList();
        }

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

        public void PausarSimulacion()
        {
            _pauseEvent.Reset();
            Logger?.Invoke("SISTEMA: Simulación pausada.");
        }

        public void ReanudarSimulacion()
        {
            _pauseEvent.Set();
            Logger?.Invoke("SISTEMA: Simulación reanudada");
        }

        public void DetenerTodosLosProcesos()
        {
            _fitnessCancellationTokenSource?.Cancel();
            _pauseEvent.Set();

            this.FilaClinica.Clear();
            this.Consultorios.Clear();
            Especialidades.Clear();
            CargarEspecialidadesPorDefecto();
        }
        
        public void IniciarFitness(Action onUIRefresh, Action onSimulationFinishedCallback)
        {
            _fitnessCancellationTokenSource = new CancellationTokenSource();
            this.OnSimulationFinished = onSimulationFinishedCallback;
            Fitness(onUIRefresh, _fitnessCancellationTokenSource.Token);
        }
        public void Fitness(Action onUIRefresh, CancellationToken cancellationToken)
        {
            Action<Paciente> manejarPacienteAtendido = (paciente) =>
            {
                if (paciente != null)
                {
                    if (paciente.TieneEspecialidadesPendientes())
                    {
                        this.AgregarPacienteFila(paciente);
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
                            Paciente pacienteAAsignar;
                            lock (FilaClinica)
                            {
                                FilaClinica = this.OrdenarPacientesPorPrioridad();
                                pacienteAAsignar = FilaClinica[0];
                            }

                            if (pacienteAAsignar != null)
                            {
                                this.AgregarPacienteAFilaConsultorio(pacienteAAsignar);
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
                        Thread.Sleep(500);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                }
            }).Start();

            // Hilo que procesa la atención en cada consultorio
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


        public void Genetico()
        {
            List<Consultorio> ordenados = this.Consultorios.Where(cons => cons.Pacientes.Count > 0)
            .OrderBy(cons=>cons.Pacientes.Count()).ToList();
            if (ordenados.Count() > 1)
            {
                Consultorio mejor = ordenados[0];
                Consultorio segundoMejor = ordenados[1];   
                if (mejor!=segundoMejor && (mejor.Pacientes.Count() + segundoMejor.Pacientes.Count() <= 15))
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

        public void Cruce(Consultorio cons1, Consultorio cons2)
        {
            this.Consultorios.Remove(cons1);
            this.Consultorios.Remove(cons2);
            cons1.Pacientes.AddRange(cons2.Pacientes);
            cons1.Especialidades.AddRange(cons2.Especialidades);
            List<Paciente> nuevaFila = cons1.Pacientes;
            List<Especialidad> nuevaListaEspecialidad = cons1.Especialidades;
            Consultorio nuevoCons = new Consultorio(nuevaListaEspecialidad, nuevaFila);
            this.Consultorios.Add(nuevoCons);
        }


        }
    }
     

