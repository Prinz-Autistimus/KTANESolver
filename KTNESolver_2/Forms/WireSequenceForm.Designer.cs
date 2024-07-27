namespace KTNESolver_2.Forms
{
    partial class WireSequenceForm
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
            lblRed = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBlack = new Button();
            btnBlue = new Button();
            flowBlack = new FlowLayoutPanel();
            rbBlackA = new RadioButton();
            rbBlackB = new RadioButton();
            rbBlackC = new RadioButton();
            flowBlue = new FlowLayoutPanel();
            rbBlueA = new RadioButton();
            rbBlueB = new RadioButton();
            rbBlueC = new RadioButton();
            lblBlack = new Label();
            lblBlue = new Label();
            flowRed = new FlowLayoutPanel();
            rbRedA = new RadioButton();
            rbRedB = new RadioButton();
            rbRedC = new RadioButton();
            btnRed = new Button();
            btnReset = new Button();
            label4 = new Label();
            grbOut = new GroupBox();
            pbX = new PictureBox();
            pbTick = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            flowBlack.SuspendLayout();
            flowBlue.SuspendLayout();
            flowRed.SuspendLayout();
            grbOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbTick).BeginInit();
            SuspendLayout();
            // 
            // lblRed
            // 
            lblRed.BackColor = Color.Red;
            lblRed.Dock = DockStyle.Fill;
            lblRed.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblRed.Location = new Point(4, 1);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(57, 45);
            lblRed.TabIndex = 0;
            lblRed.Text = "0";
            lblRed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(btnBlack, 2, 2);
            tableLayoutPanel1.Controls.Add(btnBlue, 1, 2);
            tableLayoutPanel1.Controls.Add(flowBlack, 2, 1);
            tableLayoutPanel1.Controls.Add(flowBlue, 1, 1);
            tableLayoutPanel1.Controls.Add(lblBlack, 2, 0);
            tableLayoutPanel1.Controls.Add(lblBlue, 1, 0);
            tableLayoutPanel1.Controls.Add(lblRed, 0, 0);
            tableLayoutPanel1.Controls.Add(flowRed, 0, 1);
            tableLayoutPanel1.Controls.Add(btnRed, 0, 2);
            tableLayoutPanel1.Location = new Point(9, 9);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 21.2962971F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.5370369F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.5714283F));
            tableLayoutPanel1.Size = new Size(193, 217);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnBlack
            // 
            btnBlack.Dock = DockStyle.Fill;
            btnBlack.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBlack.Location = new Point(132, 157);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(57, 56);
            btnBlack.TabIndex = 10;
            btnBlack.Text = "Set";
            btnBlack.UseVisualStyleBackColor = true;
            btnBlack.Click += btnBlack_Click;
            // 
            // btnBlue
            // 
            btnBlue.Dock = DockStyle.Fill;
            btnBlue.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnBlue.Location = new Point(68, 157);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(57, 56);
            btnBlue.TabIndex = 9;
            btnBlue.Text = "Set";
            btnBlue.UseVisualStyleBackColor = true;
            btnBlue.Click += btnBlue_Click;
            // 
            // flowBlack
            // 
            flowBlack.Controls.Add(rbBlackA);
            flowBlack.Controls.Add(rbBlackB);
            flowBlack.Controls.Add(rbBlackC);
            flowBlack.Dock = DockStyle.Fill;
            flowBlack.Location = new Point(132, 50);
            flowBlack.Name = "flowBlack";
            flowBlack.Size = new Size(57, 100);
            flowBlack.TabIndex = 7;
            // 
            // rbBlackA
            // 
            rbBlackA.AutoSize = true;
            rbBlackA.Checked = true;
            rbBlackA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbBlackA.Location = new Point(3, 3);
            rbBlackA.Name = "rbBlackA";
            rbBlackA.Size = new Size(39, 25);
            rbBlackA.TabIndex = 4;
            rbBlackA.TabStop = true;
            rbBlackA.Text = "A";
            rbBlackA.UseVisualStyleBackColor = true;
            // 
            // rbBlackB
            // 
            rbBlackB.AutoSize = true;
            rbBlackB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbBlackB.Location = new Point(3, 34);
            rbBlackB.Name = "rbBlackB";
            rbBlackB.Size = new Size(38, 25);
            rbBlackB.TabIndex = 3;
            rbBlackB.Text = "B";
            rbBlackB.UseVisualStyleBackColor = true;
            // 
            // rbBlackC
            // 
            rbBlackC.AutoSize = true;
            rbBlackC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbBlackC.Location = new Point(3, 65);
            rbBlackC.Name = "rbBlackC";
            rbBlackC.Size = new Size(38, 25);
            rbBlackC.TabIndex = 5;
            rbBlackC.Text = "C";
            rbBlackC.UseVisualStyleBackColor = true;
            // 
            // flowBlue
            // 
            flowBlue.Controls.Add(rbBlueA);
            flowBlue.Controls.Add(rbBlueB);
            flowBlue.Controls.Add(rbBlueC);
            flowBlue.Dock = DockStyle.Fill;
            flowBlue.Location = new Point(68, 50);
            flowBlue.Name = "flowBlue";
            flowBlue.Size = new Size(57, 100);
            flowBlue.TabIndex = 6;
            // 
            // rbBlueA
            // 
            rbBlueA.AutoSize = true;
            rbBlueA.Checked = true;
            rbBlueA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbBlueA.Location = new Point(3, 3);
            rbBlueA.Name = "rbBlueA";
            rbBlueA.Size = new Size(39, 25);
            rbBlueA.TabIndex = 4;
            rbBlueA.TabStop = true;
            rbBlueA.Text = "A";
            rbBlueA.UseVisualStyleBackColor = true;
            // 
            // rbBlueB
            // 
            rbBlueB.AutoSize = true;
            rbBlueB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbBlueB.Location = new Point(3, 34);
            rbBlueB.Name = "rbBlueB";
            rbBlueB.Size = new Size(38, 25);
            rbBlueB.TabIndex = 3;
            rbBlueB.Text = "B";
            rbBlueB.UseVisualStyleBackColor = true;
            // 
            // rbBlueC
            // 
            rbBlueC.AutoSize = true;
            rbBlueC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbBlueC.Location = new Point(3, 65);
            rbBlueC.Name = "rbBlueC";
            rbBlueC.Size = new Size(38, 25);
            rbBlueC.TabIndex = 5;
            rbBlueC.Text = "C";
            rbBlueC.UseVisualStyleBackColor = true;
            // 
            // lblBlack
            // 
            lblBlack.BackColor = Color.Black;
            lblBlack.Dock = DockStyle.Fill;
            lblBlack.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblBlack.ForeColor = SystemColors.ControlLightLight;
            lblBlack.Location = new Point(132, 1);
            lblBlack.Name = "lblBlack";
            lblBlack.Size = new Size(57, 45);
            lblBlack.TabIndex = 2;
            lblBlack.Text = "0";
            lblBlack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBlue
            // 
            lblBlue.BackColor = Color.DodgerBlue;
            lblBlue.Dock = DockStyle.Fill;
            lblBlue.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblBlue.Location = new Point(68, 1);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(57, 45);
            lblBlue.TabIndex = 1;
            lblBlue.Text = "0";
            lblBlue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flowRed
            // 
            flowRed.Controls.Add(rbRedA);
            flowRed.Controls.Add(rbRedB);
            flowRed.Controls.Add(rbRedC);
            flowRed.Dock = DockStyle.Fill;
            flowRed.Location = new Point(4, 50);
            flowRed.Name = "flowRed";
            flowRed.Size = new Size(57, 100);
            flowRed.TabIndex = 5;
            // 
            // rbRedA
            // 
            rbRedA.AutoSize = true;
            rbRedA.Checked = true;
            rbRedA.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbRedA.Location = new Point(3, 3);
            rbRedA.Name = "rbRedA";
            rbRedA.Size = new Size(39, 25);
            rbRedA.TabIndex = 4;
            rbRedA.TabStop = true;
            rbRedA.Text = "A";
            rbRedA.UseVisualStyleBackColor = true;
            // 
            // rbRedB
            // 
            rbRedB.AutoSize = true;
            rbRedB.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbRedB.Location = new Point(3, 34);
            rbRedB.Name = "rbRedB";
            rbRedB.Size = new Size(38, 25);
            rbRedB.TabIndex = 3;
            rbRedB.Text = "B";
            rbRedB.UseVisualStyleBackColor = true;
            // 
            // rbRedC
            // 
            rbRedC.AutoSize = true;
            rbRedC.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            rbRedC.Location = new Point(3, 65);
            rbRedC.Name = "rbRedC";
            rbRedC.Size = new Size(38, 25);
            rbRedC.TabIndex = 5;
            rbRedC.Text = "C";
            rbRedC.UseVisualStyleBackColor = true;
            // 
            // btnRed
            // 
            btnRed.Dock = DockStyle.Fill;
            btnRed.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnRed.Location = new Point(4, 157);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(57, 56);
            btnRed.TabIndex = 8;
            btnRed.Text = "Set";
            btnRed.UseVisualStyleBackColor = true;
            btnRed.Click += btnRed_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(12, 363);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(193, 35);
            btnReset.TabIndex = 2;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(7, 17);
            label4.Name = "label4";
            label4.Size = new Size(182, 23);
            label4.TabIndex = 3;
            label4.Text = "Durchtrennen? :";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grbOut
            // 
            grbOut.Controls.Add(pbX);
            grbOut.Controls.Add(pbTick);
            grbOut.Controls.Add(label4);
            grbOut.Location = new Point(9, 230);
            grbOut.Name = "grbOut";
            grbOut.Size = new Size(193, 127);
            grbOut.TabIndex = 4;
            grbOut.TabStop = false;
            // 
            // pbX
            // 
            pbX.BackgroundImage = Properties.Resources.x;
            pbX.BackgroundImageLayout = ImageLayout.Zoom;
            pbX.Location = new Point(100, 50);
            pbX.Name = "pbX";
            pbX.Size = new Size(74, 65);
            pbX.TabIndex = 6;
            pbX.TabStop = false;
            pbX.Visible = false;
            // 
            // pbTick
            // 
            pbTick.BackgroundImage = Properties.Resources.tick;
            pbTick.BackgroundImageLayout = ImageLayout.Zoom;
            pbTick.Location = new Point(17, 50);
            pbTick.Name = "pbTick";
            pbTick.Size = new Size(74, 65);
            pbTick.TabIndex = 5;
            pbTick.TabStop = false;
            pbTick.Visible = false;
            // 
            // WireSequenceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(211, 406);
            Controls.Add(grbOut);
            Controls.Add(btnReset);
            Controls.Add(tableLayoutPanel1);
            Name = "WireSequenceForm";
            Text = "Wire Sequence Solver";
            tableLayoutPanel1.ResumeLayout(false);
            flowBlack.ResumeLayout(false);
            flowBlack.PerformLayout();
            flowBlue.ResumeLayout(false);
            flowBlue.PerformLayout();
            flowRed.ResumeLayout(false);
            flowRed.PerformLayout();
            grbOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbX).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbTick).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblRed;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblBlue;
        private Button btnBlack;
        private Button btnBlue;
        private FlowLayoutPanel flowBlack;
        private RadioButton rbBlackA;
        private RadioButton rbBlackB;
        private RadioButton rbBlackC;
        private FlowLayoutPanel flowBlue;
        private RadioButton rbBlueA;
        private RadioButton rbBlueB;
        private RadioButton rbBlueC;
        private Label lblBlack;
        private FlowLayoutPanel flowRed;
        private RadioButton rbRedA;
        private RadioButton rbRedB;
        private RadioButton rbRedC;
        private Button btnRed;
        private Button btnReset;
        private Label label4;
        private GroupBox grbOut;
        private PictureBox pbX;
        private PictureBox pbTick;
    }
}