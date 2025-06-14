namespace EspereAqui.UI.Formularios
{
    partial class CrearPacientes
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkLstEspecialidades = new System.Windows.Forms.CheckedListBox(); 
            this.btnCrearPaciente = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainTableLayoutPanel.SuspendLayout();
            this.inputTableLayoutPanel.SuspendLayout();
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
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.mainTableLayoutPanel.ColumnCount = 2;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.mainTableLayoutPanel.Controls.Add(this.inputTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.richTextBox1, 1, 0);
            this.mainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.Padding = new System.Windows.Forms.Padding(20);
            this.mainTableLayoutPanel.RowCount = 1;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(932, 553);
            this.mainTableLayoutPanel.TabIndex = 13;
            // 
            // inputTableLayoutPanel
            // 
            this.inputTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.inputTableLayoutPanel.ColumnCount = 1;
            this.inputTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.inputTableLayoutPanel.Controls.Add(this.textBox2, 0, 1);
            this.inputTableLayoutPanel.Controls.Add(this.textBox1, 0, 2);
            this.inputTableLayoutPanel.Controls.Add(this.label1, 0, 3);
            this.inputTableLayoutPanel.Controls.Add(this.comboBox3, 0, 4);
            this.inputTableLayoutPanel.Controls.Add(this.label2, 0, 5);
            this.inputTableLayoutPanel.Controls.Add(this.chkLstEspecialidades, 0, 6);
            this.inputTableLayoutPanel.Controls.Add(this.btnCrearPaciente, 0, 8);
            this.inputTableLayoutPanel.Controls.Add(this.btnRegresar, 0, 10);
            this.inputTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTableLayoutPanel.Location = new System.Drawing.Point(23, 23);
            this.inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            this.inputTableLayoutPanel.RowCount = 12;
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inputTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.inputTableLayoutPanel.Size = new System.Drawing.Size(306, 507);
            this.inputTableLayoutPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(3, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Escribe el nombre";
            this.textBox2.Size = new System.Drawing.Size(300, 27);
            this.textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Escribe el apellido";
            this.textBox1.Size = new System.Drawing.Size(300, 27);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona tu género";
            // 
            // comboBox3
            // 
            this.comboBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] { "Hombre", "Mujer" });
            this.comboBox3.Location = new System.Drawing.Point(3, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(300, 28);
            this.comboBox3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selecciona la especialidad (máx. 2)";
            // 
            // chkLstEspecialidades
            // 
            this.chkLstEspecialidades.CheckOnClick = true;
            this.chkLstEspecialidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkLstEspecialidades.FormattingEnabled = true;
            this.chkLstEspecialidades.Items.AddRange(new object[] {
            "Medicina general",
            "Odontología",
            "Cardiología",
            "Pediatría",
            "Urología",
            "Ginecología",
            "Dermatología",
            "Oftalmología",
            "Nutriólogo"});
            this.chkLstEspecialidades.Location = new System.Drawing.Point(3, 197);
            this.chkLstEspecialidades.Name = "chkLstEspecialidades";
            this.chkLstEspecialidades.Size = new System.Drawing.Size(300, 144);
            this.chkLstEspecialidades.TabIndex = 5;
            // 
            // btnCrearPaciente
            // 
            this.btnCrearPaciente.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearPaciente.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearPaciente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnCrearPaciente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearPaciente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCrearPaciente.ForeColor = System.Drawing.Color.White;
            this.btnCrearPaciente.Location = new System.Drawing.Point(53, 344);
            this.btnCrearPaciente.Name = "btnCrearPaciente";
            this.btnCrearPaciente.Size = new System.Drawing.Size(200, 53);
            this.btnCrearPaciente.TabIndex = 6;
            this.btnCrearPaciente.Text = "Crear paciente";
            this.btnCrearPaciente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCrearPaciente.Click += new System.EventHandler(this.btnCrearPaciente_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(53, 401);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(200, 54);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(335, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(574, 507);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // CrearPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 553);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CrearPacientes";
            this.Text = "Crear Pacientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CrearPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.ResumeLayout(false);
            this.inputTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel inputTableLayoutPanel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox chkLstEspecialidades;
        private System.Windows.Forms.Label btnCrearPaciente;
        private System.Windows.Forms.Label btnRegresar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}