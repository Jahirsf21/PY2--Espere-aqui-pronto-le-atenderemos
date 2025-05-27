namespace EspereAqui
{
    partial class Modo_auto
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(319, 304);
            button3.Name = "button3";
            button3.Size = new Size(163, 39);
            button3.TabIndex = 6;
            button3.Text = "Regresar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(319, 188);
            button2.Name = "button2";
            button2.Size = new Size(163, 39);
            button2.TabIndex = 5;
            button2.Text = "Empezar simulación";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(319, 246);
            button1.Name = "button1";
            button1.Size = new Size(163, 39);
            button1.TabIndex = 7;
            button1.Text = "Cargar datos";
            button1.UseVisualStyleBackColor = true;
            // 
            // Modo_auto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 479);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Modo_auto";
            Text = "Modo automatico";
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
    }
}