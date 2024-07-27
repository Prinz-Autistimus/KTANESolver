namespace KTNESolver_2.Forms
{
    partial class CWireForm
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
            cbRed = new CheckBox();
            cbBlue = new CheckBox();
            cbStar = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cbLED = new CheckBox();
            label1 = new Label();
            pbCut = new PictureBox();
            pbDont = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbCut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbDont).BeginInit();
            SuspendLayout();
            // 
            // cbRed
            // 
            cbRed.AutoSize = true;
            cbRed.BackColor = Color.Red;
            cbRed.Dock = DockStyle.Fill;
            cbRed.Location = new Point(4, 4);
            cbRed.Name = "cbRed";
            cbRed.Size = new Size(70, 67);
            cbRed.TabIndex = 0;
            cbRed.UseVisualStyleBackColor = false;
            cbRed.CheckedChanged += solve;
            // 
            // cbBlue
            // 
            cbBlue.AutoSize = true;
            cbBlue.BackColor = Color.DodgerBlue;
            cbBlue.Dock = DockStyle.Fill;
            cbBlue.Location = new Point(81, 4);
            cbBlue.Name = "cbBlue";
            cbBlue.Size = new Size(70, 67);
            cbBlue.TabIndex = 1;
            cbBlue.UseVisualStyleBackColor = false;
            cbBlue.CheckedChanged += solve;
            // 
            // cbStar
            // 
            cbStar.AutoSize = true;
            cbStar.BackColor = SystemColors.Control;
            cbStar.BackgroundImage = Properties.Resources.filledstar;
            cbStar.BackgroundImageLayout = ImageLayout.Zoom;
            cbStar.Dock = DockStyle.Fill;
            cbStar.Location = new Point(158, 4);
            cbStar.Name = "cbStar";
            cbStar.Size = new Size(70, 67);
            cbStar.TabIndex = 2;
            cbStar.UseVisualStyleBackColor = false;
            cbStar.CheckedChanged += solve;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(cbRed, 0, 0);
            tableLayoutPanel1.Controls.Add(cbStar, 2, 0);
            tableLayoutPanel1.Controls.Add(cbBlue, 1, 0);
            tableLayoutPanel1.Controls.Add(cbLED, 3, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(310, 75);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // cbLED
            // 
            cbLED.AutoSize = true;
            cbLED.BackgroundImage = Properties.Resources.LED;
            cbLED.BackgroundImageLayout = ImageLayout.Zoom;
            cbLED.Dock = DockStyle.Fill;
            cbLED.Location = new Point(235, 4);
            cbLED.Name = "cbLED";
            cbLED.Size = new Size(71, 67);
            cbLED.TabIndex = 3;
            cbLED.UseVisualStyleBackColor = true;
            cbLED.CheckedChanged += solve;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 110);
            label1.Name = "label1";
            label1.Size = new Size(170, 30);
            label1.TabIndex = 4;
            label1.Text = "Durchtrennen? :";
            // 
            // pbCut
            // 
            pbCut.BackgroundImage = Properties.Resources.tick;
            pbCut.BackgroundImageLayout = ImageLayout.Zoom;
            pbCut.Location = new Point(194, 99);
            pbCut.Name = "pbCut";
            pbCut.Size = new Size(60, 56);
            pbCut.TabIndex = 5;
            pbCut.TabStop = false;
            // 
            // pbDont
            // 
            pbDont.BackgroundImage = Properties.Resources.x;
            pbDont.BackgroundImageLayout = ImageLayout.Zoom;
            pbDont.Location = new Point(254, 99);
            pbDont.Name = "pbDont";
            pbDont.Size = new Size(60, 56);
            pbDont.TabIndex = 6;
            pbDont.TabStop = false;
            pbDont.Visible = false;
            // 
            // CWireForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 173);
            Controls.Add(pbDont);
            Controls.Add(pbCut);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Name = "CWireForm";
            Text = "CWireForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbCut).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbDont).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox cbRed;
        private CheckBox cbBlue;
        private CheckBox cbStar;
        private TableLayoutPanel tableLayoutPanel1;
        private CheckBox cbLED;
        private Label label1;
        private PictureBox pbCut;
        private PictureBox pbDont;
    }
}