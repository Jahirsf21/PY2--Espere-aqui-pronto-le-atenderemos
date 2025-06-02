namespace EspereAqui.UI
{
    partial class Ventana_manual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox3 = new ComboBox();
            button3 = new Button();
            textBox3 = new TextBox();
            richTextBox1 = new RichTextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 363);
            button1.Name = "button1";
            button1.Size = new Size(148, 54);
            button1.TabIndex = 0;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Medicina general", "Odontología", "Cardiología", "Pediatría", "Urología", "Ginecología", "Dermatología", "Oftalmología", "Nutriólogo" });
            comboBox2.Location = new Point(62, 234);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(62, 84);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escribe el apellido";
            textBox1.Size = new Size(151, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(59, 36);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Escribe el nombre";
            textBox2.Size = new Size(151, 27);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(62, 130);
            label1.Name = "label1";
            label1.Size = new Size(151, 25);
            label1.TabIndex = 6;
            label1.Text = "Seleccióna tu genero";
            // 
            // label2
            // 
            label2.Location = new Point(62, 206);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 7;
            label2.Text = "Seleccióna la especialidad";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Hombre", "Mujer" });
            comboBox3.Location = new Point(62, 158);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 8;
            // 
            // button3
            // 
            button3.Location = new Point(62, 284);
            button3.Name = "button3";
            button3.Size = new Size(148, 53);
            button3.TabIndex = 9;
            button3.Text = "Crear paciente";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(444, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(0, 27);
            textBox3.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(325, 31);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(542, 428);
            richTextBox1.TabIndex = 11;
            richTextBox1.TabStop = false;
            richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.fondo1;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(932, 553);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // Ventana_manual
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(932, 553);
            Controls.Add(richTextBox1);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(comboBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Ventana_manual";
            Text = "Ventana_manual";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox3;
        private Button button3;
        private TextBox textBox3;
        private RichTextBox richTextBox1;
        private PictureBox pictureBox1;
    }
}