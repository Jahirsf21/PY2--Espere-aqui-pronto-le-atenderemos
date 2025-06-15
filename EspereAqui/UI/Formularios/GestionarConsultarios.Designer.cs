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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.inputTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblConsultorio = new System.Windows.Forms.Label();
            this.cmbConsultorios = new System.Windows.Forms.ComboBox();
            this.pnlEspecialidades = new System.Windows.Forms.TableLayoutPanel();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.btnAnadirEspecialidad = new System.Windows.Forms.Button();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lstEspecialidadesAgregadas = new System.Windows.Forms.ListBox();
            this.btnQuitarEspecialidad = new System.Windows.Forms.Button();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.btnCrear = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Label();
            this.rtbInfoConsultorios = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.inputTableLayoutPanel.SuspendLayout();
            this.pnlEspecialidades.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = Properties.Resources.fondo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(932, 553);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.mainTableLayoutPanel.Controls.Add(this.inputTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.rtbInfoConsultorios, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(932, 553);
            this.mainTableLayoutPanel.TabIndex = 14;
            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.ColumnCount = 1;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLayoutPanel.Controls.Add(this.lblConsultorio, 0, 0);
            this.inputTableLayoutPanel.Controls.Add(this.cmbConsultorios, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.lblEspecialidad, 0, 2);
            this.inputTableLayoutPanel.Controls.Add(this.pnlEspecialidades, 0, 3);
            this.inputTableLayoutPanel.Controls.Add(this.lstEspecialidadesAgregadas, 0, 4);
            this.inputTableLayoutPanel.Controls.Add(this.btnQuitarEspecialidad, 0, 5);
            this.inputTableLayoutPanel.Controls.Add(this.chkEstado, 0, 6);
            this.inputTableLayoutPanel.Controls.Add(this.btnCrear, 0, 7);
            this.inputTableLayoutPanel.Controls.Add(this.btnEditar, 0, 8);
            this.inputTableLayoutPanel.Controls.Add(this.btnEliminar, 0, 9);
            this.inputTableLayoutPanel.Controls.Add(this.btnLimpiar, 0, 10);
            this.inputTableLayoutPanel.Controls.Add(this.btnRegresar, 0, 11);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(23, 23);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 13;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(350, 507);
            this.inputTableLayoutPanel.TabIndex = 0;
            // 
            // lblConsultorio
            // 
            this.lblConsultorio.AutoSize = true;
            this.lblConsultorio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblConsultorio.ForeColor = System.Drawing.Color.White;
            this.lblConsultorio.Location = new System.Drawing.Point(3, 10);
            this.lblConsultorio.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.lblConsultorio.Name = "lblConsultorio";
            this.lblConsultorio.Size = new System.Drawing.Size(264, 20);
            this.lblConsultorio.TabIndex = 0;
            this.lblConsultorio.Text = "Seleccionar Consultorio (para editar)";
            // 
            // cmbConsultorios
            // 
            this.cmbConsultorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbConsultorios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbConsultorios.FormattingEnabled = true;
            this.cmbConsultorios.Location = new System.Drawing.Point(3, 33);
            this.cmbConsultorios.Name = "cmbConsultorios";
            this.cmbConsultorios.Size = new System.Drawing.Size(344, 28);
            this.cmbConsultorios.TabIndex = 1;
            this.cmbConsultorios.SelectedIndexChanged += new System.EventHandler(this.cmbConsultorios_SelectedIndexChanged);
            // 
            // pnlEspecialidades
            // 
            this.pnlEspecialidades.ColumnCount = 2;
            this.pnlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.pnlEspecialidades.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.pnlEspecialidades.Controls.Add(this.cmbEspecialidad, 0, 0);
            this.pnlEspecialidades.Controls.Add(this.btnAnadirEspecialidad, 1, 0);
            this.pnlEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEspecialidades.Location = new System.Drawing.Point(0, 84);
            this.pnlEspecialidades.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEspecialidades.Name = "pnlEspecialidades";
            this.pnlEspecialidades.RowCount = 1;
            this.pnlEspecialidades.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlEspecialidades.Size = new System.Drawing.Size(350, 34);
            this.pnlEspecialidades.TabIndex = 2;
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(3, 3);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(239, 28);
            this.cmbEspecialidad.TabIndex = 0;
            // 
            // btnAnadirEspecialidad
            // 
            this.btnAnadirEspecialidad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAnadirEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnAnadirEspecialidad.Location = new System.Drawing.Point(248, 3);
            this.btnAnadirEspecialidad.Name = "btnAnadirEspecialidad";
            this.btnAnadirEspecialidad.Size = new System.Drawing.Size(99, 28);
            this.btnAnadirEspecialidad.TabIndex = 1;
            this.btnAnadirEspecialidad.Text = "Añadir";
            this.btnAnadirEspecialidad.UseVisualStyleBackColor = true;
            this.btnAnadirEspecialidad.Click += new System.EventHandler(this.btnAnadirEspecialidad_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEspecialidad.ForeColor = System.Drawing.Color.White;
            this.lblEspecialidad.Location = new System.Drawing.Point(3, 64);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(172, 20);
            this.lblEspecialidad.TabIndex = 3;
            this.lblEspecialidad.Text = "Especialidades (Máx. 5)";
            // 
            // lstEspecialidadesAgregadas
            // 
            this.lstEspecialidadesAgregadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstEspecialidadesAgregadas.FormattingEnabled = true;
            this.lstEspecialidadesAgregadas.Location = new System.Drawing.Point(3, 121);
            this.lstEspecialidadesAgregadas.Name = "lstEspecialidadesAgregadas";
            this.lstEspecialidadesAgregadas.Size = new System.Drawing.Size(344, 114);
            this.lstEspecialidadesAgregadas.TabIndex = 4;
            // 
            // btnQuitarEspecialidad
            // 
            this.btnQuitarEspecialidad.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuitarEspecialidad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuitarEspecialidad.ForeColor = System.Drawing.Color.Red;
            this.btnQuitarEspecialidad.Location = new System.Drawing.Point(177, 241);
            this.btnQuitarEspecialidad.Name = "btnQuitarEspecialidad";
            this.btnQuitarEspecialidad.Size = new System.Drawing.Size(170, 29);
            this.btnQuitarEspecialidad.TabIndex = 5;
            this.btnQuitarEspecialidad.Text = "Quitar Seleccionada";
            this.btnQuitarEspecialidad.UseVisualStyleBackColor = true;
            this.btnQuitarEspecialidad.Click += new System.EventHandler(this.btnQuitarEspecialidad_Click);
            // 
            // chkEstado
            // 
            this.chkEstado.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkEstado.AutoSize = true;
            this.chkEstado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.chkEstado.ForeColor = System.Drawing.Color.White;
            this.chkEstado.Location = new System.Drawing.Point(10, 279);
            this.chkEstado.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(93, 27);
            this.chkEstado.TabIndex = 7;
            this.chkEstado.Text = "Abierto";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(75, 315);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(200, 39);
            this.btnCrear.TabIndex = 8;
            this.btnCrear.Text = "Crear Nuevo";
            this.btnCrear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(75, 360);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(200, 39);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Guardar Cambios";
            this.btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnEliminar.ForeColor = System.Drawing.Color.Tomato;
            this.btnEliminar.Location = new System.Drawing.Point(75, 405);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(200, 39);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLimpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(75, 450);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(200, 39);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar / Nuevo";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(75, 495);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(200, 39);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // rtbInfoConsultorios
            // 
            this.rtbInfoConsultorios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbInfoConsultorios.Location = new System.Drawing.Point(379, 23);
            this.rtbInfoConsultorios.Name = "rtbInfoConsultorios";
            this.rtbInfoConsultorios.ReadOnly = true;
            this.rtbInfoConsultorios.Size = new System.Drawing.Size(530, 507);
            this.rtbInfoConsultorios.TabIndex = 1;
            this.rtbInfoConsultorios.Text = "";
            // 
            // GestionarConsultorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionarConsultorios";
            this.Text = "Gestionar Consultorios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionarConsultorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.PerformLayout();
            this.pnlEspecialidades.ResumeLayout(false);
            this.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnQuitarEspecialidad;
    }
}