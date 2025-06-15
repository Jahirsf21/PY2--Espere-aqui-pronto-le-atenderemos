namespace EspereAqui.UI
{
    partial class Ventana_simulacion
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.lblCronometro = new System.Windows.Forms.Label();
            this.pnlContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlConsultoriosContainer = new System.Windows.Forms.Panel();
            this.pnlFilaPacientes = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.btnGestionarPacientes = new System.Windows.Forms.Button();
            this.btnGestionarConsultorios = new System.Windows.Forms.Button();
            this.btnEmpezarAlgoritmo = new System.Windows.Forms.Button();
            this.btnEmpezarGenetico = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.simulacionTimer = new System.Windows.Forms.Timer(this.components);
            this.pnlFondo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackgroundImage = Properties.Resources.fondo;
            this.pnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondo.Controls.Add(this.lblCronometro);
            this.pnlFondo.Controls.Add(this.pnlContenido);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1370, 749);
            this.pnlFondo.TabIndex = 0;
            // 
            // lblCronometro
            // 
            this.lblCronometro.AutoSize = true;
            this.lblCronometro.BackColor = System.Drawing.Color.Transparent;
            this.lblCronometro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblCronometro.ForeColor = System.Drawing.Color.White;
            this.lblCronometro.Location = new System.Drawing.Point(23, 9);
            this.lblCronometro.Name = "lblCronometro";
            this.lblCronometro.Size = new System.Drawing.Size(288, 37);
            this.lblCronometro.TabIndex = 1;
            this.lblCronometro.Text = "Tiempo: Día 1 - 00:00";
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.Transparent;
            this.pnlContenido.ColumnCount = 1;
            this.pnlContenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlContenido.Controls.Add(this.pnlConsultoriosContainer, 0, 0);
            this.pnlContenido.Controls.Add(this.pnlFilaPacientes, 0, 1);
            this.pnlContenido.Controls.Add(this.pnlBotones, 0, 3);
            this.pnlContenido.Controls.Add(this.rtbLog, 0, 2);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenido.Location = new System.Drawing.Point(0, 0);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20, 50, 20, 20);
            this.pnlContenido.RowCount = 4;
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.pnlContenido.Size = new System.Drawing.Size(1370, 749);
            this.pnlContenido.TabIndex = 0;
            // 
            // pnlConsultoriosContainer
            // 
            this.pnlConsultoriosContainer.AutoScroll = true;
            this.pnlConsultoriosContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsultoriosContainer.Location = new System.Drawing.Point(23, 53);
            this.pnlConsultoriosContainer.Name = "pnlConsultoriosContainer";
            this.pnlConsultoriosContainer.Size = new System.Drawing.Size(1324, 399);
            this.pnlConsultoriosContainer.TabIndex = 0;
            // 
            // pnlFilaPacientes
            // 
            this.pnlFilaPacientes.AutoScroll = true;
            this.pnlFilaPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilaPacientes.Location = new System.Drawing.Point(23, 458);
            this.pnlFilaPacientes.Name = "pnlFilaPacientes";
            this.pnlFilaPacientes.Size = new System.Drawing.Size(1324, 144);
            this.pnlFilaPacientes.TabIndex = 1;
            this.pnlFilaPacientes.WrapContents = false;
            // 
            // pnlBotones
            // 
            this.pnlBotones.ColumnCount = 7;
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.pnlBotones.Controls.Add(this.btnCargarDatos, 0, 0);
            this.pnlBotones.Controls.Add(this.btnGestionarPacientes, 1, 0);
            this.pnlBotones.Controls.Add(this.btnGestionarConsultorios, 2, 0);
            this.pnlBotones.Controls.Add(this.btnEmpezarAlgoritmo, 3, 0);
            this.pnlBotones.Controls.Add(this.btnEmpezarGenetico, 4, 0);
            this.pnlBotones.Controls.Add(this.btnPausar, 5, 0);
            this.pnlBotones.Controls.Add(this.btnSalir, 6, 0);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(23, 661);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.RowCount = 1;
            this.pnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBotones.Size = new System.Drawing.Size(1324, 64);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnCargarDatos
            //
            this.btnCargarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargarDatos.Location = new System.Drawing.Point(4, 7);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(180, 50);
            this.btnCargarDatos.TabIndex = 0;
            this.btnCargarDatos.Text = "Cargar Datos";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnGestionarPacientes
            // 
            this.btnGestionarPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarPacientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGestionarPacientes.Location = new System.Drawing.Point(193, 7);
            this.btnGestionarPacientes.Name = "btnGestionarPacientes";
            this.btnGestionarPacientes.Size = new System.Drawing.Size(180, 50);
            this.btnGestionarPacientes.TabIndex = 1;
            this.btnGestionarPacientes.Text = "Gestionar Pacientes";
            this.btnGestionarPacientes.UseVisualStyleBackColor = true;
            this.btnGestionarPacientes.Click += new System.EventHandler(this.btnGestionarPacientes_Click);
            // 
            // btnGestionarConsultorios
            // 
            this.btnGestionarConsultorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarConsultorios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGestionarConsultorios.Location = new System.Drawing.Point(382, 7);
            this.btnGestionarConsultorios.Name = "btnGestionarConsultorios";
            this.btnGestionarConsultorios.Size = new System.Drawing.Size(180, 50);
            this.btnGestionarConsultorios.TabIndex = 2;
            this.btnGestionarConsultorios.Text = "Gestionar Consultorios";
            this.btnGestionarConsultorios.UseVisualStyleBackColor = true;
            this.btnGestionarConsultorios.Click += new System.EventHandler(this.btnGestionarConsultorios_Click);
            // 
            // btnEmpezarAlgoritmo
            // 
            this.btnEmpezarAlgoritmo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpezarAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmpezarAlgoritmo.Location = new System.Drawing.Point(571, 7);
            this.btnEmpezarAlgoritmo.Name = "btnEmpezarAlgoritmo";
            this.btnEmpezarAlgoritmo.Size = new System.Drawing.Size(180, 50);
            this.btnEmpezarAlgoritmo.TabIndex = 3;
            this.btnEmpezarAlgoritmo.Text = "Empezar Simulación";
            this.btnEmpezarAlgoritmo.UseVisualStyleBackColor = true;
            this.btnEmpezarAlgoritmo.Click += new System.EventHandler(this.btnEmpezarAlgoritmo_Click);
            // 
            // btnEmpezarGenetico
            // 
            this.btnEmpezarGenetico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpezarGenetico.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmpezarGenetico.Location = new System.Drawing.Point(760, 7);
            this.btnEmpezarGenetico.Name = "btnEmpezarGenetico";
            this.btnEmpezarGenetico.Size = new System.Drawing.Size(180, 50);
            this.btnEmpezarGenetico.TabIndex = 4;
            this.btnEmpezarGenetico.Text = "Empezar Genético";
            this.btnEmpezarGenetico.UseVisualStyleBackColor = true;
            this.btnEmpezarGenetico.Click += new System.EventHandler(this.btnEmpezarGenetico_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPausar.Enabled = false;
            this.btnPausar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnPausar.Location = new System.Drawing.Point(949, 7);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(180, 50);
            this.btnPausar.TabIndex = 5;
            this.btnPausar.Text = "Pausar";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSalir.BackColor = System.Drawing.Color.MistyRose;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(1139, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(180, 50);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            //
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtbLog.Location = new System.Drawing.Point(23, 608);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(1324, 47);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // simulacionTimer
            // 
            this.simulacionTimer.Interval = 1000;
            this.simulacionTimer.Tick += new System.EventHandler(this.simulacionTimer_Tick);
            // 
            // Ventana_simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pnlFondo);
            this.Name = "Ventana_simulacion";
            this.Text = "Simulador de Clínica - EspereAquí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventana_simulacion_Load);
            this.pnlFondo.ResumeLayout(false);
            this.pnlFondo.PerformLayout();
            this.pnlContenido.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFondo;
        private System.Windows.Forms.TableLayoutPanel pnlContenido;
        private System.Windows.Forms.Panel pnlConsultoriosContainer;
        private System.Windows.Forms.FlowLayoutPanel pnlFilaPacientes;
        private System.Windows.Forms.TableLayoutPanel pnlBotones;
        private System.Windows.Forms.Button btnGestionarPacientes;
        private System.Windows.Forms.Button btnGestionarConsultorios;
        private System.Windows.Forms.Button btnEmpezarAlgoritmo;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnEmpezarGenetico;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblCronometro;
        private System.Windows.Forms.Timer simulacionTimer;
    }
}