namespace EspereAqui.UI
{
    partial class Ventana_principal
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btnEmpezar = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEmpezar, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Size = new Size(932, 553);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(156, 151);
            label1.Name = "label1";
            label1.Size = new Size(619, 45);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido a tu Clínica de confianza";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Anchor = AnchorStyles.None;
            btnEmpezar.BackColor = Color.Transparent;
            btnEmpezar.Cursor = Cursors.Hand;
            btnEmpezar.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnEmpezar.ForeColor = Color.White;
            btnEmpezar.Location = new Point(382, 282);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(167, 75);
            btnEmpezar.TabIndex = 1;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.TextAlign = ContentAlignment.MiddleCenter;
            btnEmpezar.Click += btnEmpezar_Click;
            // 
            // Ventana_principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Ventana_principal";
            Text = "Espere aqui UI";
            WindowState = FormWindowState.Maximized;
            Load += Ventana_principal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1; 
        private Label label1;
        private Label btnEmpezar; 
    }
}