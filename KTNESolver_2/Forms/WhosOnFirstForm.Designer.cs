namespace KTNESolver_2.Forms
{
    partial class WhosOnFirstForm
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
            comboTitle = new ComboBox();
            grbInput = new GroupBox();
            pbTL = new PictureBox();
            pbTR = new PictureBox();
            pbML = new PictureBox();
            pbMR = new PictureBox();
            pbBL = new PictureBox();
            pbBR = new PictureBox();
            tableBoxes = new TableLayoutPanel();
            grbAnswer = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnNext = new Button();
            btnReset = new Button();
            btnPrev = new Button();
            lblAnswer = new Label();
            comboRead = new ComboBox();
            grbInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbTL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbML).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBR).BeginInit();
            tableBoxes.SuspendLayout();
            grbAnswer.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboTitle
            // 
            comboTitle.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboTitle.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboTitle.Dock = DockStyle.Fill;
            comboTitle.FormattingEnabled = true;
            comboTitle.Items.AddRange(new object[] { "*", "10", "BUMM", "C", "CE", "CN", "COUP", "DA STEHT", "FERTIG", "JA", "KUH", "LEER", "MOMENT", "NEIN", "NICHTS", "OBEN", "OH GOTT", "OKAY", "Q", "SO EIN", "SO'N", "SOHN", "WARTE", "ZÄH", "ZEH", "ZEHEN", "ZEHN", "ZU SPÄT" });
            comboTitle.Location = new Point(3, 19);
            comboTitle.Name = "comboTitle";
            comboTitle.Size = new Size(185, 23);
            comboTitle.Sorted = true;
            comboTitle.TabIndex = 0;
            comboTitle.SelectedIndexChanged += comboTitle_SelectionChangeCommitted;
            // 
            // grbInput
            // 
            grbInput.Controls.Add(comboTitle);
            grbInput.Location = new Point(9, 7);
            grbInput.Name = "grbInput";
            grbInput.Size = new Size(191, 54);
            grbInput.TabIndex = 1;
            grbInput.TabStop = false;
            grbInput.Text = "Anzeige";
            // 
            // pbTL
            // 
            pbTL.BackColor = Color.White;
            pbTL.Dock = DockStyle.Fill;
            pbTL.Image = Properties.Resources.Eye;
            pbTL.Location = new Point(4, 4);
            pbTL.Name = "pbTL";
            pbTL.Size = new Size(88, 68);
            pbTL.SizeMode = PictureBoxSizeMode.Zoom;
            pbTL.TabIndex = 0;
            pbTL.TabStop = false;
            pbTL.Visible = false;
            // 
            // pbTR
            // 
            pbTR.BackColor = Color.White;
            pbTR.Dock = DockStyle.Fill;
            pbTR.ErrorImage = Properties.Resources.Eye;
            pbTR.Image = Properties.Resources.Eye;
            pbTR.InitialImage = Properties.Resources.Eye;
            pbTR.Location = new Point(99, 4);
            pbTR.Name = "pbTR";
            pbTR.Size = new Size(88, 68);
            pbTR.SizeMode = PictureBoxSizeMode.Zoom;
            pbTR.TabIndex = 1;
            pbTR.TabStop = false;
            pbTR.Visible = false;
            // 
            // pbML
            // 
            pbML.BackColor = Color.White;
            pbML.Dock = DockStyle.Fill;
            pbML.ErrorImage = Properties.Resources.Eye;
            pbML.Image = Properties.Resources.Eye;
            pbML.InitialImage = Properties.Resources.Eye;
            pbML.Location = new Point(4, 79);
            pbML.Name = "pbML";
            pbML.Size = new Size(88, 68);
            pbML.SizeMode = PictureBoxSizeMode.Zoom;
            pbML.TabIndex = 2;
            pbML.TabStop = false;
            pbML.Visible = false;
            // 
            // pbMR
            // 
            pbMR.BackColor = Color.White;
            pbMR.Dock = DockStyle.Fill;
            pbMR.ErrorImage = Properties.Resources.Eye;
            pbMR.Image = Properties.Resources.Eye;
            pbMR.InitialImage = Properties.Resources.Eye;
            pbMR.Location = new Point(99, 79);
            pbMR.Name = "pbMR";
            pbMR.Size = new Size(88, 68);
            pbMR.SizeMode = PictureBoxSizeMode.Zoom;
            pbMR.TabIndex = 3;
            pbMR.TabStop = false;
            pbMR.Visible = false;
            // 
            // pbBL
            // 
            pbBL.BackColor = Color.White;
            pbBL.Dock = DockStyle.Fill;
            pbBL.ErrorImage = Properties.Resources.Eye;
            pbBL.Image = Properties.Resources.Eye;
            pbBL.InitialImage = Properties.Resources.Eye;
            pbBL.Location = new Point(4, 154);
            pbBL.Name = "pbBL";
            pbBL.Size = new Size(88, 71);
            pbBL.SizeMode = PictureBoxSizeMode.Zoom;
            pbBL.TabIndex = 4;
            pbBL.TabStop = false;
            pbBL.Visible = false;
            // 
            // pbBR
            // 
            pbBR.BackColor = Color.White;
            pbBR.Dock = DockStyle.Fill;
            pbBR.ErrorImage = Properties.Resources.Eye;
            pbBR.Image = Properties.Resources.Eye;
            pbBR.InitialImage = Properties.Resources.Eye;
            pbBR.Location = new Point(99, 154);
            pbBR.Name = "pbBR";
            pbBR.Size = new Size(88, 71);
            pbBR.SizeMode = PictureBoxSizeMode.Zoom;
            pbBR.TabIndex = 5;
            pbBR.TabStop = false;
            pbBR.Visible = false;
            // 
            // tableBoxes
            // 
            tableBoxes.BackColor = Color.White;
            tableBoxes.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableBoxes.ColumnCount = 2;
            tableBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBoxes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableBoxes.Controls.Add(pbTL, 0, 0);
            tableBoxes.Controls.Add(pbBR, 1, 2);
            tableBoxes.Controls.Add(pbTR, 1, 0);
            tableBoxes.Controls.Add(pbBL, 0, 2);
            tableBoxes.Controls.Add(pbMR, 1, 1);
            tableBoxes.Controls.Add(pbML, 0, 1);
            tableBoxes.Location = new Point(9, 60);
            tableBoxes.Name = "tableBoxes";
            tableBoxes.RowCount = 3;
            tableBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableBoxes.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableBoxes.Size = new Size(191, 229);
            tableBoxes.TabIndex = 3;
            // 
            // grbAnswer
            // 
            grbAnswer.Controls.Add(tableLayoutPanel1);
            grbAnswer.Controls.Add(lblAnswer);
            grbAnswer.Controls.Add(comboRead);
            grbAnswer.Location = new Point(9, 295);
            grbAnswer.Name = "grbAnswer";
            grbAnswer.Size = new Size(191, 164);
            grbAnswer.TabIndex = 4;
            grbAnswer.TabStop = false;
            grbAnswer.Text = "Antwort";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnNext, 2, 0);
            tableLayoutPanel1.Controls.Add(btnReset, 1, 0);
            tableLayoutPanel1.Controls.Add(btnPrev, 0, 0);
            tableLayoutPanel1.Location = new Point(6, 105);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(179, 53);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnNext
            // 
            btnNext.Dock = DockStyle.Fill;
            btnNext.Location = new Point(121, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(55, 47);
            btnNext.TabIndex = 5;
            btnNext.Text = ">>";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnReset
            // 
            btnReset.Dock = DockStyle.Fill;
            btnReset.Location = new Point(62, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(53, 47);
            btnReset.TabIndex = 6;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnPrev
            // 
            btnPrev.Dock = DockStyle.Fill;
            btnPrev.Location = new Point(3, 3);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(53, 47);
            btnPrev.TabIndex = 4;
            btnPrev.Text = "<<";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += btnPrev_Click;
            // 
            // lblAnswer
            // 
            lblAnswer.AutoSize = true;
            lblAnswer.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAnswer.Location = new Point(58, 61);
            lblAnswer.Name = "lblAnswer";
            lblAnswer.Size = new Size(72, 21);
            lblAnswer.TabIndex = 3;
            lblAnswer.Text = "Antwort";
            // 
            // comboRead
            // 
            comboRead.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboRead.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboRead.Dock = DockStyle.Fill;
            comboRead.FormattingEnabled = true;
            comboRead.Location = new Point(3, 19);
            comboRead.Name = "comboRead";
            comboRead.Size = new Size(185, 23);
            comboRead.Sorted = true;
            comboRead.TabIndex = 2;
            comboRead.SelectedIndexChanged += comboRead_SelectedIndexChanged;
            // 
            // WhosOnFirstForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 461);
            Controls.Add(grbAnswer);
            Controls.Add(tableBoxes);
            Controls.Add(grbInput);
            Name = "WhosOnFirstForm";
            Text = "WOF Solver";
            grbInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbTL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbML).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMR).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBL).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBR).EndInit();
            tableBoxes.ResumeLayout(false);
            grbAnswer.ResumeLayout(false);
            grbAnswer.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboTitle;
        private GroupBox grbInput;
        private PictureBox pbTL;
        private PictureBox pbTR;
        private PictureBox pbML;
        private PictureBox pbMR;
        private PictureBox pbBL;
        private PictureBox pbBR;
        private TableLayoutPanel tableBoxes;
        private GroupBox grbAnswer;
        private Label lblAnswer;
        private ComboBox comboRead;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNext;
        private Button btnReset;
        private Button btnPrev;
    }
}