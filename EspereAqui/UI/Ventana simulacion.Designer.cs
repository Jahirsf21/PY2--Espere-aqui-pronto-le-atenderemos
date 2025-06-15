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
            this.pnlFondo = new System.Windows.Forms.Panel();
            this.pnlContenido = new System.Windows.Forms.TableLayoutPanel();
            this.pnlConsultoriosContainer = new System.Windows.Forms.Panel();
            this.lblTituloConsultorios = new System.Windows.Forms.Label();
            this.pnlFilaPacientes = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTituloFilaPacientes = new System.Windows.Forms.Label();
            this.pnlBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnGestionarPacientes = new System.Windows.Forms.Button();
            this.btnGestionarConsultorios = new System.Windows.Forms.Button();
            this.btnEmpezarAlgoritmo = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlFondo.SuspendLayout();
            this.pnlContenido.SuspendLayout();
            this.pnlConsultoriosContainer.SuspendLayout();
            this.pnlFilaPacientes.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFondo
            // 
            this.pnlFondo.BackgroundImage = Properties.Resources.fondo;
            this.pnlFondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlFondo.Controls.Add(this.pnlContenido);
            this.pnlFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFondo.Location = new System.Drawing.Point(0, 0);
            this.pnlFondo.Name = "pnlFondo";
            this.pnlFondo.Size = new System.Drawing.Size(1262, 753);
            this.pnlFondo.TabIndex = 0;
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
            this.pnlContenido.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenido.RowCount = 4;
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlContenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.pnlContenido.Size = new System.Drawing.Size(1262, 753);
            this.pnlContenido.TabIndex = 0;
            // 
            // pnlConsultoriosContainer
            // 
            this.pnlConsultoriosContainer.AutoScroll = true;
            this.pnlConsultoriosContainer.Controls.Add(this.lblTituloConsultorios);
            this.pnlConsultoriosContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsultoriosContainer.Location = new System.Drawing.Point(23, 23);
            this.pnlConsultoriosContainer.Name = "pnlConsultoriosContainer";
            this.pnlConsultoriosContainer.Size = new System.Drawing.Size(1216, 250);
            this.pnlConsultoriosContainer.TabIndex = 0;
            // 
            // lblTituloConsultorios
            // 
            this.lblTituloConsultorios.AutoSize = true;
            this.lblTituloConsultorios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloConsultorios.ForeColor = System.Drawing.Color.White;
            this.lblTituloConsultorios.Location = new System.Drawing.Point(3, 0);
            this.lblTituloConsultorios.Name = "lblTituloConsultorios";
            this.lblTituloConsultorios.Size = new System.Drawing.Size(130, 28);
            this.lblTituloConsultorios.TabIndex = 0;
            this.lblTituloConsultorios.Text = "Consultorios";
            // 
            // pnlFilaPacientes
            // 
            this.pnlFilaPacientes.AutoScroll = true;
            this.pnlFilaPacientes.Controls.Add(this.lblTituloFilaPacientes);
            this.pnlFilaPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilaPacientes.Location = new System.Drawing.Point(23, 279);
            this.pnlFilaPacientes.Name = "pnlFilaPacientes";
            this.pnlFilaPacientes.Size = new System.Drawing.Size(1216, 144);
            this.pnlFilaPacientes.TabIndex = 1;
            this.pnlFilaPacientes.WrapContents = false;
            // 
            // lblTituloFilaPacientes
            // 
            this.pnlFilaPacientes.SetFlowBreak(this.lblTituloFilaPacientes, true);
            this.lblTituloFilaPacientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTituloFilaPacientes.ForeColor = System.Drawing.Color.White;
            this.lblTituloFilaPacientes.Location = new System.Drawing.Point(3, 0);
            this.lblTituloFilaPacientes.Name = "lblTituloFilaPacientes";
            this.lblTituloFilaPacientes.Size = new System.Drawing.Size(1200, 28);
            this.lblTituloFilaPacientes.TabIndex = 0;
            this.lblTituloFilaPacientes.Text = "Fila General Pacientes";
            // 
            // pnlBotones
            // 
            this.pnlBotones.ColumnCount = 4;
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.pnlBotones.Controls.Add(this.btnCargarDatos, 0, 0);
            this.pnlBotones.Controls.Add(this.btnGestionarPacientes, 1, 0);
            this.pnlBotones.Controls.Add(this.btnGestionarConsultorios, 2, 0);
            this.pnlBotones.Controls.Add(this.btnEmpezarAlgoritmo, 3, 0);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(23, 665);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.RowCount = 1;
            this.pnlBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlBotones.Size = new System.Drawing.Size(1216, 64);
            this.pnlBotones.TabIndex = 2;
            // 
            // btnCargarDatos
            //
            this.btnCargarDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCargarDatos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCargarDatos.Location = new System.Drawing.Point(52, 7);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(200, 50);
            this.btnCargarDatos.TabIndex = 3;
            this.btnCargarDatos.Text = "Cargar Datos (JSON)";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // btnGestionarPacientes
            // 
            this.btnGestionarPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarPacientes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGestionarPacientes.Location = new System.Drawing.Point(356, 7);
            this.btnGestionarPacientes.Name = "btnGestionarPacientes";
            this.btnGestionarPacientes.Size = new System.Drawing.Size(200, 50);
            this.btnGestionarPacientes.TabIndex = 0;
            this.btnGestionarPacientes.Text = "Gestionar Pacientes";
            this.btnGestionarPacientes.UseVisualStyleBackColor = true;
            this.btnGestionarPacientes.Click += new System.EventHandler(this.btnGestionarPacientes_Click);
            // 
            // btnGestionarConsultorios
            // 
            this.btnGestionarConsultorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarConsultorios.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGestionarConsultorios.Location = new System.Drawing.Point(660, 7);
            this.btnGestionarConsultorios.Name = "btnGestionarConsultorios";
            this.btnGestionarConsultorios.Size = new System.Drawing.Size(200, 50);
            this.btnGestionarConsultorios.TabIndex = 1;
            this.btnGestionarConsultorios.Text = "Gestionar Consultorios";
            this.btnGestionarConsultorios.UseVisualStyleBackColor = true;
            this.btnGestionarConsultorios.Click += new System.EventHandler(this.btnGestionarConsultorios_Click);
            // 
            // btnEmpezarAlgoritmo
            // 
            this.btnEmpezarAlgoritmo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEmpezarAlgoritmo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmpezarAlgoritmo.Location = new System.Drawing.Point(964, 7);
            this.btnEmpezarAlgoritmo.Name = "btnEmpezarAlgoritmo";
            this.btnEmpezarAlgoritmo.Size = new System.Drawing.Size(200, 50);
            this.btnEmpezarAlgoritmo.TabIndex = 2;
            this.btnEmpezarAlgoritmo.Text = "Empezar Simulación";
            this.btnEmpezarAlgoritmo.UseVisualStyleBackColor = true;
            this.btnEmpezarAlgoritmo.Click += new System.EventHandler(this.btnEmpezarAlgoritmo_Click);
            //
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(40)))));
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Font = new System.Drawing.Font("Consolas", 9F);
            this.rtbLog.ForeColor = System.Drawing.Color.Gainsboro;
            this.rtbLog.Location = new System.Drawing.Point(23, 429);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(1216, 230);
            this.rtbLog.TabIndex = 3;
            this.rtbLog.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Ventana_simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 753);
            this.Controls.Add(this.pnlFondo);
            this.Name = "Ventana_simulacion";
            this.Text = "Simulador de Clínica - EspereAquí";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Ventana_simulacion_Load);
            this.Activated += new System.EventHandler(this.Ventana_simulacion_Activated);
            this.pnlFondo.ResumeLayout(false);
            this.pnlContenido.ResumeLayout(false);
            this.pnlConsultoriosContainer.ResumeLayout(false);
            this.pnlConsultoriosContainer.PerformLayout();
            this.pnlFilaPacientes.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblTituloConsultorios;
        private System.Windows.Forms.Label lblTituloFilaPacientes;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}