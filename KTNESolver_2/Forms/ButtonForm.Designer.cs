namespace KTNESolver_2.Forms
{
    partial class ButtonForm
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
            lblAction = new Label();
            label3 = new Label();
            lblLetgo = new Label();
            grbStage1 = new GroupBox();
            btnReset = new Button();
            flowText = new FlowLayoutPanel();
            rbAbbrechen = new RadioButton();
            rbSprengen = new RadioButton();
            rbHalten = new RadioButton();
            rbNone = new RadioButton();
            flowColor = new FlowLayoutPanel();
            rbBlue = new RadioButton();
            rbWhite = new RadioButton();
            rbYellow = new RadioButton();
            rbRed = new RadioButton();
            rbOther = new RadioButton();
            grbHoldOnly = new GroupBox();
            label4 = new Label();
            flowHold = new FlowLayoutPanel();
            rbHoldBlue = new RadioButton();
            rbHoldWhite = new RadioButton();
            rbHoldYellow = new RadioButton();
            rbHoldNone = new RadioButton();
            grbStage1.SuspendLayout();
            flowText.SuspendLayout();
            flowColor.SuspendLayout();
            grbHoldOnly.SuspendLayout();
            flowHold.SuspendLayout();
            SuspendLayout();
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAction.Location = new Point(79, 168);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(70, 21);
            lblAction.TabIndex = 5;
            lblAction.Text = "Waiting";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 172);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Action:";
            // 
            // lblLetgo
            // 
            lblLetgo.AutoSize = true;
            lblLetgo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetgo.Location = new Point(79, 112);
            lblLetgo.Name = "lblLetgo";
            lblLetgo.Size = new Size(103, 21);
            lblLetgo.TabIndex = 8;
            lblLetgo.Text = "Let go on #1";
            // 
            // grbStage1
            // 
            grbStage1.Controls.Add(btnReset);
            grbStage1.Controls.Add(lblAction);
            grbStage1.Controls.Add(flowText);
            grbStage1.Controls.Add(label3);
            grbStage1.Controls.Add(flowColor);
            grbStage1.Location = new Point(12, 6);
            grbStage1.Name = "grbStage1";
            grbStage1.Size = new Size(390, 219);
            grbStage1.TabIndex = 6;
            grbStage1.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(232, 150);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(151, 63);
            btnReset.TabIndex = 6;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // flowText
            // 
            flowText.BorderStyle = BorderStyle.FixedSingle;
            flowText.Controls.Add(rbAbbrechen);
            flowText.Controls.Add(rbSprengen);
            flowText.Controls.Add(rbHalten);
            flowText.Controls.Add(rbNone);
            flowText.Location = new Point(6, 88);
            flowText.Name = "flowText";
            flowText.Size = new Size(377, 56);
            flowText.TabIndex = 1;
            // 
            // rbAbbrechen
            // 
            rbAbbrechen.Location = new Point(3, 3);
            rbAbbrechen.Name = "rbAbbrechen";
            rbAbbrechen.Size = new Size(87, 48);
            rbAbbrechen.TabIndex = 0;
            rbAbbrechen.Text = "Abbrechen";
            rbAbbrechen.UseVisualStyleBackColor = true;
            rbAbbrechen.CheckedChanged += solve;
            // 
            // rbSprengen
            // 
            rbSprengen.Location = new Point(96, 3);
            rbSprengen.Name = "rbSprengen";
            rbSprengen.Size = new Size(87, 48);
            rbSprengen.TabIndex = 1;
            rbSprengen.Text = "Sprengen";
            rbSprengen.UseVisualStyleBackColor = true;
            rbSprengen.CheckedChanged += solve;
            // 
            // rbHalten
            // 
            rbHalten.Location = new Point(189, 3);
            rbHalten.Name = "rbHalten";
            rbHalten.Size = new Size(87, 48);
            rbHalten.TabIndex = 2;
            rbHalten.Text = "Gedrückt Halten";
            rbHalten.UseVisualStyleBackColor = true;
            rbHalten.CheckedChanged += solve;
            // 
            // rbNone
            // 
            rbNone.Checked = true;
            rbNone.Location = new Point(282, 3);
            rbNone.Name = "rbNone";
            rbNone.Size = new Size(87, 48);
            rbNone.TabIndex = 3;
            rbNone.TabStop = true;
            rbNone.Text = "None";
            rbNone.UseVisualStyleBackColor = true;
            rbNone.CheckedChanged += solve;
            // 
            // flowColor
            // 
            flowColor.BorderStyle = BorderStyle.FixedSingle;
            flowColor.Controls.Add(rbBlue);
            flowColor.Controls.Add(rbWhite);
            flowColor.Controls.Add(rbYellow);
            flowColor.Controls.Add(rbRed);
            flowColor.Controls.Add(rbOther);
            flowColor.Location = new Point(6, 16);
            flowColor.Name = "flowColor";
            flowColor.Size = new Size(377, 70);
            flowColor.TabIndex = 0;
            // 
            // rbBlue
            // 
            rbBlue.BackColor = Color.DodgerBlue;
            rbBlue.CheckAlign = ContentAlignment.MiddleCenter;
            rbBlue.Location = new Point(3, 3);
            rbBlue.Name = "rbBlue";
            rbBlue.Size = new Size(68, 62);
            rbBlue.TabIndex = 0;
            rbBlue.UseVisualStyleBackColor = false;
            rbBlue.CheckedChanged += solve;
            // 
            // rbWhite
            // 
            rbWhite.BackColor = Color.White;
            rbWhite.CheckAlign = ContentAlignment.MiddleCenter;
            rbWhite.Location = new Point(77, 3);
            rbWhite.Name = "rbWhite";
            rbWhite.Size = new Size(68, 62);
            rbWhite.TabIndex = 1;
            rbWhite.UseVisualStyleBackColor = false;
            rbWhite.CheckedChanged += solve;
            // 
            // rbYellow
            // 
            rbYellow.BackColor = Color.Yellow;
            rbYellow.CheckAlign = ContentAlignment.MiddleCenter;
            rbYellow.Location = new Point(151, 3);
            rbYellow.Name = "rbYellow";
            rbYellow.Size = new Size(68, 62);
            rbYellow.TabIndex = 2;
            rbYellow.UseVisualStyleBackColor = false;
            rbYellow.CheckedChanged += solve;
            // 
            // rbRed
            // 
            rbRed.BackColor = Color.Red;
            rbRed.CheckAlign = ContentAlignment.MiddleCenter;
            rbRed.Location = new Point(225, 3);
            rbRed.Name = "rbRed";
            rbRed.Size = new Size(68, 62);
            rbRed.TabIndex = 3;
            rbRed.UseVisualStyleBackColor = false;
            rbRed.CheckedChanged += solve;
            // 
            // rbOther
            // 
            rbOther.BackColor = Color.Transparent;
            rbOther.BackgroundImage = Properties.Resources.none_icon;
            rbOther.BackgroundImageLayout = ImageLayout.Zoom;
            rbOther.CheckAlign = ContentAlignment.MiddleCenter;
            rbOther.Checked = true;
            rbOther.Location = new Point(299, 3);
            rbOther.Name = "rbOther";
            rbOther.Size = new Size(68, 62);
            rbOther.TabIndex = 4;
            rbOther.TabStop = true;
            rbOther.UseVisualStyleBackColor = false;
            rbOther.CheckedChanged += solve;
            // 
            // grbHoldOnly
            // 
            grbHoldOnly.Controls.Add(label4);
            grbHoldOnly.Controls.Add(lblLetgo);
            grbHoldOnly.Controls.Add(flowHold);
            grbHoldOnly.Location = new Point(12, 231);
            grbHoldOnly.Name = "grbHoldOnly";
            grbHoldOnly.Size = new Size(390, 158);
            grbHoldOnly.TabIndex = 7;
            grbHoldOnly.TabStop = false;
            grbHoldOnly.Text = "Hold Only";
            grbHoldOnly.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 115);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 6;
            label4.Text = "Action:";
            // 
            // flowHold
            // 
            flowHold.BorderStyle = BorderStyle.FixedSingle;
            flowHold.Controls.Add(rbHoldBlue);
            flowHold.Controls.Add(rbHoldWhite);
            flowHold.Controls.Add(rbHoldYellow);
            flowHold.Controls.Add(rbHoldNone);
            flowHold.Location = new Point(6, 22);
            flowHold.Name = "flowHold";
            flowHold.Size = new Size(377, 70);
            flowHold.TabIndex = 1;
            // 
            // rbHoldBlue
            // 
            rbHoldBlue.BackColor = Color.DodgerBlue;
            rbHoldBlue.CheckAlign = ContentAlignment.MiddleCenter;
            rbHoldBlue.Location = new Point(3, 3);
            rbHoldBlue.Name = "rbHoldBlue";
            rbHoldBlue.Size = new Size(87, 62);
            rbHoldBlue.TabIndex = 0;
            rbHoldBlue.UseVisualStyleBackColor = false;
            rbHoldBlue.CheckedChanged += holdColor;
            // 
            // rbHoldWhite
            // 
            rbHoldWhite.BackColor = Color.White;
            rbHoldWhite.CheckAlign = ContentAlignment.MiddleCenter;
            rbHoldWhite.Location = new Point(96, 3);
            rbHoldWhite.Name = "rbHoldWhite";
            rbHoldWhite.Size = new Size(87, 62);
            rbHoldWhite.TabIndex = 1;
            rbHoldWhite.UseVisualStyleBackColor = false;
            rbHoldWhite.CheckedChanged += holdColor;
            // 
            // rbHoldYellow
            // 
            rbHoldYellow.BackColor = Color.Yellow;
            rbHoldYellow.CheckAlign = ContentAlignment.MiddleCenter;
            rbHoldYellow.Location = new Point(189, 3);
            rbHoldYellow.Name = "rbHoldYellow";
            rbHoldYellow.Size = new Size(87, 62);
            rbHoldYellow.TabIndex = 2;
            rbHoldYellow.UseVisualStyleBackColor = false;
            rbHoldYellow.CheckedChanged += holdColor;
            // 
            // rbHoldNone
            // 
            rbHoldNone.BackColor = Color.Transparent;
            rbHoldNone.BackgroundImage = Properties.Resources.none_icon;
            rbHoldNone.BackgroundImageLayout = ImageLayout.Zoom;
            rbHoldNone.CheckAlign = ContentAlignment.MiddleCenter;
            rbHoldNone.Checked = true;
            rbHoldNone.Location = new Point(282, 3);
            rbHoldNone.Name = "rbHoldNone";
            rbHoldNone.Size = new Size(87, 62);
            rbHoldNone.TabIndex = 4;
            rbHoldNone.TabStop = true;
            rbHoldNone.UseVisualStyleBackColor = false;
            rbHoldNone.CheckedChanged += holdColor;
            // 
            // ButtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 397);
            Controls.Add(grbHoldOnly);
            Controls.Add(grbStage1);
            Name = "ButtonForm";
            Text = "Button Solver";
            grbStage1.ResumeLayout(false);
            grbStage1.PerformLayout();
            flowText.ResumeLayout(false);
            flowColor.ResumeLayout(false);
            grbHoldOnly.ResumeLayout(false);
            grbHoldOnly.PerformLayout();
            flowHold.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label lblAction;
        private Label label3;
        private Label lblLetgo;
        private GroupBox grbStage1;
        private FlowLayoutPanel flowColor;
        private FlowLayoutPanel flowText;
        private RadioButton rbAbbrechen;
        private RadioButton rbBlue;
        private RadioButton rbWhite;
        private RadioButton rbYellow;
        private RadioButton rbRed;
        private RadioButton rbSprengen;
        private RadioButton rbHalten;
        private RadioButton rbNone;
        private RadioButton rbOther;
        private GroupBox grbHoldOnly;
        private FlowLayoutPanel flowHold;
        private RadioButton rbHoldBlue;
        private RadioButton rbHoldWhite;
        private RadioButton rbHoldYellow;
        private RadioButton rbHoldNone;
        private Label label4;
        private Button btnReset;
    }
}