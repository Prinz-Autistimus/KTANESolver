namespace KTNESolver_2.Forms
{
    partial class SimonSaysForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnRed = new Button();
            btnBlue = new Button();
            btnGreen = new Button();
            btnYellow = new Button();
            lbOut = new ListBox();
            btnReset = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel1.Controls.Add(btnRed);
            flowLayoutPanel1.Controls.Add(btnBlue);
            flowLayoutPanel1.Controls.Add(btnGreen);
            flowLayoutPanel1.Controls.Add(btnYellow);
            flowLayoutPanel1.Location = new Point(12, 12);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(176, 176);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.Location = new Point(3, 3);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(80, 80);
            btnRed.TabIndex = 0;
            btnRed.UseVisualStyleBackColor = false;
            btnRed.Click += btnRed_Click;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.DodgerBlue;
            btnBlue.Location = new Point(89, 3);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(80, 80);
            btnBlue.TabIndex = 1;
            btnBlue.UseVisualStyleBackColor = false;
            btnBlue.Click += btnBlue_Click;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Lime;
            btnGreen.Location = new Point(3, 89);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(80, 80);
            btnGreen.TabIndex = 2;
            btnGreen.UseVisualStyleBackColor = false;
            btnGreen.Click += btnGreen_Click;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.Location = new Point(89, 89);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(80, 80);
            btnYellow.TabIndex = 3;
            btnYellow.UseVisualStyleBackColor = false;
            btnYellow.Click += btnYellow_Click;
            // 
            // lbOut
            // 
            lbOut.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbOut.FormattingEnabled = true;
            lbOut.ItemHeight = 17;
            lbOut.Items.AddRange(new object[] { "" });
            lbOut.Location = new Point(194, 12);
            lbOut.Name = "lbOut";
            lbOut.Size = new Size(175, 89);
            lbOut.TabIndex = 1;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(194, 112);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(175, 76);
            btnReset.TabIndex = 2;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // SimonSaysForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 199);
            Controls.Add(btnReset);
            Controls.Add(lbOut);
            Controls.Add(flowLayoutPanel1);
            Name = "SimonSaysForm";
            Text = "Simon Says Solver";
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnRed;
        private Button btnBlue;
        private Button btnGreen;
        private Button btnYellow;
        private ListBox lbOut;
        private Button btnReset;
    }
}