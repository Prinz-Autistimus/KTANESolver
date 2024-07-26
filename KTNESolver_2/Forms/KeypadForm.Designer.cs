namespace KTNESolver_2.Forms
{
    partial class KeypadForm
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
            cbBallon = new CheckBox();
            flowKepads = new FlowLayoutPanel();
            cbAe = new CheckBox();
            cbAt = new CheckBox();
            cbBt = new CheckBox();
            cbCopyright = new CheckBox();
            cbCursive = new CheckBox();
            cbDouleK = new CheckBox();
            cbDragon = new CheckBox();
            cbEuro = new CheckBox();
            cbFilledStar = new CheckBox();
            cbHollowStar = new CheckBox();
            cbHookN = new CheckBox();
            cbLeftC = new CheckBox();
            cbMeltedThree = new CheckBox();
            cbNWithHat = new CheckBox();
            cbOmega = new CheckBox();
            cbParagraph = new CheckBox();
            cbPitchfork = new CheckBox();
            cbPumpkin = new CheckBox();
            cbQuestionmark = new CheckBox();
            cbRightC = new CheckBox();
            cbSix = new CheckBox();
            cbSmileyface = new CheckBox();
            cbSquidknife = new CheckBox();
            cbSquigglyN = new CheckBox();
            cbTracks = new CheckBox();
            cbUpsideDownY = new CheckBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            cbOut1 = new CheckBox();
            cbOut2 = new CheckBox();
            cbOut3 = new CheckBox();
            cbOut4 = new CheckBox();
            btnReset = new Button();
            flowKepads.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // cbBallon
            // 
            cbBallon.Appearance = Appearance.Button;
            cbBallon.BackgroundImage = Properties.Resources.balloon;
            cbBallon.BackgroundImageLayout = ImageLayout.Zoom;
            cbBallon.ImageAlign = ContentAlignment.MiddleLeft;
            cbBallon.Location = new Point(3, 3);
            cbBallon.Name = "cbBallon";
            cbBallon.Size = new Size(87, 80);
            cbBallon.TabIndex = 0;
            cbBallon.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbBallon.UseVisualStyleBackColor = true;
            cbBallon.CheckedChanged += solve;
            // 
            // flowKepads
            // 
            flowKepads.BorderStyle = BorderStyle.FixedSingle;
            flowKepads.Controls.Add(cbBallon);
            flowKepads.Controls.Add(cbAe);
            flowKepads.Controls.Add(cbAt);
            flowKepads.Controls.Add(cbBt);
            flowKepads.Controls.Add(cbCopyright);
            flowKepads.Controls.Add(cbCursive);
            flowKepads.Controls.Add(cbDouleK);
            flowKepads.Controls.Add(cbDragon);
            flowKepads.Controls.Add(cbEuro);
            flowKepads.Controls.Add(cbFilledStar);
            flowKepads.Controls.Add(cbHollowStar);
            flowKepads.Controls.Add(cbHookN);
            flowKepads.Controls.Add(cbLeftC);
            flowKepads.Controls.Add(cbMeltedThree);
            flowKepads.Controls.Add(cbNWithHat);
            flowKepads.Controls.Add(cbOmega);
            flowKepads.Controls.Add(cbParagraph);
            flowKepads.Controls.Add(cbPitchfork);
            flowKepads.Controls.Add(cbPumpkin);
            flowKepads.Controls.Add(cbQuestionmark);
            flowKepads.Controls.Add(cbRightC);
            flowKepads.Controls.Add(cbSix);
            flowKepads.Controls.Add(cbSmileyface);
            flowKepads.Controls.Add(cbSquidknife);
            flowKepads.Controls.Add(cbSquigglyN);
            flowKepads.Controls.Add(cbTracks);
            flowKepads.Controls.Add(cbUpsideDownY);
            flowKepads.Location = new Point(12, 12);
            flowKepads.Name = "flowKepads";
            flowKepads.Size = new Size(655, 346);
            flowKepads.TabIndex = 1;
            // 
            // cbAe
            // 
            cbAe.Appearance = Appearance.Button;
            cbAe.BackgroundImage = Properties.Resources.ae;
            cbAe.BackgroundImageLayout = ImageLayout.Zoom;
            cbAe.ImageAlign = ContentAlignment.MiddleLeft;
            cbAe.Location = new Point(96, 3);
            cbAe.Name = "cbAe";
            cbAe.Size = new Size(87, 80);
            cbAe.TabIndex = 1;
            cbAe.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbAe.UseVisualStyleBackColor = true;
            cbAe.CheckedChanged += solve;
            // 
            // cbAt
            // 
            cbAt.Appearance = Appearance.Button;
            cbAt.BackgroundImage = Properties.Resources.at;
            cbAt.BackgroundImageLayout = ImageLayout.Zoom;
            cbAt.ImageAlign = ContentAlignment.MiddleLeft;
            cbAt.Location = new Point(189, 3);
            cbAt.Name = "cbAt";
            cbAt.Size = new Size(87, 80);
            cbAt.TabIndex = 2;
            cbAt.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbAt.UseVisualStyleBackColor = true;
            cbAt.CheckedChanged += solve;
            // 
            // cbBt
            // 
            cbBt.Appearance = Appearance.Button;
            cbBt.BackgroundImage = Properties.Resources.bt;
            cbBt.BackgroundImageLayout = ImageLayout.Zoom;
            cbBt.ImageAlign = ContentAlignment.MiddleLeft;
            cbBt.Location = new Point(282, 3);
            cbBt.Name = "cbBt";
            cbBt.Size = new Size(87, 80);
            cbBt.TabIndex = 3;
            cbBt.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbBt.UseVisualStyleBackColor = true;
            cbBt.CheckedChanged += solve;
            // 
            // cbCopyright
            // 
            cbCopyright.Appearance = Appearance.Button;
            cbCopyright.BackgroundImage = Properties.Resources.copyright;
            cbCopyright.BackgroundImageLayout = ImageLayout.Zoom;
            cbCopyright.ImageAlign = ContentAlignment.MiddleLeft;
            cbCopyright.Location = new Point(375, 3);
            cbCopyright.Name = "cbCopyright";
            cbCopyright.Size = new Size(87, 80);
            cbCopyright.TabIndex = 4;
            cbCopyright.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbCopyright.UseVisualStyleBackColor = true;
            cbCopyright.CheckedChanged += solve;
            // 
            // cbCursive
            // 
            cbCursive.Appearance = Appearance.Button;
            cbCursive.BackgroundImage = Properties.Resources.cursive;
            cbCursive.BackgroundImageLayout = ImageLayout.Zoom;
            cbCursive.ImageAlign = ContentAlignment.MiddleLeft;
            cbCursive.Location = new Point(468, 3);
            cbCursive.Name = "cbCursive";
            cbCursive.Size = new Size(87, 80);
            cbCursive.TabIndex = 5;
            cbCursive.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbCursive.UseVisualStyleBackColor = true;
            cbCursive.CheckedChanged += solve;
            // 
            // cbDouleK
            // 
            cbDouleK.Appearance = Appearance.Button;
            cbDouleK.BackgroundImage = Properties.Resources.doublek;
            cbDouleK.BackgroundImageLayout = ImageLayout.Zoom;
            cbDouleK.ImageAlign = ContentAlignment.MiddleLeft;
            cbDouleK.Location = new Point(561, 3);
            cbDouleK.Name = "cbDouleK";
            cbDouleK.Size = new Size(87, 80);
            cbDouleK.TabIndex = 6;
            cbDouleK.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbDouleK.UseVisualStyleBackColor = true;
            cbDouleK.CheckedChanged += solve;
            // 
            // cbDragon
            // 
            cbDragon.Appearance = Appearance.Button;
            cbDragon.BackgroundImage = Properties.Resources.dragon;
            cbDragon.BackgroundImageLayout = ImageLayout.Zoom;
            cbDragon.ImageAlign = ContentAlignment.MiddleLeft;
            cbDragon.Location = new Point(3, 89);
            cbDragon.Name = "cbDragon";
            cbDragon.Size = new Size(87, 80);
            cbDragon.TabIndex = 7;
            cbDragon.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbDragon.UseVisualStyleBackColor = true;
            cbDragon.CheckedChanged += solve;
            // 
            // cbEuro
            // 
            cbEuro.Appearance = Appearance.Button;
            cbEuro.BackgroundImage = Properties.Resources.euro;
            cbEuro.BackgroundImageLayout = ImageLayout.Zoom;
            cbEuro.ImageAlign = ContentAlignment.MiddleLeft;
            cbEuro.Location = new Point(96, 89);
            cbEuro.Name = "cbEuro";
            cbEuro.Size = new Size(87, 80);
            cbEuro.TabIndex = 8;
            cbEuro.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbEuro.UseVisualStyleBackColor = true;
            cbEuro.CheckedChanged += solve;
            // 
            // cbFilledStar
            // 
            cbFilledStar.Appearance = Appearance.Button;
            cbFilledStar.BackgroundImage = Properties.Resources.filledstar;
            cbFilledStar.BackgroundImageLayout = ImageLayout.Zoom;
            cbFilledStar.ImageAlign = ContentAlignment.MiddleLeft;
            cbFilledStar.Location = new Point(189, 89);
            cbFilledStar.Name = "cbFilledStar";
            cbFilledStar.Size = new Size(87, 80);
            cbFilledStar.TabIndex = 9;
            cbFilledStar.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbFilledStar.UseVisualStyleBackColor = true;
            cbFilledStar.CheckedChanged += solve;
            // 
            // cbHollowStar
            // 
            cbHollowStar.Appearance = Appearance.Button;
            cbHollowStar.BackgroundImage = Properties.Resources.hollowstar;
            cbHollowStar.BackgroundImageLayout = ImageLayout.Zoom;
            cbHollowStar.ImageAlign = ContentAlignment.MiddleLeft;
            cbHollowStar.Location = new Point(282, 89);
            cbHollowStar.Name = "cbHollowStar";
            cbHollowStar.Size = new Size(87, 80);
            cbHollowStar.TabIndex = 10;
            cbHollowStar.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbHollowStar.UseVisualStyleBackColor = true;
            cbHollowStar.CheckedChanged += solve;
            // 
            // cbHookN
            // 
            cbHookN.Appearance = Appearance.Button;
            cbHookN.BackgroundImage = Properties.Resources.hookn;
            cbHookN.BackgroundImageLayout = ImageLayout.Zoom;
            cbHookN.ImageAlign = ContentAlignment.MiddleLeft;
            cbHookN.Location = new Point(375, 89);
            cbHookN.Name = "cbHookN";
            cbHookN.Size = new Size(87, 80);
            cbHookN.TabIndex = 11;
            cbHookN.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbHookN.UseVisualStyleBackColor = true;
            cbHookN.CheckedChanged += solve;
            // 
            // cbLeftC
            // 
            cbLeftC.Appearance = Appearance.Button;
            cbLeftC.BackgroundImage = Properties.Resources.leftc;
            cbLeftC.BackgroundImageLayout = ImageLayout.Zoom;
            cbLeftC.ImageAlign = ContentAlignment.MiddleLeft;
            cbLeftC.Location = new Point(468, 89);
            cbLeftC.Name = "cbLeftC";
            cbLeftC.Size = new Size(87, 80);
            cbLeftC.TabIndex = 12;
            cbLeftC.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbLeftC.UseVisualStyleBackColor = true;
            cbLeftC.CheckedChanged += solve;
            // 
            // cbMeltedThree
            // 
            cbMeltedThree.Appearance = Appearance.Button;
            cbMeltedThree.BackgroundImage = Properties.Resources.meltedthree;
            cbMeltedThree.BackgroundImageLayout = ImageLayout.Zoom;
            cbMeltedThree.ImageAlign = ContentAlignment.MiddleLeft;
            cbMeltedThree.Location = new Point(561, 89);
            cbMeltedThree.Name = "cbMeltedThree";
            cbMeltedThree.Size = new Size(87, 80);
            cbMeltedThree.TabIndex = 13;
            cbMeltedThree.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbMeltedThree.UseVisualStyleBackColor = true;
            cbMeltedThree.CheckedChanged += solve;
            // 
            // cbNWithHat
            // 
            cbNWithHat.Appearance = Appearance.Button;
            cbNWithHat.BackgroundImage = Properties.Resources.nwithhat;
            cbNWithHat.BackgroundImageLayout = ImageLayout.Zoom;
            cbNWithHat.ImageAlign = ContentAlignment.MiddleLeft;
            cbNWithHat.Location = new Point(3, 175);
            cbNWithHat.Name = "cbNWithHat";
            cbNWithHat.Size = new Size(87, 80);
            cbNWithHat.TabIndex = 14;
            cbNWithHat.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbNWithHat.UseVisualStyleBackColor = true;
            cbNWithHat.CheckedChanged += solve;
            // 
            // cbOmega
            // 
            cbOmega.Appearance = Appearance.Button;
            cbOmega.BackgroundImage = Properties.Resources.omega;
            cbOmega.BackgroundImageLayout = ImageLayout.Zoom;
            cbOmega.ImageAlign = ContentAlignment.MiddleLeft;
            cbOmega.Location = new Point(96, 175);
            cbOmega.Name = "cbOmega";
            cbOmega.Size = new Size(87, 80);
            cbOmega.TabIndex = 15;
            cbOmega.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbOmega.UseVisualStyleBackColor = true;
            cbOmega.CheckedChanged += solve;
            // 
            // cbParagraph
            // 
            cbParagraph.Appearance = Appearance.Button;
            cbParagraph.BackgroundImage = Properties.Resources.paragraph;
            cbParagraph.BackgroundImageLayout = ImageLayout.Zoom;
            cbParagraph.ImageAlign = ContentAlignment.MiddleLeft;
            cbParagraph.Location = new Point(189, 175);
            cbParagraph.Name = "cbParagraph";
            cbParagraph.Size = new Size(87, 80);
            cbParagraph.TabIndex = 16;
            cbParagraph.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbParagraph.UseVisualStyleBackColor = true;
            cbParagraph.CheckedChanged += solve;
            // 
            // cbPitchfork
            // 
            cbPitchfork.Appearance = Appearance.Button;
            cbPitchfork.BackgroundImage = Properties.Resources.pitchfork;
            cbPitchfork.BackgroundImageLayout = ImageLayout.Zoom;
            cbPitchfork.ImageAlign = ContentAlignment.MiddleLeft;
            cbPitchfork.Location = new Point(282, 175);
            cbPitchfork.Name = "cbPitchfork";
            cbPitchfork.Size = new Size(87, 80);
            cbPitchfork.TabIndex = 17;
            cbPitchfork.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbPitchfork.UseVisualStyleBackColor = true;
            cbPitchfork.CheckedChanged += solve;
            // 
            // cbPumpkin
            // 
            cbPumpkin.Appearance = Appearance.Button;
            cbPumpkin.BackgroundImage = Properties.Resources.pumpkin;
            cbPumpkin.BackgroundImageLayout = ImageLayout.Zoom;
            cbPumpkin.ImageAlign = ContentAlignment.MiddleLeft;
            cbPumpkin.Location = new Point(375, 175);
            cbPumpkin.Name = "cbPumpkin";
            cbPumpkin.Size = new Size(87, 80);
            cbPumpkin.TabIndex = 18;
            cbPumpkin.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbPumpkin.UseVisualStyleBackColor = true;
            cbPumpkin.CheckedChanged += solve;
            // 
            // cbQuestionmark
            // 
            cbQuestionmark.Appearance = Appearance.Button;
            cbQuestionmark.BackgroundImage = Properties.Resources.questionmark;
            cbQuestionmark.BackgroundImageLayout = ImageLayout.Zoom;
            cbQuestionmark.ImageAlign = ContentAlignment.MiddleLeft;
            cbQuestionmark.Location = new Point(468, 175);
            cbQuestionmark.Name = "cbQuestionmark";
            cbQuestionmark.Size = new Size(87, 80);
            cbQuestionmark.TabIndex = 19;
            cbQuestionmark.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbQuestionmark.UseVisualStyleBackColor = true;
            cbQuestionmark.CheckedChanged += solve;
            // 
            // cbRightC
            // 
            cbRightC.Appearance = Appearance.Button;
            cbRightC.BackgroundImage = Properties.Resources.rightc;
            cbRightC.BackgroundImageLayout = ImageLayout.Zoom;
            cbRightC.ImageAlign = ContentAlignment.MiddleLeft;
            cbRightC.Location = new Point(561, 175);
            cbRightC.Name = "cbRightC";
            cbRightC.Size = new Size(87, 80);
            cbRightC.TabIndex = 20;
            cbRightC.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbRightC.UseVisualStyleBackColor = true;
            cbRightC.CheckedChanged += solve;
            // 
            // cbSix
            // 
            cbSix.Appearance = Appearance.Button;
            cbSix.BackgroundImage = Properties.Resources.six;
            cbSix.BackgroundImageLayout = ImageLayout.Zoom;
            cbSix.ImageAlign = ContentAlignment.MiddleLeft;
            cbSix.Location = new Point(3, 261);
            cbSix.Name = "cbSix";
            cbSix.Size = new Size(87, 80);
            cbSix.TabIndex = 21;
            cbSix.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbSix.UseVisualStyleBackColor = true;
            cbSix.CheckedChanged += solve;
            // 
            // cbSmileyface
            // 
            cbSmileyface.Appearance = Appearance.Button;
            cbSmileyface.BackgroundImage = Properties.Resources.smileyface;
            cbSmileyface.BackgroundImageLayout = ImageLayout.Zoom;
            cbSmileyface.ImageAlign = ContentAlignment.MiddleLeft;
            cbSmileyface.Location = new Point(96, 261);
            cbSmileyface.Name = "cbSmileyface";
            cbSmileyface.Size = new Size(87, 80);
            cbSmileyface.TabIndex = 22;
            cbSmileyface.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbSmileyface.UseVisualStyleBackColor = true;
            cbSmileyface.CheckedChanged += solve;
            // 
            // cbSquidknife
            // 
            cbSquidknife.Appearance = Appearance.Button;
            cbSquidknife.BackgroundImage = Properties.Resources.squidknife;
            cbSquidknife.BackgroundImageLayout = ImageLayout.Zoom;
            cbSquidknife.ImageAlign = ContentAlignment.MiddleLeft;
            cbSquidknife.Location = new Point(189, 261);
            cbSquidknife.Name = "cbSquidknife";
            cbSquidknife.Size = new Size(87, 80);
            cbSquidknife.TabIndex = 23;
            cbSquidknife.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbSquidknife.UseVisualStyleBackColor = true;
            cbSquidknife.CheckedChanged += solve;
            // 
            // cbSquigglyN
            // 
            cbSquigglyN.Appearance = Appearance.Button;
            cbSquigglyN.BackgroundImage = Properties.Resources.squigglyn;
            cbSquigglyN.BackgroundImageLayout = ImageLayout.Zoom;
            cbSquigglyN.ImageAlign = ContentAlignment.MiddleLeft;
            cbSquigglyN.Location = new Point(282, 261);
            cbSquigglyN.Name = "cbSquigglyN";
            cbSquigglyN.Size = new Size(87, 80);
            cbSquigglyN.TabIndex = 24;
            cbSquigglyN.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbSquigglyN.UseVisualStyleBackColor = true;
            cbSquigglyN.CheckedChanged += solve;
            // 
            // cbTracks
            // 
            cbTracks.Appearance = Appearance.Button;
            cbTracks.BackgroundImage = Properties.Resources.tracks;
            cbTracks.BackgroundImageLayout = ImageLayout.Zoom;
            cbTracks.ImageAlign = ContentAlignment.MiddleLeft;
            cbTracks.Location = new Point(375, 261);
            cbTracks.Name = "cbTracks";
            cbTracks.Size = new Size(87, 80);
            cbTracks.TabIndex = 25;
            cbTracks.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbTracks.UseVisualStyleBackColor = true;
            cbTracks.CheckedChanged += solve;
            // 
            // cbUpsideDownY
            // 
            cbUpsideDownY.Appearance = Appearance.Button;
            cbUpsideDownY.BackgroundImage = Properties.Resources.upsidedowny;
            cbUpsideDownY.BackgroundImageLayout = ImageLayout.Zoom;
            cbUpsideDownY.ImageAlign = ContentAlignment.MiddleLeft;
            cbUpsideDownY.Location = new Point(468, 261);
            cbUpsideDownY.Name = "cbUpsideDownY";
            cbUpsideDownY.Size = new Size(87, 80);
            cbUpsideDownY.TabIndex = 26;
            cbUpsideDownY.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbUpsideDownY.UseVisualStyleBackColor = true;
            cbUpsideDownY.CheckedChanged += solve;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BorderStyle = BorderStyle.FixedSingle;
            flowLayoutPanel2.Controls.Add(cbOut1);
            flowLayoutPanel2.Controls.Add(cbOut2);
            flowLayoutPanel2.Controls.Add(cbOut3);
            flowLayoutPanel2.Controls.Add(cbOut4);
            flowLayoutPanel2.Location = new Point(151, 365);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(375, 88);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // cbOut1
            // 
            cbOut1.Appearance = Appearance.Button;
            cbOut1.BackgroundImageLayout = ImageLayout.Zoom;
            cbOut1.Enabled = false;
            cbOut1.ImageAlign = ContentAlignment.MiddleLeft;
            cbOut1.Location = new Point(3, 3);
            cbOut1.Name = "cbOut1";
            cbOut1.Size = new Size(87, 80);
            cbOut1.TabIndex = 1;
            cbOut1.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbOut1.UseVisualStyleBackColor = true;
            // 
            // cbOut2
            // 
            cbOut2.Appearance = Appearance.Button;
            cbOut2.BackgroundImageLayout = ImageLayout.Zoom;
            cbOut2.Enabled = false;
            cbOut2.ImageAlign = ContentAlignment.MiddleLeft;
            cbOut2.Location = new Point(96, 3);
            cbOut2.Name = "cbOut2";
            cbOut2.Size = new Size(87, 80);
            cbOut2.TabIndex = 2;
            cbOut2.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbOut2.UseVisualStyleBackColor = true;
            // 
            // cbOut3
            // 
            cbOut3.Appearance = Appearance.Button;
            cbOut3.BackgroundImageLayout = ImageLayout.Zoom;
            cbOut3.Enabled = false;
            cbOut3.ImageAlign = ContentAlignment.MiddleLeft;
            cbOut3.Location = new Point(189, 3);
            cbOut3.Name = "cbOut3";
            cbOut3.Size = new Size(87, 80);
            cbOut3.TabIndex = 3;
            cbOut3.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbOut3.UseVisualStyleBackColor = true;
            // 
            // cbOut4
            // 
            cbOut4.Appearance = Appearance.Button;
            cbOut4.BackgroundImageLayout = ImageLayout.Zoom;
            cbOut4.Enabled = false;
            cbOut4.ImageAlign = ContentAlignment.MiddleLeft;
            cbOut4.Location = new Point(282, 3);
            cbOut4.Name = "cbOut4";
            cbOut4.Size = new Size(87, 80);
            cbOut4.TabIndex = 4;
            cbOut4.TextImageRelation = TextImageRelation.TextBeforeImage;
            cbOut4.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(532, 369);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(129, 80);
            btnReset.TabIndex = 3;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // KeypadForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 464);
            Controls.Add(btnReset);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(flowKepads);
            Name = "KeypadForm";
            Text = "Keypad Solver";
            Load += KeypadForm_Load;
            flowKepads.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private CheckBox cbBallon;
        private FlowLayoutPanel flowKepads;
        private CheckBox cbAe;
        private CheckBox cbAt;
        private CheckBox cbBt;
        private CheckBox cbCopyright;
        private CheckBox cbCursive;
        private CheckBox cbDouleK;
        private CheckBox cbDragon;
        private CheckBox cbEuro;
        private CheckBox cbFilledStar;
        private CheckBox cbHollowStar;
        private CheckBox cbHookN;
        private CheckBox cbLeftC;
        private CheckBox cbMeltedThree;
        private CheckBox cbNWithHat;
        private CheckBox cbOmega;
        private CheckBox cbParagraph;
        private CheckBox cbPitchfork;
        private CheckBox cbPumpkin;
        private CheckBox cbQuestionmark;
        private CheckBox cbRightC;
        private CheckBox cbSix;
        private CheckBox cbSmileyface;
        private CheckBox cbSquidknife;
        private CheckBox cbSquigglyN;
        private CheckBox cbTracks;
        private CheckBox cbUpsideDownY;
        private FlowLayoutPanel flowLayoutPanel2;
        private CheckBox cbOut1;
        private CheckBox cbOut2;
        private CheckBox cbOut3;
        private CheckBox cbOut4;
        private Button btnReset;
    }
}