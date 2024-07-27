namespace KTNESolver_2
{
    partial class KTNESolver
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblBatteries = new Label();
            nudBatteries = new NumericUpDown();
            cbSerialVowel = new CheckBox();
            cbParallel = new CheckBox();
            rbSerialEven = new RadioButton();
            rbSerialOdd = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblSerial = new Label();
            cbFRK = new CheckBox();
            cbCAR = new CheckBox();
            grbSerial = new GroupBox();
            lblStrike = new Label();
            grbStrike = new GroupBox();
            rbStrike2 = new RadioButton();
            rbStrike1 = new RadioButton();
            rbStrike0 = new RadioButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            btnWhosOnFirst = new Button();
            btnSimonSays = new Button();
            btnKeypad = new Button();
            btnButton = new Button();
            btnWire = new Button();
            grbBombInfo = new GroupBox();
            btnReset = new Button();
            btnWireTooltip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)nudBatteries).BeginInit();
            grbSerial.SuspendLayout();
            grbStrike.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            grbBombInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblBatteries
            // 
            lblBatteries.AutoSize = true;
            lblBatteries.Location = new Point(7, 28);
            lblBatteries.Name = "lblBatteries";
            lblBatteries.Size = new Size(57, 15);
            lblBatteries.TabIndex = 7;
            lblBatteries.Text = "Batterien:";
            // 
            // nudBatteries
            // 
            nudBatteries.Location = new Point(72, 26);
            nudBatteries.Name = "nudBatteries";
            nudBatteries.Size = new Size(61, 23);
            nudBatteries.TabIndex = 0;
            // 
            // cbSerialVowel
            // 
            cbSerialVowel.AutoSize = true;
            cbSerialVowel.Location = new Point(143, 55);
            cbSerialVowel.Name = "cbSerialVowel";
            cbSerialVowel.Size = new Size(140, 19);
            cbSerialVowel.TabIndex = 3;
            cbSerialVowel.Text = "Seriennummer vokal?";
            cbSerialVowel.UseVisualStyleBackColor = true;
            // 
            // cbParallel
            // 
            cbParallel.AutoSize = true;
            cbParallel.Location = new Point(10, 55);
            cbParallel.Name = "cbParallel";
            cbParallel.Size = new Size(118, 19);
            cbParallel.TabIndex = 2;
            cbParallel.Text = "Hat Parallel-Port?";
            cbParallel.UseVisualStyleBackColor = true;
            // 
            // rbSerialEven
            // 
            rbSerialEven.AutoSize = true;
            rbSerialEven.Checked = true;
            rbSerialEven.Location = new Point(5, 13);
            rbSerialEven.Name = "rbSerialEven";
            rbSerialEven.Size = new Size(61, 19);
            rbSerialEven.TabIndex = 0;
            rbSerialEven.TabStop = true;
            rbSerialEven.Text = "gerade";
            rbSerialEven.UseVisualStyleBackColor = true;
            // 
            // rbSerialOdd
            // 
            rbSerialOdd.AutoSize = true;
            rbSerialOdd.Location = new Point(70, 13);
            rbSerialOdd.Name = "rbSerialOdd";
            rbSerialOdd.Size = new Size(75, 19);
            rbSerialOdd.TabIndex = 1;
            rbSerialOdd.TabStop = true;
            rbSerialOdd.Text = "ungerade";
            rbSerialOdd.UseVisualStyleBackColor = true;
            // 
            // lblSerial
            // 
            lblSerial.AutoSize = true;
            lblSerial.Location = new Point(143, 28);
            lblSerial.Name = "lblSerial";
            lblSerial.Size = new Size(88, 15);
            lblSerial.TabIndex = 1;
            lblSerial.Text = "Seriennummer:";
            // 
            // cbFRK
            // 
            cbFRK.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbFRK.AutoSize = true;
            cbFRK.Location = new Point(406, 28);
            cbFRK.Name = "cbFRK";
            cbFRK.Size = new Size(92, 19);
            cbFRK.TabIndex = 4;
            cbFRK.Text = "FRK leuchtet";
            cbFRK.UseVisualStyleBackColor = true;
            // 
            // cbCAR
            // 
            cbCAR.AutoSize = true;
            cbCAR.Location = new Point(406, 55);
            cbCAR.Name = "cbCAR";
            cbCAR.Size = new Size(95, 19);
            cbCAR.TabIndex = 5;
            cbCAR.Text = "CAR leuchtet";
            cbCAR.UseVisualStyleBackColor = true;
            // 
            // grbSerial
            // 
            grbSerial.BackgroundImageLayout = ImageLayout.None;
            grbSerial.Controls.Add(rbSerialEven);
            grbSerial.Controls.Add(rbSerialOdd);
            grbSerial.Location = new Point(235, 13);
            grbSerial.Name = "grbSerial";
            grbSerial.Size = new Size(153, 39);
            grbSerial.TabIndex = 1;
            grbSerial.TabStop = false;
            // 
            // lblStrike
            // 
            lblStrike.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblStrike.AutoSize = true;
            lblStrike.Location = new Point(535, 28);
            lblStrike.Name = "lblStrike";
            lblStrike.Size = new Size(44, 15);
            lblStrike.TabIndex = 8;
            lblStrike.Text = "Strikes:";
            // 
            // grbStrike
            // 
            grbStrike.Controls.Add(rbStrike2);
            grbStrike.Controls.Add(rbStrike1);
            grbStrike.Controls.Add(rbStrike0);
            grbStrike.Location = new Point(607, 11);
            grbStrike.Name = "grbStrike";
            grbStrike.Size = new Size(117, 41);
            grbStrike.TabIndex = 6;
            grbStrike.TabStop = false;
            // 
            // rbStrike2
            // 
            rbStrike2.AutoSize = true;
            rbStrike2.Location = new Point(83, 15);
            rbStrike2.Name = "rbStrike2";
            rbStrike2.Size = new Size(31, 19);
            rbStrike2.TabIndex = 2;
            rbStrike2.TabStop = true;
            rbStrike2.Text = "2";
            rbStrike2.UseVisualStyleBackColor = true;
            // 
            // rbStrike1
            // 
            rbStrike1.AutoSize = true;
            rbStrike1.Location = new Point(46, 15);
            rbStrike1.Name = "rbStrike1";
            rbStrike1.Size = new Size(31, 19);
            rbStrike1.TabIndex = 1;
            rbStrike1.TabStop = true;
            rbStrike1.Text = "1";
            rbStrike1.UseVisualStyleBackColor = true;
            // 
            // rbStrike0
            // 
            rbStrike0.AutoSize = true;
            rbStrike0.Checked = true;
            rbStrike0.Location = new Point(9, 15);
            rbStrike0.Name = "rbStrike0";
            rbStrike0.Size = new Size(31, 19);
            rbStrike0.TabIndex = 0;
            rbStrike0.TabStop = true;
            rbStrike0.Text = "0";
            rbStrike0.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(button12, 3, 2);
            tableLayoutPanel1.Controls.Add(button11, 2, 2);
            tableLayoutPanel1.Controls.Add(button10, 1, 2);
            tableLayoutPanel1.Controls.Add(button9, 0, 2);
            tableLayoutPanel1.Controls.Add(button8, 3, 1);
            tableLayoutPanel1.Controls.Add(button7, 2, 1);
            tableLayoutPanel1.Controls.Add(button6, 1, 1);
            tableLayoutPanel1.Controls.Add(btnWhosOnFirst, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSimonSays, 3, 0);
            tableLayoutPanel1.Controls.Add(btnKeypad, 2, 0);
            tableLayoutPanel1.Controls.Add(btnButton, 1, 0);
            tableLayoutPanel1.Controls.Add(btnWire, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 83);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(715, 397);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // button12
            // 
            button12.Dock = DockStyle.Fill;
            button12.Location = new Point(537, 267);
            button12.Name = "button12";
            button12.Size = new Size(175, 127);
            button12.TabIndex = 11;
            button12.Text = "button12";
            button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            button11.Dock = DockStyle.Fill;
            button11.Location = new Point(359, 267);
            button11.Name = "button11";
            button11.Size = new Size(172, 127);
            button11.TabIndex = 10;
            button11.Text = "button11";
            button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            button10.Dock = DockStyle.Fill;
            button10.Location = new Point(181, 267);
            button10.Name = "button10";
            button10.Size = new Size(172, 127);
            button10.TabIndex = 9;
            button10.Text = "button10";
            button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Dock = DockStyle.Fill;
            button9.Location = new Point(3, 267);
            button9.Name = "button9";
            button9.Size = new Size(172, 127);
            button9.TabIndex = 8;
            button9.Text = "button9";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Fill;
            button8.Location = new Point(537, 135);
            button8.Name = "button8";
            button8.Size = new Size(175, 126);
            button8.TabIndex = 7;
            button8.Text = "button8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Fill;
            button7.Location = new Point(359, 135);
            button7.Name = "button7";
            button7.Size = new Size(172, 126);
            button7.TabIndex = 6;
            button7.Text = "button7";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Dock = DockStyle.Fill;
            button6.Location = new Point(181, 135);
            button6.Name = "button6";
            button6.Size = new Size(172, 126);
            button6.TabIndex = 5;
            button6.Text = "button6";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnWhosOnFirst
            // 
            btnWhosOnFirst.BackgroundImage = Properties.Resources.WhosOnFirst;
            btnWhosOnFirst.BackgroundImageLayout = ImageLayout.Zoom;
            btnWhosOnFirst.Dock = DockStyle.Fill;
            btnWhosOnFirst.Location = new Point(3, 135);
            btnWhosOnFirst.Name = "btnWhosOnFirst";
            btnWhosOnFirst.Size = new Size(172, 126);
            btnWhosOnFirst.TabIndex = 4;
            btnWireTooltip.SetToolTip(btnWhosOnFirst, "On the subject of Who's on First");
            btnWhosOnFirst.UseVisualStyleBackColor = true;
            btnWhosOnFirst.Click += btnWhosOnFirst_Click;
            // 
            // btnSimonSays
            // 
            btnSimonSays.BackgroundImage = Properties.Resources.SimonSays;
            btnSimonSays.BackgroundImageLayout = ImageLayout.Zoom;
            btnSimonSays.Dock = DockStyle.Fill;
            btnSimonSays.Location = new Point(537, 3);
            btnSimonSays.Name = "btnSimonSays";
            btnSimonSays.Size = new Size(175, 126);
            btnSimonSays.TabIndex = 3;
            btnWireTooltip.SetToolTip(btnSimonSays, "On the subject of Simon Says");
            btnSimonSays.UseVisualStyleBackColor = true;
            btnSimonSays.Click += btnSimonSays_Click;
            // 
            // btnKeypad
            // 
            btnKeypad.BackgroundImage = Properties.Resources.Keypad;
            btnKeypad.BackgroundImageLayout = ImageLayout.Zoom;
            btnKeypad.Dock = DockStyle.Fill;
            btnKeypad.Location = new Point(359, 3);
            btnKeypad.Name = "btnKeypad";
            btnKeypad.Size = new Size(172, 126);
            btnKeypad.TabIndex = 2;
            btnWireTooltip.SetToolTip(btnKeypad, "On the subject of Keypads");
            btnKeypad.UseVisualStyleBackColor = true;
            btnKeypad.Click += btnKeypad_Click;
            // 
            // btnButton
            // 
            btnButton.BackgroundImage = Properties.Resources.Button;
            btnButton.BackgroundImageLayout = ImageLayout.Zoom;
            btnButton.Dock = DockStyle.Fill;
            btnButton.Location = new Point(181, 3);
            btnButton.Name = "btnButton";
            btnButton.Size = new Size(172, 126);
            btnButton.TabIndex = 1;
            btnWireTooltip.SetToolTip(btnButton, "On the subject of Buttons");
            btnButton.UseVisualStyleBackColor = true;
            btnButton.Click += btnButton_Click;
            // 
            // btnWire
            // 
            btnWire.BackgroundImage = Properties.Resources.Wires;
            btnWire.BackgroundImageLayout = ImageLayout.Zoom;
            btnWire.Dock = DockStyle.Fill;
            btnWire.Location = new Point(3, 3);
            btnWire.Name = "btnWire";
            btnWire.Size = new Size(172, 126);
            btnWire.TabIndex = 0;
            btnWire.TextAlign = ContentAlignment.TopCenter;
            btnWireTooltip.SetToolTip(btnWire, "On the subject of Wires");
            btnWire.UseVisualStyleBackColor = true;
            btnWire.Click += btnWire_Click;
            // 
            // grbBombInfo
            // 
            grbBombInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbBombInfo.Controls.Add(btnReset);
            grbBombInfo.Controls.Add(lblBatteries);
            grbBombInfo.Controls.Add(nudBatteries);
            grbBombInfo.Controls.Add(grbStrike);
            grbBombInfo.Controls.Add(cbSerialVowel);
            grbBombInfo.Controls.Add(lblStrike);
            grbBombInfo.Controls.Add(cbParallel);
            grbBombInfo.Controls.Add(grbSerial);
            grbBombInfo.Controls.Add(lblSerial);
            grbBombInfo.Controls.Add(cbCAR);
            grbBombInfo.Controls.Add(cbFRK);
            grbBombInfo.Location = new Point(0, -8);
            grbBombInfo.Name = "grbBombInfo";
            grbBombInfo.Size = new Size(739, 85);
            grbBombInfo.TabIndex = 10;
            grbBombInfo.TabStop = false;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(535, 55);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(189, 23);
            btnReset.TabIndex = 9;
            btnReset.Text = "RESET BOMB";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // KTNESolver
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 492);
            Controls.Add(grbBombInfo);
            Controls.Add(tableLayoutPanel1);
            Name = "KTNESolver";
            Text = " Keep talking and nobody explodes Solver";
            ((System.ComponentModel.ISupportInitialize)nudBatteries).EndInit();
            grbSerial.ResumeLayout(false);
            grbSerial.PerformLayout();
            grbStrike.ResumeLayout(false);
            grbStrike.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            grbBombInfo.ResumeLayout(false);
            grbBombInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBatteries;
        private NumericUpDown nudBatteries;
        private CheckBox cbSerialVowel;
        private CheckBox cbParallel;
        private RadioButton rbSerialEven;
        private RadioButton rbSerialOdd;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblSerial;
        private CheckBox cbFRK;
        private CheckBox cbCAR;
        private GroupBox grbSerial;
        private Label lblStrike;
        private GroupBox grbStrike;
        private RadioButton rbStrike2;
        private RadioButton rbStrike1;
        private RadioButton rbStrike0;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button btnWhosOnFirst;
        private Button btnSimonSays;
        private Button btnKeypad;
        private Button btnButton;
        private Button btnWire;
        private GroupBox grbBombInfo;
        private Button btnReset;
        private ToolTip btnWireTooltip;
    }
}
