namespace EspereAqui.UI.Formularios
{
    partial class GestionarConsultorios
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
            pictureBox1 = new PictureBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            inputTableLayoutPanel = new TableLayoutPanel();
            lblConsultorio = new Label();
            cmbConsultorios = new ComboBox();
            pnlEspecialidades = new TableLayoutPanel();
            cmbEspecialidad = new ComboBox();
            btnAnadirEspecialidad = new Button();
            lblEspecialidad = new Label();
            lstEspecialidadesAgregadas = new ListBox();
            chkEstado = new CheckBox();
            btnCrear = new Label();
            btnEditar = new Label();
            btnEliminar = new Label();
            btnLimpiar = new Label();
            btnRegresar = new Label();
            rtbInfoConsultorios = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            inputTableLayoutPanel.SuspendLayout();
            pnlEspecialidades.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 553);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.BackColor = Color.Transparent;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            mainTableLayoutPanel.Controls.Add(inputTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(rtbInfoConsultorios, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(20);
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(932, 553);
            mainTableLayoutPanel.TabIndex = 14;
            // 
            // inputTableLayoutPanel
            // 
            inputTableLayoutPanel.ColumnCount = 1;
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputTableLayoutPanel.Controls.Add(lblConsultorio, 0, 0);
            inputTableLayoutPanel.Controls.Add(cmbConsultorios, 0, 1);
            inputTableLayoutPanel.Controls.Add(lblEspecialidad, 0, 2);
            inputTableLayoutPanel.Controls.Add(pnlEspecialidades, 0, 3);
            inputTableLayoutPanel.Controls.Add(lstEspecialidadesAgregadas, 0, 4);
            inputTableLayoutPanel.Controls.Add(chkEstado, 0, 5);
            inputTableLayoutPanel.Controls.Add(btnCrear, 0, 6);
            inputTableLayoutPanel.Controls.Add(btnEditar, 0, 7);
            inputTableLayoutPanel.Controls.Add(btnEliminar, 0, 8);
            inputTableLayoutPanel.Controls.Add(btnLimpiar, 0, 9);
            inputTableLayoutPanel.Controls.Add(btnRegresar, 0, 10);
            inputTableLayoutPanel.Dock = DockStyle.Fill;
            inputTableLayoutPanel.Location = new Point(23, 23);
            inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            inputTableLayoutPanel.RowCount = 12;
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            inputTableLayoutPanel.Size = new Size(350, 507);
            inputTableLayoutPanel.TabIndex = 0;
            // 
            // lblConsultorio
            // 
            lblConsultorio.AutoSize = true;
            lblConsultorio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblConsultorio.ForeColor = Color.White;
            lblConsultorio.Location = new Point(3, 10);
            lblConsultorio.Margin = new Padding(3, 10, 3, 0);
            lblConsultorio.Name = "lblConsultorio";
            lblConsultorio.Size = new Size(264, 20);
            lblConsultorio.TabIndex = 0;
            lblConsultorio.Text = "Seleccionar Consultorio (para editar)";
            // 
            // cmbConsultorios
            // 
            cmbConsultorios.Dock = DockStyle.Fill;
            cmbConsultorios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbConsultorios.FormattingEnabled = true;
            cmbConsultorios.Location = new Point(3, 33);
            cmbConsultorios.Name = "cmbConsultorios";
            cmbConsultorios.Size = new Size(344, 28);
            cmbConsultorios.TabIndex = 1;
            cmbConsultorios.SelectedIndexChanged += cmbConsultorios_SelectedIndexChanged;
            // 
            // pnlEspecialidades
            // 
            pnlEspecialidades.ColumnCount = 2;
            pnlEspecialidades.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            pnlEspecialidades.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlEspecialidades.Controls.Add(cmbEspecialidad, 0, 0);
            pnlEspecialidades.Controls.Add(btnAnadirEspecialidad, 1, 0);
            pnlEspecialidades.Dock = DockStyle.Fill;
            pnlEspecialidades.Location = new Point(0, 84);
            pnlEspecialidades.Margin = new Padding(0);
            pnlEspecialidades.Name = "pnlEspecialidades";
            pnlEspecialidades.RowCount = 1;
            pnlEspecialidades.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlEspecialidades.Size = new Size(350, 34);
            pnlEspecialidades.TabIndex = 2;
            // 
            // cmbEspecialidad
            // 
            cmbEspecialidad.Dock = DockStyle.Fill;
            cmbEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEspecialidad.FormattingEnabled = true;
            cmbEspecialidad.Location = new Point(3, 3);
            cmbEspecialidad.Name = "cmbEspecialidad";
            cmbEspecialidad.Size = new Size(239, 28);
            cmbEspecialidad.TabIndex = 0;
            // 
            // btnAnadirEspecialidad
            // 
            btnAnadirEspecialidad.Dock = DockStyle.Fill;
            btnAnadirEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnadirEspecialidad.Location = new Point(248, 3);
            btnAnadirEspecialidad.Name = "btnAnadirEspecialidad";
            btnAnadirEspecialidad.Size = new Size(99, 28);
            btnAnadirEspecialidad.TabIndex = 1;
            btnAnadirEspecialidad.Text = "Añadir";
            btnAnadirEspecialidad.UseVisualStyleBackColor = true;
            btnAnadirEspecialidad.Click += btnAnadirEspecialidad_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEspecialidad.ForeColor = Color.White;
            lblEspecialidad.Location = new Point(3, 64);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(172, 20);
            lblEspecialidad.TabIndex = 3;
            lblEspecialidad.Text = "Especialidades (Máx. 5)";
            // 
            // lstEspecialidadesAgregadas
            // 
            lstEspecialidadesAgregadas.Dock = DockStyle.Fill;
            lstEspecialidadesAgregadas.FormattingEnabled = true;
            lstEspecialidadesAgregadas.Location = new Point(3, 121);
            lstEspecialidadesAgregadas.Name = "lstEspecialidadesAgregadas";
            lstEspecialidadesAgregadas.Size = new Size(344, 114);
            lstEspecialidadesAgregadas.TabIndex = 4;
            // 
            // chkEstado
            // 
            chkEstado.Anchor = AnchorStyles.Left;
            chkEstado.AutoSize = true;
            chkEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            chkEstado.ForeColor = Color.White;
            chkEstado.Location = new Point(10, 244);
            chkEstado.Margin = new Padding(10, 3, 3, 3);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(93, 27);
            chkEstado.TabIndex = 7;
            chkEstado.Text = "Abierto";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            btnCrear.Anchor = AnchorStyles.None;
            btnCrear.BorderStyle = BorderStyle.FixedSingle;
            btnCrear.Cursor = Cursors.Hand;
            btnCrear.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCrear.ForeColor = Color.White;
            btnCrear.Location = new Point(75, 281);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(200, 39);
            btnCrear.TabIndex = 8;
            btnCrear.Text = "Crear Nuevo";
            btnCrear.TextAlign = ContentAlignment.MiddleCenter;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnEditar
            // 
            btnEditar.Anchor = AnchorStyles.None;
            btnEditar.BorderStyle = BorderStyle.FixedSingle;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(75, 326);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(200, 39);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Guardar Cambios";
            btnEditar.TextAlign = ContentAlignment.MiddleCenter;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Anchor = AnchorStyles.None;
            btnEliminar.BorderStyle = BorderStyle.FixedSingle;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.Tomato;
            btnEliminar.Location = new Point(75, 371);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(200, 39);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextAlign = ContentAlignment.MiddleCenter;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Anchor = AnchorStyles.None;
            btnLimpiar.BorderStyle = BorderStyle.FixedSingle;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(75, 416);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(200, 39);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar / Nuevo";
            btnLimpiar.TextAlign = ContentAlignment.MiddleCenter;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.None;
            btnRegresar.BorderStyle = BorderStyle.FixedSingle;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(75, 461);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(200, 39);
            btnRegresar.TabIndex = 12;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleCenter;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // rtbInfoConsultorios
            // 
            rtbInfoConsultorios.Dock = DockStyle.Fill;
            rtbInfoConsultorios.Location = new Point(379, 23);
            rtbInfoConsultorios.Name = "rtbInfoConsultorios";
            rtbInfoConsultorios.ReadOnly = true;
            rtbInfoConsultorios.Size = new Size(530, 507);
            rtbInfoConsultorios.TabIndex = 1;
            rtbInfoConsultorios.Text = "";
            // 
            // GestionarConsultorios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(pictureBox1);
            Name = "GestionarConsultorios";
            Text = "Gestionar Consultorios";
            WindowState = FormWindowState.Maximized;
            Load += GestionarConsultorios_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            inputTableLayoutPanel.ResumeLayout(false);
            inputTableLayoutPanel.PerformLayout();
            pnlEspecialidades.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.Label lblConsultorio;
        private System.Windows.Forms.ComboBox cmbConsultorios;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label btnCrear;
        private System.Windows.Forms.Label btnEditar;
        private System.Windows.Forms.Label btnEliminar;
        private System.Windows.Forms.Label btnRegresar;
        private System.Windows.Forms.RichTextBox rtbInfoConsultorios;
        private System.Windows.Forms.Label btnLimpiar;
        private System.Windows.Forms.TableLayoutPanel pnlEspecialidades;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button btnAnadirEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.ListBox lstEspecialidadesAgregadas;
    }
}