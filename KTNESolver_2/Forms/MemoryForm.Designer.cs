namespace KTNESolver_2.Forms
{
    partial class MemoryForm
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
            grbDisplay = new GroupBox();
            rb4 = new RadioButton();
            rb3 = new RadioButton();
            rb2 = new RadioButton();
            rbOne = new RadioButton();
            nudPos = new NumericUpDown();
            nudValue = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnConfirm = new Button();
            btnReset = new Button();
            lvState = new ListView();
            stage = new ColumnHeader();
            grbDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudPos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudValue).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grbDisplay
            // 
            grbDisplay.Controls.Add(rb4);
            grbDisplay.Controls.Add(rb3);
            grbDisplay.Controls.Add(rb2);
            grbDisplay.Controls.Add(rbOne);
            grbDisplay.Location = new Point(12, 12);
            grbDisplay.Name = "grbDisplay";
            grbDisplay.Size = new Size(179, 57);
            grbDisplay.TabIndex = 0;
            grbDisplay.TabStop = false;
            grbDisplay.Text = "Anzeige";
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb4.Location = new Point(132, 22);
            rb4.Name = "rb4";
            rb4.Size = new Size(36, 24);
            rb4.TabIndex = 3;
            rb4.TabStop = true;
            rb4.Text = "4";
            rb4.UseVisualStyleBackColor = true;
            rb4.CheckedChanged += rb4_CheckedChanged;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb3.Location = new Point(90, 22);
            rb3.Name = "rb3";
            rb3.Size = new Size(36, 24);
            rb3.TabIndex = 2;
            rb3.TabStop = true;
            rb3.Text = "3";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rb2.Location = new Point(48, 22);
            rb2.Name = "rb2";
            rb2.Size = new Size(36, 24);
            rb2.TabIndex = 1;
            rb2.TabStop = true;
            rb2.Text = "2";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // rbOne
            // 
            rbOne.AutoSize = true;
            rbOne.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbOne.Location = new Point(6, 22);
            rbOne.Name = "rbOne";
            rbOne.Size = new Size(36, 24);
            rbOne.TabIndex = 0;
            rbOne.TabStop = true;
            rbOne.Text = "1";
            rbOne.UseVisualStyleBackColor = true;
            rbOne.CheckedChanged += rbOne_CheckedChanged;
            // 
            // nudPos
            // 
            nudPos.Location = new Point(7, 33);
            nudPos.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudPos.Name = "nudPos";
            nudPos.Size = new Size(78, 23);
            nudPos.TabIndex = 1;
            // 
            // nudValue
            // 
            nudValue.Location = new Point(91, 33);
            nudValue.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            nudValue.Name = "nudValue";
            nudValue.Size = new Size(78, 23);
            nudValue.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 14);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "Position";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(103, 15);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Wert";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(nudPos);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(nudValue);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(179, 65);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            // 
            // btnConfirm
            // 
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(12, 145);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(179, 37);
            btnConfirm.TabIndex = 6;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(12, 187);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(179, 37);
            btnReset.TabIndex = 7;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // lvState
            // 
            lvState.Columns.AddRange(new ColumnHeader[] { stage });
            lvState.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvState.Location = new Point(197, 12);
            lvState.Name = "lvState";
            lvState.Size = new Size(98, 212);
            lvState.TabIndex = 8;
            lvState.UseCompatibleStateImageBehavior = false;
            lvState.View = View.List;
            // 
            // stage
            // 
            stage.Text = "Stage";
            // 
            // MemoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(309, 235);
            Controls.Add(lvState);
            Controls.Add(btnReset);
            Controls.Add(btnConfirm);
            Controls.Add(groupBox1);
            Controls.Add(grbDisplay);
            Name = "MemoryForm";
            Text = "Memory Solver";
            grbDisplay.ResumeLayout(false);
            grbDisplay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudPos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudValue).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbDisplay;
        private RadioButton rbOne;
        private RadioButton rb4;
        private RadioButton rb3;
        private RadioButton rb2;
        private NumericUpDown nudPos;
        private NumericUpDown nudValue;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnConfirm;
        private Button btnReset;
        private ListView lvState;
        private ColumnHeader stage;
    }
}