namespace KTNESolver_2.Forms
{
    partial class PasswordForm
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
            label1 = new Label();
            grbSolution = new GroupBox();
            lblSolution = new Label();
            btnFind = new Button();
            grb1 = new GroupBox();
            tb1 = new TextBox();
            groupBox1 = new GroupBox();
            tb2 = new TextBox();
            groupBox2 = new GroupBox();
            tb3 = new TextBox();
            groupBox3 = new GroupBox();
            tb4 = new TextBox();
            groupBox4 = new GroupBox();
            tb5 = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnReset = new Button();
            grbSolution.SuspendLayout();
            grb1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 6;
            label1.Text = "Lösung:";
            // 
            // grbSolution
            // 
            grbSolution.Controls.Add(lblSolution);
            grbSolution.Controls.Add(label1);
            grbSolution.Location = new Point(6, 378);
            grbSolution.Name = "grbSolution";
            grbSolution.Size = new Size(281, 100);
            grbSolution.TabIndex = 7;
            grbSolution.TabStop = false;
            grbSolution.Text = "Lösung";
            // 
            // lblSolution
            // 
            lblSolution.BorderStyle = BorderStyle.FixedSingle;
            lblSolution.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolution.Location = new Point(123, 43);
            lblSolution.Name = "lblSolution";
            lblSolution.Size = new Size(93, 24);
            lblSolution.TabIndex = 7;
            lblSolution.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(3, 3);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(130, 62);
            btnFind.TabIndex = 8;
            btnFind.Text = "Suchen";
            btnFind.UseVisualStyleBackColor = true;
            btnFind.Click += btnFind_Click;
            // 
            // grb1
            // 
            grb1.Controls.Add(tb1);
            grb1.Location = new Point(12, 12);
            grb1.Name = "grb1";
            grb1.Size = new Size(275, 52);
            grb1.TabIndex = 8;
            grb1.TabStop = false;
            grb1.Text = "Slot 1";
            // 
            // tb1
            // 
            tb1.Location = new Point(6, 22);
            tb1.Name = "tb1";
            tb1.Size = new Size(263, 23);
            tb1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb2);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(275, 52);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Slot 2";
            // 
            // tb2
            // 
            tb2.Location = new Point(6, 22);
            tb2.Name = "tb2";
            tb2.Size = new Size(263, 23);
            tb2.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tb3);
            groupBox2.Location = new Point(12, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(275, 52);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Slot 3";
            // 
            // tb3
            // 
            tb3.Location = new Point(6, 22);
            tb3.Name = "tb3";
            tb3.Size = new Size(263, 23);
            tb3.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tb4);
            groupBox3.Location = new Point(12, 186);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(275, 52);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "Slot 4";
            // 
            // tb4
            // 
            tb4.Location = new Point(6, 22);
            tb4.Name = "tb4";
            tb4.Size = new Size(263, 23);
            tb4.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(tb5);
            groupBox4.Location = new Point(12, 244);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(275, 52);
            groupBox4.TabIndex = 11;
            groupBox4.TabStop = false;
            groupBox4.Text = "Slot 5";
            // 
            // tb5
            // 
            tb5.Location = new Point(6, 22);
            tb5.Name = "tb5";
            tb5.Size = new Size(263, 23);
            tb5.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(btnFind);
            flowLayoutPanel1.Controls.Add(btnReset);
            flowLayoutPanel1.Location = new Point(12, 303);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(275, 69);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(139, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(130, 62);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // PasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 485);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(grb1);
            Controls.Add(grbSolution);
            Name = "PasswordForm";
            Text = "PasswordForm";
            grbSolution.ResumeLayout(false);
            grbSolution.PerformLayout();
            grb1.ResumeLayout(false);
            grb1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private GroupBox grbSolution;
        private Label lblSolution;
        private Button btnFind;
        private GroupBox grb1;
        private TextBox tb1;
        private GroupBox groupBox1;
        private TextBox tb2;
        private GroupBox groupBox2;
        private TextBox tb3;
        private GroupBox groupBox3;
        private TextBox tb4;
        private GroupBox groupBox4;
        private TextBox tb5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnReset;
    }
}