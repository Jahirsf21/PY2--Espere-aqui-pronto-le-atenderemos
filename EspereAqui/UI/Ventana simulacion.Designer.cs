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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBotonesGestion = new System.Windows.Forms.TableLayoutPanel();
            this.btnGestionarPacientes = new System.Windows.Forms.Label();
            this.btnGestionarConsultorios = new System.Windows.Forms.Label();
            this.pnlConsultoriosContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlBotonesGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 505);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlBotonesGestion
            // 
            this.pnlBotonesGestion.BackColor = System.Drawing.Color.Transparent;
            this.pnlBotonesGestion.ColumnCount = 2;
            this.pnlBotonesGestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBotonesGestion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBotonesGestion.Controls.Add(this.btnGestionarPacientes, 0, 0);
            this.pnlBotonesGestion.Controls.Add(this.btnGestionarConsultorios, 1, 0);
            this.pnlBotonesGestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotonesGestion.Location = new System.Drawing.Point(0, 425);
            this.pnlBotonesGestion.Name = "pnlBotonesGestion";
            this.pnlBotonesGestion.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.pnlBotonesGestion.RowCount = 1;
            this.pnlBotonesGestion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pnlBotonesGestion.Size = new System.Drawing.Size(900, 80);
            this.pnlBotonesGestion.TabIndex = 1;
            // 
            // btnGestionarPacientes
            // 
            this.btnGestionarPacientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarPacientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGestionarPacientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarPacientes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionarPacientes.ForeColor = System.Drawing.Color.White;
            this.btnGestionarPacientes.Location = new System.Drawing.Point(124, 15);
            this.btnGestionarPacientes.Name = "btnGestionarPacientes";
            this.btnGestionarPacientes.Size = new System.Drawing.Size(202, 50);
            this.btnGestionarPacientes.TabIndex = 0;
            this.btnGestionarPacientes.Text = "Gestionar Pacientes";
            this.btnGestionarPacientes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGestionarPacientes.Click += new System.EventHandler(this.btnGestionarPacientes_Click);
            // 
            // btnGestionarConsultorios
            // 
            this.btnGestionarConsultorios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGestionarConsultorios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGestionarConsultorios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarConsultorios.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGestionarConsultorios.ForeColor = System.Drawing.Color.White;
            this.btnGestionarConsultorios.Location = new System.Drawing.Point(550, 15);
            this.btnGestionarConsultorios.Name = "btnGestionarConsultorios";
            this.btnGestionarConsultorios.Size = new System.Drawing.Size(250, 50);
            this.btnGestionarConsultorios.TabIndex = 1;
            this.btnGestionarConsultorios.Text = "Gestionar Consultorios";
            this.btnGestionarConsultorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGestionarConsultorios.Click += new System.EventHandler(this.btnGestionarConsultorios_Click);
            // 
            // pnlConsultoriosContainer
            // 
            this.pnlConsultoriosContainer.AutoScroll = true;
            this.pnlConsultoriosContainer.BackColor = System.Drawing.Color.Transparent;
            this.pnlConsultoriosContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConsultoriosContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlConsultoriosContainer.Name = "pnlConsultoriosContainer";
            this.pnlConsultoriosContainer.Padding = new System.Windows.Forms.Padding(20);
            this.pnlConsultoriosContainer.Size = new System.Drawing.Size(900, 425);
            this.pnlConsultoriosContainer.TabIndex = 2;
            // 
            // Ventana_simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 505);
            this.Controls.Add(this.pnlConsultoriosContainer);
            this.Controls.Add(this.pnlBotonesGestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Ventana_simulacion";
            this.Text = "Simulacion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.Ventana_simulacion_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlBotonesGestion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel pnlBotonesGestion;
        private System.Windows.Forms.Label btnGestionarPacientes;
        private System.Windows.Forms.Label btnGestionarConsultorios;
        private System.Windows.Forms.FlowLayoutPanel pnlConsultoriosContainer;
        private ToolTip toolTipInfo;
    }
}
