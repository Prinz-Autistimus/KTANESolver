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
            comboColor = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            grb1 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            grbHold = new GroupBox();
            label6 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            grb1.SuspendLayout();
            grbHold.SuspendLayout();
            SuspendLayout();
            // 
            // comboColor
            // 
            comboColor.FormattingEnabled = true;
            comboColor.Items.AddRange(new object[] { "None", "Blue", "White", "Yellow", "Red" });
            comboColor.Location = new Point(55, 23);
            comboColor.Name = "comboColor";
            comboColor.Size = new Size(121, 23);
            comboColor.TabIndex = 0;
            comboColor.Text = "None";
            comboColor.SelectedIndexChanged += solve;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Color:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 59);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 2;
            label2.Text = "Text:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "None", "Abbrechen", "Sprengen", "Gedrückt Halten" });
            comboBox1.Location = new Point(55, 56);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "None";
            comboBox1.SelectedIndexChanged += solve;
            // 
            // grb1
            // 
            grb1.Controls.Add(label4);
            grb1.Controls.Add(label3);
            grb1.Controls.Add(comboBox1);
            grb1.Controls.Add(comboColor);
            grb1.Controls.Add(label2);
            grb1.Controls.Add(label1);
            grb1.Location = new Point(12, 7);
            grb1.Name = "grb1";
            grb1.Size = new Size(191, 137);
            grb1.TabIndex = 4;
            grb1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 99);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 5;
            label4.Text = "ERROR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 99);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Action:";
            // 
            // grbHold
            // 
            grbHold.Controls.Add(label6);
            grbHold.Controls.Add(comboBox2);
            grbHold.Controls.Add(label5);
            grbHold.Location = new Point(12, 171);
            grbHold.Name = "grbHold";
            grbHold.Size = new Size(191, 110);
            grbHold.TabIndex = 5;
            grbHold.TabStop = false;
            grbHold.Text = "Hold only";
            grbHold.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 72);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 8;
            label6.Text = "Let go on #:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Blue", "White", "Yellow", "Other" });
            comboBox2.Location = new Point(55, 27);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Other";
            comboBox2.SelectedIndexChanged += solve;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 30);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 7;
            label5.Text = "Color:";
            // 
            // ButtonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(224, 303);
            Controls.Add(grbHold);
            Controls.Add(grb1);
            Name = "ButtonForm";
            Text = "Button Solver";
            grb1.ResumeLayout(false);
            grb1.PerformLayout();
            grbHold.ResumeLayout(false);
            grbHold.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboColor;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private GroupBox grb1;
        private Label label4;
        private Label label3;
        private GroupBox grbHold;
        private Label label6;
        private ComboBox comboBox2;
        private Label label5;
    }
}