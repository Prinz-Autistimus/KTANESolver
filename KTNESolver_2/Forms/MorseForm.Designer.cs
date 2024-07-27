namespace KTNESolver_2.Forms
{
    partial class MorseForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "bistro", "3.545 MHz" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "bombe", "3.595 MHz" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "bravo", "3.582 MHz" }, -1);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "halle", "3.505 MHz" }, -1);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "hallo", "3.515 MHz" }, -1);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "kobra", "3.592 MHz" }, -1);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "lokal", "3.522 MHz" }, -1);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "robust", "3.552 MHz" }, -1);
            ListViewItem listViewItem9 = new ListViewItem(new string[] { "säbel", "3.555 MHz" }, -1);
            ListViewItem listViewItem10 = new ListViewItem(new string[] { "sektor", "3.572 MHz" }, -1);
            ListViewItem listViewItem11 = new ListViewItem(new string[] { "speck", "3.542 MHz" }, -1);
            ListViewItem listViewItem12 = new ListViewItem(new string[] { "steak", "3.532 MHz" }, -1);
            ListViewItem listViewItem13 = new ListViewItem(new string[] { "stück", "3.535 MHz" }, -1);
            ListViewItem listViewItem14 = new ListViewItem(new string[] { "süden", "3.600 MHz" }, -1);
            ListViewItem listViewItem15 = new ListViewItem(new string[] { "sülze", "3.565 MHz" }, -1);
            ListViewItem listViewItem16 = new ListViewItem(new string[] { "vektor", "3.575 MHz" }, -1);
            tbInput = new TextBox();
            grbIn = new GroupBox();
            btnDel = new Button();
            btnReset = new Button();
            btnSpace = new Button();
            btnDash = new Button();
            btnDot = new Button();
            grbOutput = new GroupBox();
            lblOut = new Label();
            label1 = new Label();
            lvTable = new ListView();
            colWord = new ColumnHeader();
            colFreq = new ColumnHeader();
            grbIn.SuspendLayout();
            grbOutput.SuspendLayout();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbInput.Location = new Point(6, 22);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(342, 33);
            tbInput.TabIndex = 0;
            tbInput.TextChanged += tbInput_TextChanged;
            // 
            // grbIn
            // 
            grbIn.Controls.Add(btnDel);
            grbIn.Controls.Add(btnReset);
            grbIn.Controls.Add(btnSpace);
            grbIn.Controls.Add(btnDash);
            grbIn.Controls.Add(btnDot);
            grbIn.Controls.Add(tbInput);
            grbIn.Location = new Point(12, 3);
            grbIn.Name = "grbIn";
            grbIn.Size = new Size(354, 116);
            grbIn.TabIndex = 1;
            grbIn.TabStop = false;
            grbIn.Text = "Eingabe";
            // 
            // btnDel
            // 
            btnDel.BackgroundImageLayout = ImageLayout.Zoom;
            btnDel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDel.Location = new Point(216, 61);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(63, 49);
            btnDel.TabIndex = 5;
            btnDel.Text = "DELETE";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnReset
            // 
            btnReset.BackgroundImageLayout = ImageLayout.Zoom;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(285, 61);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(63, 49);
            btnReset.TabIndex = 4;
            btnReset.Text = "RESET";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnSpace
            // 
            btnSpace.BackgroundImageLayout = ImageLayout.Zoom;
            btnSpace.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSpace.Location = new Point(138, 61);
            btnSpace.Name = "btnSpace";
            btnSpace.Size = new Size(63, 49);
            btnSpace.TabIndex = 3;
            btnSpace.Text = "\"Space\"";
            btnSpace.UseVisualStyleBackColor = true;
            btnSpace.Click += btnSpace_Click;
            // 
            // btnDash
            // 
            btnDash.BackgroundImage = Properties.Resources.Dash;
            btnDash.BackgroundImageLayout = ImageLayout.Zoom;
            btnDash.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btnDash.Location = new Point(72, 61);
            btnDash.Name = "btnDash";
            btnDash.Size = new Size(60, 49);
            btnDash.TabIndex = 2;
            btnDash.UseVisualStyleBackColor = true;
            btnDash.Click += btnDash_Click;
            // 
            // btnDot
            // 
            btnDot.BackgroundImage = Properties.Resources.dot;
            btnDot.BackgroundImageLayout = ImageLayout.Zoom;
            btnDot.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btnDot.Location = new Point(6, 61);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 49);
            btnDot.TabIndex = 1;
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += btnDot_Click;
            // 
            // grbOutput
            // 
            grbOutput.Controls.Add(lblOut);
            grbOutput.Controls.Add(label1);
            grbOutput.Controls.Add(lvTable);
            grbOutput.Location = new Point(12, 125);
            grbOutput.Name = "grbOutput";
            grbOutput.Size = new Size(354, 434);
            grbOutput.TabIndex = 2;
            grbOutput.TabStop = false;
            grbOutput.Text = "Ausgabe";
            // 
            // lblOut
            // 
            lblOut.BorderStyle = BorderStyle.FixedSingle;
            lblOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOut.Location = new Point(6, 63);
            lblOut.Name = "lblOut";
            lblOut.Size = new Size(121, 29);
            lblOut.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 1;
            label1.Text = "Übersetzung:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lvTable
            // 
            lvTable.Columns.AddRange(new ColumnHeader[] { colWord, colFreq });
            lvTable.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lvTable.FullRowSelect = true;
            lvTable.GridLines = true;
            lvTable.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listViewItem4.UseItemStyleForSubItems = false;
            lvTable.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12, listViewItem13, listViewItem14, listViewItem15, listViewItem16 });
            lvTable.Location = new Point(133, 14);
            lvTable.Name = "lvTable";
            lvTable.RightToLeft = RightToLeft.No;
            lvTable.Size = new Size(221, 414);
            lvTable.Sorting = SortOrder.Ascending;
            lvTable.TabIndex = 0;
            lvTable.UseCompatibleStateImageBehavior = false;
            lvTable.View = View.Details;
            // 
            // colWord
            // 
            colWord.Text = "Wort";
            // 
            // colFreq
            // 
            colFreq.Text = "Frequenz";
            colFreq.Width = 110;
            // 
            // MorseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 571);
            Controls.Add(grbOutput);
            Controls.Add(grbIn);
            Name = "MorseForm";
            Text = "Morse Solver";
            grbIn.ResumeLayout(false);
            grbIn.PerformLayout();
            grbOutput.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbInput;
        private GroupBox grbIn;
        private Button btnDash;
        private Button btnDot;
        private Button btnSpace;
        private GroupBox grbOutput;
        private ListView lvTable;
        private ColumnHeader colWord;
        private ColumnHeader colFreq;
        private Label lblOut;
        private Label label1;
        private Button btnReset;
        private Button btnDel;
    }
}