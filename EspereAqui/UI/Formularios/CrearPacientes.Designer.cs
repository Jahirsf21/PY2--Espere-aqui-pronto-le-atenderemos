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
            pictureBox1 = new PictureBox();
            mainTableLayoutPanel = new TableLayoutPanel();
            inputTableLayoutPanel = new TableLayoutPanel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            comboBox3 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            btnCrearPaciente = new Label();
            btnRegresar = new Label();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mainTableLayoutPanel.SuspendLayout();
            inputTableLayoutPanel.SuspendLayout();
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
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.BackColor = Color.Transparent;
            mainTableLayoutPanel.ColumnCount = 2;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            mainTableLayoutPanel.Controls.Add(inputTableLayoutPanel, 0, 0);
            mainTableLayoutPanel.Controls.Add(richTextBox1, 1, 0);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.Padding = new Padding(20);
            mainTableLayoutPanel.RowCount = 1;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Size = new Size(932, 553);
            mainTableLayoutPanel.TabIndex = 13;
            // 
            // inputTableLayoutPanel
            // 
            inputTableLayoutPanel.BackColor = Color.Transparent;
            inputTableLayoutPanel.ColumnCount = 1;
            inputTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            inputTableLayoutPanel.Controls.Add(textBox2, 0, 1);
            inputTableLayoutPanel.Controls.Add(textBox1, 0, 2);
            inputTableLayoutPanel.Controls.Add(label1, 0, 3);
            inputTableLayoutPanel.Controls.Add(comboBox3, 0, 4);
            inputTableLayoutPanel.Controls.Add(label2, 0, 5);
            inputTableLayoutPanel.Controls.Add(comboBox2, 0, 6);
            inputTableLayoutPanel.Controls.Add(btnCrearPaciente, 0, 8);
            inputTableLayoutPanel.Controls.Add(btnRegresar, 0, 10);
            inputTableLayoutPanel.Dock = DockStyle.Fill;
            inputTableLayoutPanel.Location = new Point(23, 23);
            inputTableLayoutPanel.Name = "inputTableLayoutPanel";
            inputTableLayoutPanel.RowCount = 12;
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            inputTableLayoutPanel.RowStyles.Add(new RowStyle());
            inputTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            inputTableLayoutPanel.Size = new Size(306, 507);
            inputTableLayoutPanel.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(3, 11);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escribe el nombre";
            textBox2.Size = new Size(300, 27);
            textBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 51);
            textBox1.Margin = new Padding(3, 10, 3, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escribe el apellido";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 101);
            label1.Margin = new Padding(3, 20, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.TabIndex = 2;
            label1.Text = "Selecciona tu género";
            // 
            // comboBox3
            // 
            comboBox3.Dock = DockStyle.Fill;
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Hombre", "Mujer" });
            comboBox3.Location = new Point(3, 124);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(300, 28);
            comboBox3.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 175);
            label2.Margin = new Padding(3, 20, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(300, 20);
            label2.TabIndex = 4;
            label2.Text = "Selecciona la especialidad";
            // 
            // comboBox2
            // 
            comboBox2.Dock = DockStyle.Fill;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Medicina general", "Odontología", "Cardiología", "Pediatría", "Urología", "Ginecología", "Dermatología", "Oftalmología", "Nutriólogo" });
            comboBox2.Location = new Point(3, 198);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(300, 28);
            comboBox2.TabIndex = 5;
            // 
            // btnCrearPaciente
            // 
            btnCrearPaciente.Anchor = AnchorStyles.None;
            btnCrearPaciente.BackColor = Color.Transparent;
            btnCrearPaciente.BorderStyle = BorderStyle.FixedSingle;
            btnCrearPaciente.Cursor = Cursors.Hand;
            btnCrearPaciente.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCrearPaciente.ForeColor = Color.White;
            btnCrearPaciente.Location = new Point(53, 246);
            btnCrearPaciente.Name = "btnCrearPaciente";
            btnCrearPaciente.Size = new Size(200, 53);
            btnCrearPaciente.TabIndex = 6;
            btnCrearPaciente.Text = "Crear paciente";
            btnCrearPaciente.TextAlign = ContentAlignment.MiddleCenter;
            btnCrearPaciente.Click += btnCrearPaciente_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.None;
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.BorderStyle = BorderStyle.FixedSingle;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(53, 307);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(200, 54);
            btnRegresar.TabIndex = 7;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleCenter;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(335, 23);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(574, 507);
            richTextBox1.TabIndex = 11;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "";
            // 
            // CrearPacientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(mainTableLayoutPanel);
            Controls.Add(pictureBox1);
            Name = "CrearPacientes";
            Text = "Crear Pacientes";
            WindowState = FormWindowState.Maximized;
            Load += CrearPacientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mainTableLayoutPanel.ResumeLayout(false);
            inputTableLayoutPanel.ResumeLayout(false);
            inputTableLayoutPanel.PerformLayout();
            ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label btnCrearPaciente;
        private System.Windows.Forms.Label btnRegresar;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}