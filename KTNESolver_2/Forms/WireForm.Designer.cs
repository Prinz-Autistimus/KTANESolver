namespace KTNESolver_2.Forms
{
    partial class WireForm
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
            tableLayoutPanel1 = new TableLayoutPanel();
            rbRed1 = new RadioButton();
            rbBlue1 = new RadioButton();
            rbWhite1 = new RadioButton();
            rbBlack1 = new RadioButton();
            rbYellow1 = new RadioButton();
            rbNone1 = new RadioButton();
            tableLayoutPanel2 = new TableLayoutPanel();
            rbRed2 = new RadioButton();
            rbBlue2 = new RadioButton();
            rbWhite2 = new RadioButton();
            rbBlack2 = new RadioButton();
            rbYellow2 = new RadioButton();
            rbNone2 = new RadioButton();
            tableLayoutPanel3 = new TableLayoutPanel();
            rbRed3 = new RadioButton();
            rbBlue3 = new RadioButton();
            rbWhite3 = new RadioButton();
            rbBlack3 = new RadioButton();
            rbYellow3 = new RadioButton();
            rbNone3 = new RadioButton();
            tableLayoutPanel4 = new TableLayoutPanel();
            rbRed4 = new RadioButton();
            rbBlue4 = new RadioButton();
            rbWhite4 = new RadioButton();
            rbBlack4 = new RadioButton();
            rbYellow4 = new RadioButton();
            rbNone4 = new RadioButton();
            tableLayoutPanel5 = new TableLayoutPanel();
            rbRed5 = new RadioButton();
            rbBlue5 = new RadioButton();
            rbWhite5 = new RadioButton();
            rbBlack5 = new RadioButton();
            rbYellow5 = new RadioButton();
            rbNone5 = new RadioButton();
            tableLayoutPanel6 = new TableLayoutPanel();
            rbRed6 = new RadioButton();
            rbBlue6 = new RadioButton();
            rbWhite6 = new RadioButton();
            rbBlack6 = new RadioButton();
            rbYellow6 = new RadioButton();
            rbNone6 = new RadioButton();
            grbWires = new GroupBox();
            lbl1 = new Label();
            lblOut = new Label();
            btnReset = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            grbWires.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Controls.Add(rbRed1, 0, 0);
            tableLayoutPanel1.Controls.Add(rbBlue1, 1, 0);
            tableLayoutPanel1.Controls.Add(rbWhite1, 2, 0);
            tableLayoutPanel1.Controls.Add(rbBlack1, 3, 0);
            tableLayoutPanel1.Controls.Add(rbYellow1, 4, 0);
            tableLayoutPanel1.Controls.Add(rbNone1, 5, 0);
            tableLayoutPanel1.Location = new Point(6, 22);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(405, 41);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // rbRed1
            // 
            rbRed1.AutoSize = true;
            rbRed1.BackColor = Color.Red;
            rbRed1.Dock = DockStyle.Fill;
            rbRed1.Location = new Point(4, 4);
            rbRed1.Name = "rbRed1";
            rbRed1.Size = new Size(60, 33);
            rbRed1.TabIndex = 0;
            rbRed1.UseVisualStyleBackColor = false;
            rbRed1.CheckedChanged += solve;
            // 
            // rbBlue1
            // 
            rbBlue1.AutoSize = true;
            rbBlue1.BackColor = Color.DodgerBlue;
            rbBlue1.Dock = DockStyle.Fill;
            rbBlue1.Location = new Point(71, 4);
            rbBlue1.Name = "rbBlue1";
            rbBlue1.Size = new Size(60, 33);
            rbBlue1.TabIndex = 1;
            rbBlue1.UseVisualStyleBackColor = false;
            rbBlue1.CheckedChanged += solve;
            // 
            // rbWhite1
            // 
            rbWhite1.AutoSize = true;
            rbWhite1.BackColor = Color.White;
            rbWhite1.Dock = DockStyle.Fill;
            rbWhite1.Location = new Point(138, 4);
            rbWhite1.Name = "rbWhite1";
            rbWhite1.Size = new Size(60, 33);
            rbWhite1.TabIndex = 2;
            rbWhite1.UseVisualStyleBackColor = false;
            rbWhite1.CheckedChanged += solve;
            // 
            // rbBlack1
            // 
            rbBlack1.AutoSize = true;
            rbBlack1.BackColor = Color.Black;
            rbBlack1.Dock = DockStyle.Fill;
            rbBlack1.Location = new Point(205, 4);
            rbBlack1.Name = "rbBlack1";
            rbBlack1.Size = new Size(60, 33);
            rbBlack1.TabIndex = 3;
            rbBlack1.UseVisualStyleBackColor = false;
            rbBlack1.CheckedChanged += solve;
            // 
            // rbYellow1
            // 
            rbYellow1.AutoSize = true;
            rbYellow1.BackColor = Color.Yellow;
            rbYellow1.Dock = DockStyle.Fill;
            rbYellow1.Location = new Point(272, 4);
            rbYellow1.Name = "rbYellow1";
            rbYellow1.Size = new Size(60, 33);
            rbYellow1.TabIndex = 4;
            rbYellow1.UseVisualStyleBackColor = false;
            rbYellow1.CheckedChanged += solve;
            // 
            // rbNone1
            // 
            rbNone1.AutoSize = true;
            rbNone1.Checked = true;
            rbNone1.Dock = DockStyle.Fill;
            rbNone1.Location = new Point(339, 4);
            rbNone1.Name = "rbNone1";
            rbNone1.Size = new Size(62, 33);
            rbNone1.TabIndex = 5;
            rbNone1.TabStop = true;
            rbNone1.Text = "None";
            rbNone1.UseVisualStyleBackColor = true;
            rbNone1.CheckedChanged += solve;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel2.ColumnCount = 6;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel2.Controls.Add(rbRed2, 0, 0);
            tableLayoutPanel2.Controls.Add(rbBlue2, 1, 0);
            tableLayoutPanel2.Controls.Add(rbWhite2, 2, 0);
            tableLayoutPanel2.Controls.Add(rbBlack2, 3, 0);
            tableLayoutPanel2.Controls.Add(rbYellow2, 4, 0);
            tableLayoutPanel2.Controls.Add(rbNone2, 5, 0);
            tableLayoutPanel2.Location = new Point(6, 69);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(405, 41);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // rbRed2
            // 
            rbRed2.AutoSize = true;
            rbRed2.BackColor = Color.Red;
            rbRed2.Dock = DockStyle.Fill;
            rbRed2.Location = new Point(4, 4);
            rbRed2.Name = "rbRed2";
            rbRed2.Size = new Size(60, 33);
            rbRed2.TabIndex = 0;
            rbRed2.UseVisualStyleBackColor = false;
            rbRed2.CheckedChanged += solve;
            // 
            // rbBlue2
            // 
            rbBlue2.AutoSize = true;
            rbBlue2.BackColor = Color.DodgerBlue;
            rbBlue2.Dock = DockStyle.Fill;
            rbBlue2.Location = new Point(71, 4);
            rbBlue2.Name = "rbBlue2";
            rbBlue2.Size = new Size(60, 33);
            rbBlue2.TabIndex = 1;
            rbBlue2.UseVisualStyleBackColor = false;
            rbBlue2.CheckedChanged += solve;
            // 
            // rbWhite2
            // 
            rbWhite2.AutoSize = true;
            rbWhite2.BackColor = Color.White;
            rbWhite2.Dock = DockStyle.Fill;
            rbWhite2.Location = new Point(138, 4);
            rbWhite2.Name = "rbWhite2";
            rbWhite2.Size = new Size(60, 33);
            rbWhite2.TabIndex = 2;
            rbWhite2.UseVisualStyleBackColor = false;
            rbWhite2.CheckedChanged += solve;
            // 
            // rbBlack2
            // 
            rbBlack2.AutoSize = true;
            rbBlack2.BackColor = Color.Black;
            rbBlack2.Dock = DockStyle.Fill;
            rbBlack2.Location = new Point(205, 4);
            rbBlack2.Name = "rbBlack2";
            rbBlack2.Size = new Size(60, 33);
            rbBlack2.TabIndex = 3;
            rbBlack2.UseVisualStyleBackColor = false;
            rbBlack2.CheckedChanged += solve;
            // 
            // rbYellow2
            // 
            rbYellow2.AutoSize = true;
            rbYellow2.BackColor = Color.Yellow;
            rbYellow2.Dock = DockStyle.Fill;
            rbYellow2.Location = new Point(272, 4);
            rbYellow2.Name = "rbYellow2";
            rbYellow2.Size = new Size(60, 33);
            rbYellow2.TabIndex = 4;
            rbYellow2.UseVisualStyleBackColor = false;
            rbYellow2.CheckedChanged += solve;
            // 
            // rbNone2
            // 
            rbNone2.AutoSize = true;
            rbNone2.Checked = true;
            rbNone2.Dock = DockStyle.Fill;
            rbNone2.Location = new Point(339, 4);
            rbNone2.Name = "rbNone2";
            rbNone2.Size = new Size(62, 33);
            rbNone2.TabIndex = 5;
            rbNone2.TabStop = true;
            rbNone2.Text = "None";
            rbNone2.UseVisualStyleBackColor = true;
            rbNone2.CheckedChanged += solve;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel3.ColumnCount = 6;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel3.Controls.Add(rbRed3, 0, 0);
            tableLayoutPanel3.Controls.Add(rbBlue3, 1, 0);
            tableLayoutPanel3.Controls.Add(rbWhite3, 2, 0);
            tableLayoutPanel3.Controls.Add(rbBlack3, 3, 0);
            tableLayoutPanel3.Controls.Add(rbYellow3, 4, 0);
            tableLayoutPanel3.Controls.Add(rbNone3, 5, 0);
            tableLayoutPanel3.Location = new Point(6, 116);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(405, 41);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // rbRed3
            // 
            rbRed3.AutoSize = true;
            rbRed3.BackColor = Color.Red;
            rbRed3.Dock = DockStyle.Fill;
            rbRed3.Location = new Point(4, 4);
            rbRed3.Name = "rbRed3";
            rbRed3.Size = new Size(60, 33);
            rbRed3.TabIndex = 0;
            rbRed3.UseVisualStyleBackColor = false;
            rbRed3.CheckedChanged += solve;
            // 
            // rbBlue3
            // 
            rbBlue3.AutoSize = true;
            rbBlue3.BackColor = Color.DodgerBlue;
            rbBlue3.Dock = DockStyle.Fill;
            rbBlue3.Location = new Point(71, 4);
            rbBlue3.Name = "rbBlue3";
            rbBlue3.Size = new Size(60, 33);
            rbBlue3.TabIndex = 1;
            rbBlue3.UseVisualStyleBackColor = false;
            rbBlue3.CheckedChanged += solve;
            // 
            // rbWhite3
            // 
            rbWhite3.AutoSize = true;
            rbWhite3.BackColor = Color.White;
            rbWhite3.Dock = DockStyle.Fill;
            rbWhite3.Location = new Point(138, 4);
            rbWhite3.Name = "rbWhite3";
            rbWhite3.Size = new Size(60, 33);
            rbWhite3.TabIndex = 2;
            rbWhite3.UseVisualStyleBackColor = false;
            rbWhite3.CheckedChanged += solve;
            // 
            // rbBlack3
            // 
            rbBlack3.AutoSize = true;
            rbBlack3.BackColor = Color.Black;
            rbBlack3.Dock = DockStyle.Fill;
            rbBlack3.Location = new Point(205, 4);
            rbBlack3.Name = "rbBlack3";
            rbBlack3.Size = new Size(60, 33);
            rbBlack3.TabIndex = 3;
            rbBlack3.UseVisualStyleBackColor = false;
            rbBlack3.CheckedChanged += solve;
            // 
            // rbYellow3
            // 
            rbYellow3.AutoSize = true;
            rbYellow3.BackColor = Color.Yellow;
            rbYellow3.Dock = DockStyle.Fill;
            rbYellow3.Location = new Point(272, 4);
            rbYellow3.Name = "rbYellow3";
            rbYellow3.Size = new Size(60, 33);
            rbYellow3.TabIndex = 4;
            rbYellow3.UseVisualStyleBackColor = false;
            rbYellow3.CheckedChanged += solve;
            // 
            // rbNone3
            // 
            rbNone3.AutoSize = true;
            rbNone3.Checked = true;
            rbNone3.Dock = DockStyle.Fill;
            rbNone3.Location = new Point(339, 4);
            rbNone3.Name = "rbNone3";
            rbNone3.Size = new Size(62, 33);
            rbNone3.TabIndex = 5;
            rbNone3.TabStop = true;
            rbNone3.Text = "None";
            rbNone3.UseVisualStyleBackColor = true;
            rbNone3.CheckedChanged += solve;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel4.ColumnCount = 6;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.Controls.Add(rbRed4, 0, 0);
            tableLayoutPanel4.Controls.Add(rbBlue4, 1, 0);
            tableLayoutPanel4.Controls.Add(rbWhite4, 2, 0);
            tableLayoutPanel4.Controls.Add(rbBlack4, 3, 0);
            tableLayoutPanel4.Controls.Add(rbYellow4, 4, 0);
            tableLayoutPanel4.Controls.Add(rbNone4, 5, 0);
            tableLayoutPanel4.Location = new Point(6, 163);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(405, 41);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // rbRed4
            // 
            rbRed4.AutoSize = true;
            rbRed4.BackColor = Color.Red;
            rbRed4.Dock = DockStyle.Fill;
            rbRed4.Location = new Point(4, 4);
            rbRed4.Name = "rbRed4";
            rbRed4.Size = new Size(60, 33);
            rbRed4.TabIndex = 0;
            rbRed4.UseVisualStyleBackColor = false;
            rbRed4.CheckedChanged += solve;
            // 
            // rbBlue4
            // 
            rbBlue4.AutoSize = true;
            rbBlue4.BackColor = Color.DodgerBlue;
            rbBlue4.Dock = DockStyle.Fill;
            rbBlue4.Location = new Point(71, 4);
            rbBlue4.Name = "rbBlue4";
            rbBlue4.Size = new Size(60, 33);
            rbBlue4.TabIndex = 1;
            rbBlue4.UseVisualStyleBackColor = false;
            rbBlue4.CheckedChanged += solve;
            // 
            // rbWhite4
            // 
            rbWhite4.AutoSize = true;
            rbWhite4.BackColor = Color.White;
            rbWhite4.Dock = DockStyle.Fill;
            rbWhite4.Location = new Point(138, 4);
            rbWhite4.Name = "rbWhite4";
            rbWhite4.Size = new Size(60, 33);
            rbWhite4.TabIndex = 2;
            rbWhite4.UseVisualStyleBackColor = false;
            rbWhite4.CheckedChanged += solve;
            // 
            // rbBlack4
            // 
            rbBlack4.AutoSize = true;
            rbBlack4.BackColor = Color.Black;
            rbBlack4.Dock = DockStyle.Fill;
            rbBlack4.Location = new Point(205, 4);
            rbBlack4.Name = "rbBlack4";
            rbBlack4.Size = new Size(60, 33);
            rbBlack4.TabIndex = 3;
            rbBlack4.UseVisualStyleBackColor = false;
            rbBlack4.CheckedChanged += solve;
            // 
            // rbYellow4
            // 
            rbYellow4.AutoSize = true;
            rbYellow4.BackColor = Color.Yellow;
            rbYellow4.Dock = DockStyle.Fill;
            rbYellow4.Location = new Point(272, 4);
            rbYellow4.Name = "rbYellow4";
            rbYellow4.Size = new Size(60, 33);
            rbYellow4.TabIndex = 4;
            rbYellow4.UseVisualStyleBackColor = false;
            rbYellow4.CheckedChanged += solve;
            // 
            // rbNone4
            // 
            rbNone4.AutoSize = true;
            rbNone4.Checked = true;
            rbNone4.Dock = DockStyle.Fill;
            rbNone4.Location = new Point(339, 4);
            rbNone4.Name = "rbNone4";
            rbNone4.Size = new Size(62, 33);
            rbNone4.TabIndex = 5;
            rbNone4.TabStop = true;
            rbNone4.Text = "None";
            rbNone4.UseVisualStyleBackColor = true;
            rbNone4.CheckedChanged += solve;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel5.ColumnCount = 6;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel5.Controls.Add(rbRed5, 0, 0);
            tableLayoutPanel5.Controls.Add(rbBlue5, 1, 0);
            tableLayoutPanel5.Controls.Add(rbWhite5, 2, 0);
            tableLayoutPanel5.Controls.Add(rbBlack5, 3, 0);
            tableLayoutPanel5.Controls.Add(rbYellow5, 4, 0);
            tableLayoutPanel5.Controls.Add(rbNone5, 5, 0);
            tableLayoutPanel5.Location = new Point(6, 210);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(405, 41);
            tableLayoutPanel5.TabIndex = 4;
            // 
            // rbRed5
            // 
            rbRed5.AutoSize = true;
            rbRed5.BackColor = Color.Red;
            rbRed5.Dock = DockStyle.Fill;
            rbRed5.Location = new Point(4, 4);
            rbRed5.Name = "rbRed5";
            rbRed5.Size = new Size(60, 33);
            rbRed5.TabIndex = 0;
            rbRed5.UseVisualStyleBackColor = false;
            rbRed5.CheckedChanged += solve;
            // 
            // rbBlue5
            // 
            rbBlue5.AutoSize = true;
            rbBlue5.BackColor = Color.DodgerBlue;
            rbBlue5.Dock = DockStyle.Fill;
            rbBlue5.Location = new Point(71, 4);
            rbBlue5.Name = "rbBlue5";
            rbBlue5.Size = new Size(60, 33);
            rbBlue5.TabIndex = 1;
            rbBlue5.UseVisualStyleBackColor = false;
            rbBlue5.CheckedChanged += solve;
            // 
            // rbWhite5
            // 
            rbWhite5.AutoSize = true;
            rbWhite5.BackColor = Color.White;
            rbWhite5.Dock = DockStyle.Fill;
            rbWhite5.Location = new Point(138, 4);
            rbWhite5.Name = "rbWhite5";
            rbWhite5.Size = new Size(60, 33);
            rbWhite5.TabIndex = 2;
            rbWhite5.UseVisualStyleBackColor = false;
            rbWhite5.CheckedChanged += solve;
            // 
            // rbBlack5
            // 
            rbBlack5.AutoSize = true;
            rbBlack5.BackColor = Color.Black;
            rbBlack5.Dock = DockStyle.Fill;
            rbBlack5.Location = new Point(205, 4);
            rbBlack5.Name = "rbBlack5";
            rbBlack5.Size = new Size(60, 33);
            rbBlack5.TabIndex = 3;
            rbBlack5.UseVisualStyleBackColor = false;
            rbBlack5.CheckedChanged += solve;
            // 
            // rbYellow5
            // 
            rbYellow5.AutoSize = true;
            rbYellow5.BackColor = Color.Yellow;
            rbYellow5.Dock = DockStyle.Fill;
            rbYellow5.Location = new Point(272, 4);
            rbYellow5.Name = "rbYellow5";
            rbYellow5.Size = new Size(60, 33);
            rbYellow5.TabIndex = 4;
            rbYellow5.UseVisualStyleBackColor = false;
            rbYellow5.CheckedChanged += solve;
            // 
            // rbNone5
            // 
            rbNone5.AutoSize = true;
            rbNone5.Checked = true;
            rbNone5.Dock = DockStyle.Fill;
            rbNone5.Location = new Point(339, 4);
            rbNone5.Name = "rbNone5";
            rbNone5.Size = new Size(62, 33);
            rbNone5.TabIndex = 5;
            rbNone5.TabStop = true;
            rbNone5.Text = "None";
            rbNone5.UseVisualStyleBackColor = true;
            rbNone5.CheckedChanged += solve;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel6.ColumnCount = 6;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel6.Controls.Add(rbRed6, 0, 0);
            tableLayoutPanel6.Controls.Add(rbBlue6, 1, 0);
            tableLayoutPanel6.Controls.Add(rbWhite6, 2, 0);
            tableLayoutPanel6.Controls.Add(rbBlack6, 3, 0);
            tableLayoutPanel6.Controls.Add(rbYellow6, 4, 0);
            tableLayoutPanel6.Controls.Add(rbNone6, 5, 0);
            tableLayoutPanel6.Location = new Point(6, 257);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(405, 41);
            tableLayoutPanel6.TabIndex = 5;
            // 
            // rbRed6
            // 
            rbRed6.AutoSize = true;
            rbRed6.BackColor = Color.Red;
            rbRed6.Dock = DockStyle.Fill;
            rbRed6.Location = new Point(4, 4);
            rbRed6.Name = "rbRed6";
            rbRed6.Size = new Size(60, 33);
            rbRed6.TabIndex = 0;
            rbRed6.UseVisualStyleBackColor = false;
            rbRed6.CheckedChanged += solve;
            // 
            // rbBlue6
            // 
            rbBlue6.AutoSize = true;
            rbBlue6.BackColor = Color.DodgerBlue;
            rbBlue6.Dock = DockStyle.Fill;
            rbBlue6.Location = new Point(71, 4);
            rbBlue6.Name = "rbBlue6";
            rbBlue6.Size = new Size(60, 33);
            rbBlue6.TabIndex = 1;
            rbBlue6.UseVisualStyleBackColor = false;
            rbBlue6.CheckedChanged += solve;
            // 
            // rbWhite6
            // 
            rbWhite6.AutoSize = true;
            rbWhite6.BackColor = Color.White;
            rbWhite6.Dock = DockStyle.Fill;
            rbWhite6.Location = new Point(138, 4);
            rbWhite6.Name = "rbWhite6";
            rbWhite6.Size = new Size(60, 33);
            rbWhite6.TabIndex = 2;
            rbWhite6.UseVisualStyleBackColor = false;
            rbWhite6.CheckedChanged += solve;
            // 
            // rbBlack6
            // 
            rbBlack6.AutoSize = true;
            rbBlack6.BackColor = Color.Black;
            rbBlack6.Dock = DockStyle.Fill;
            rbBlack6.Location = new Point(205, 4);
            rbBlack6.Name = "rbBlack6";
            rbBlack6.Size = new Size(60, 33);
            rbBlack6.TabIndex = 3;
            rbBlack6.UseVisualStyleBackColor = false;
            rbBlack6.CheckedChanged += solve;
            // 
            // rbYellow6
            // 
            rbYellow6.AutoSize = true;
            rbYellow6.BackColor = Color.Yellow;
            rbYellow6.Dock = DockStyle.Fill;
            rbYellow6.Location = new Point(272, 4);
            rbYellow6.Name = "rbYellow6";
            rbYellow6.Size = new Size(60, 33);
            rbYellow6.TabIndex = 4;
            rbYellow6.UseVisualStyleBackColor = false;
            rbYellow6.CheckedChanged += solve;
            // 
            // rbNone6
            // 
            rbNone6.AutoSize = true;
            rbNone6.Checked = true;
            rbNone6.Dock = DockStyle.Fill;
            rbNone6.Location = new Point(339, 4);
            rbNone6.Name = "rbNone6";
            rbNone6.Size = new Size(62, 33);
            rbNone6.TabIndex = 5;
            rbNone6.TabStop = true;
            rbNone6.Text = "None";
            rbNone6.UseVisualStyleBackColor = true;
            rbNone6.CheckedChanged += solve;
            // 
            // grbWires
            // 
            grbWires.Controls.Add(tableLayoutPanel1);
            grbWires.Controls.Add(tableLayoutPanel6);
            grbWires.Controls.Add(tableLayoutPanel2);
            grbWires.Controls.Add(tableLayoutPanel5);
            grbWires.Controls.Add(tableLayoutPanel3);
            grbWires.Controls.Add(tableLayoutPanel4);
            grbWires.Location = new Point(12, 12);
            grbWires.Name = "grbWires";
            grbWires.Size = new Size(419, 306);
            grbWires.TabIndex = 0;
            grbWires.TabStop = false;
            grbWires.Text = "Wires";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BorderStyle = BorderStyle.Fixed3D;
            lbl1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.Location = new Point(494, 39);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(145, 27);
            lbl1.TabIndex = 2;
            lbl1.Text = "Ready to Solve";
            // 
            // lblOut
            // 
            lblOut.AutoSize = true;
            lblOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOut.Location = new Point(494, 97);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(149, 21);
            lblOut.TabIndex = 3;
            lblOut.Text = "Not enough Wires";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(494, 269);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(145, 41);
            btnReset.TabIndex = 4;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // WireForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 336);
            Controls.Add(btnReset);
            Controls.Add(lblOut);
            Controls.Add(lbl1);
            Controls.Add(grbWires);
            Name = "WireForm";
            Text = "Wire Solver";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            grbWires.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton rbRed1;
        private RadioButton rbBlue1;
        private RadioButton rbWhite1;
        private RadioButton rbBlack1;
        private RadioButton rbYellow1;
        private RadioButton rbNone1;
        private TableLayoutPanel tableLayoutPanel2;
        private RadioButton rbRed2;
        private RadioButton rbBlue2;
        private RadioButton rbWhite2;
        private RadioButton rbBlack2;
        private RadioButton rbYellow2;
        private RadioButton rbNone2;
        private TableLayoutPanel tableLayoutPanel3;
        private RadioButton rbRed3;
        private RadioButton rbBlue3;
        private RadioButton rbWhite3;
        private RadioButton rbBlack3;
        private RadioButton rbYellow3;
        private RadioButton rbNone3;
        private TableLayoutPanel tableLayoutPanel4;
        private RadioButton rbRed4;
        private RadioButton rbBlue4;
        private RadioButton rbWhite4;
        private RadioButton rbBlack4;
        private RadioButton rbYellow4;
        private RadioButton rbNone4;
        private TableLayoutPanel tableLayoutPanel5;
        private RadioButton rbRed5;
        private RadioButton rbBlue5;
        private RadioButton rbWhite5;
        private RadioButton rbBlack5;
        private RadioButton rbYellow5;
        private RadioButton rbNone5;
        private TableLayoutPanel tableLayoutPanel6;
        private RadioButton rbRed6;
        private RadioButton rbBlue6;
        private RadioButton rbWhite6;
        private RadioButton rbBlack6;
        private RadioButton rbYellow6;
        private RadioButton rbNone6;
        private GroupBox grbWires;
        private Label lbl1;
        private Label lblOut;
        private Button btnReset;
    }
}