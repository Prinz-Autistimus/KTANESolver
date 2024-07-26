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
            comboText = new ComboBox();
            grb1 = new GroupBox();
            lblAction = new Label();
            label3 = new Label();
            grbHold = new GroupBox();
            lblLetgo = new Label();
            comboHold = new ComboBox();
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
            // comboText
            // 
            comboText.FormattingEnabled = true;
            comboText.Items.AddRange(new object[] { "None", "Abbrechen", "Sprengen", "Gedrückt Halten" });
            comboText.Location = new Point(55, 56);
            comboText.Name = "comboText";
            comboText.Size = new Size(121, 23);
            comboText.TabIndex = 3;
            comboText.Text = "None";
            comboText.SelectedIndexChanged += solve;
            // 
            // grb1
            // 
            grb1.Controls.Add(lblAction);
            grb1.Controls.Add(label3);
            grb1.Controls.Add(comboText);
            grb1.Controls.Add(comboColor);
            grb1.Controls.Add(label2);
            grb1.Controls.Add(label1);
            grb1.Location = new Point(12, 7);
            grb1.Name = "grb1";
            grb1.Size = new Size(191, 137);
            grb1.TabIndex = 4;
            grb1.TabStop = false;
            // 
            // lblAction
            // 
            lblAction.AutoSize = true;
            lblAction.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAction.Location = new Point(74, 99);
            lblAction.Name = "lblAction";
            lblAction.Size = new Size(70, 21);
            lblAction.TabIndex = 5;
            lblAction.Text = "Waiting";
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
            grbHold.Controls.Add(lblLetgo);
            grbHold.Controls.Add(comboHold);
            grbHold.Controls.Add(label5);
            grbHold.Location = new Point(12, 171);
            grbHold.Name = "grbHold";
            grbHold.Size = new Size(191, 110);
            grbHold.TabIndex = 5;
            grbHold.TabStop = false;
            grbHold.Text = "Hold only";
            grbHold.Visible = false;
            // 
            // lblLetgo
            // 
            lblLetgo.AutoSize = true;
            lblLetgo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLetgo.Location = new Point(18, 72);
            lblLetgo.Name = "lblLetgo";
            lblLetgo.Size = new Size(107, 21);
            lblLetgo.TabIndex = 8;
            lblLetgo.Text = "Let go on #1:";
            // 
            // comboHold
            // 
            comboHold.FormattingEnabled = true;
            comboHold.Items.AddRange(new object[] { "Blue", "White", "Yellow", "Other" });
            comboHold.Location = new Point(55, 27);
            comboHold.Name = "comboHold";
            comboHold.Size = new Size(121, 23);
            comboHold.TabIndex = 6;
            comboHold.Text = "Other";
            comboHold.SelectedIndexChanged += holdColor;
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
        private ComboBox comboText;
        private GroupBox grb1;
        private Label lblAction;
        private Label label3;
        private GroupBox grbHold;
        private Label lblLetgo;
        private ComboBox comboHold;
        private Label label5;
    }
}