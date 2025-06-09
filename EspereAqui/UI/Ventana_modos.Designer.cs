namespace EspereAqui.UI
{
    partial class Ventana_modos
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
            btnModoManual = new Label();
            btnRegresar = new Label();
            btnModoAuto = new Label();
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
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnModoManual, 0, 3);
            tableLayoutPanel1.Controls.Add(btnRegresar, 0, 5);
            tableLayoutPanel1.Controls.Add(btnModoAuto, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.Size = new Size(932, 553);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnModoManual
            // 
            btnModoManual.Anchor = AnchorStyles.None;
            btnModoManual.BackColor = Color.Transparent;
            btnModoManual.Cursor = Cursors.Hand;
            btnModoManual.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnModoManual.ForeColor = Color.White;
            btnModoManual.Location = new Point(359, 232);
            btnModoManual.Name = "btnModoManual";
            btnModoManual.Size = new Size(214, 44);
            btnModoManual.TabIndex = 1;
            btnModoManual.Text = "Modo manual";
            btnModoManual.TextAlign = ContentAlignment.MiddleCenter;
            btnModoManual.Click += btnModoManual_Click;
            // 
            // btnRegresar
            // 
            btnRegresar.Anchor = AnchorStyles.None;
            btnRegresar.BackColor = Color.Transparent;
            btnRegresar.Cursor = Cursors.Hand;
            btnRegresar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRegresar.ForeColor = Color.White;
            btnRegresar.Location = new Point(359, 345);
            btnRegresar.Name = "btnRegresar";
            btnRegresar.Size = new Size(214, 44);
            btnRegresar.TabIndex = 2;
            btnRegresar.Text = "Regresar";
            btnRegresar.TextAlign = ContentAlignment.MiddleCenter;
            btnRegresar.Click += btnRegresar_Click;
            // 
            // btnModoAuto
            // 
            btnModoAuto.Anchor = AnchorStyles.None;
            btnModoAuto.BackColor = Color.Transparent;
            btnModoAuto.Cursor = Cursors.Hand;
            btnModoAuto.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnModoAuto.ForeColor = Color.White;
            btnModoAuto.Location = new Point(359, 152);
            btnModoAuto.Name = "btnModoAuto";
            btnModoAuto.Size = new Size(214, 44);
            btnModoAuto.TabIndex = 0;
            btnModoAuto.Text = "Modo automático";
            btnModoAuto.TextAlign = ContentAlignment.MiddleCenter;
            btnModoAuto.Click += btnModoAuto_Click;
            // 
            // Ventana_modos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 553);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Name = "Ventana_modos";
            Text = "Ventana_modos";
            WindowState = FormWindowState.Maximized;
            Load += Ventana_modos_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label btnModoAuto;
        private System.Windows.Forms.Label btnModoManual;
        private System.Windows.Forms.Label btnRegresar;
    }
}