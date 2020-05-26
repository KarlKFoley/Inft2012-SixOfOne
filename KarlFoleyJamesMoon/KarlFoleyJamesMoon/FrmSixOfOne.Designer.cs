namespace KarlFoleyJamesMoon
{
    partial class FrmSixOfOne
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
            this.LblPlayerOneName = new System.Windows.Forms.Label();
            this.LblPlayerTwoName = new System.Windows.Forms.Label();
            this.BtnRoll = new System.Windows.Forms.Button();
            this.LblScorePlayerOne = new System.Windows.Forms.Label();
            this.LblScorePlayerTwo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radButDiceNumberSix = new System.Windows.Forms.RadioButton();
            this.radButDiceNumberFive = new System.Windows.Forms.RadioButton();
            this.radButDiceNumberFour = new System.Windows.Forms.RadioButton();
            this.radButDiceNumberThree = new System.Windows.Forms.RadioButton();
            this.radButDiceNumberTwo = new System.Windows.Forms.RadioButton();
            this.radButDiceNumberOne = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictBoxDiceOne = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceTwo = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceThree = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceFour = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceFive = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceSix = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceFour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceFive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceSix)).BeginInit();
            this.SuspendLayout();
            // 
            // LblPlayerOneName
            // 
            this.LblPlayerOneName.AutoSize = true;
            this.LblPlayerOneName.Location = new System.Drawing.Point(207, 9);
            this.LblPlayerOneName.Name = "LblPlayerOneName";
            this.LblPlayerOneName.Size = new System.Drawing.Size(59, 13);
            this.LblPlayerOneName.TabIndex = 0;
            this.LblPlayerOneName.Text = "Player One";
            // 
            // LblPlayerTwoName
            // 
            this.LblPlayerTwoName.AutoSize = true;
            this.LblPlayerTwoName.Location = new System.Drawing.Point(653, 9);
            this.LblPlayerTwoName.Name = "LblPlayerTwoName";
            this.LblPlayerTwoName.Size = new System.Drawing.Size(60, 13);
            this.LblPlayerTwoName.TabIndex = 1;
            this.LblPlayerTwoName.Text = "Player Two";
            // 
            // BtnRoll
            // 
            this.BtnRoll.Location = new System.Drawing.Point(454, 120);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(75, 23);
            this.BtnRoll.TabIndex = 2;
            this.BtnRoll.Text = "Roll !";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // LblScorePlayerOne
            // 
            this.LblScorePlayerOne.AutoSize = true;
            this.LblScorePlayerOne.Location = new System.Drawing.Point(272, 9);
            this.LblScorePlayerOne.Name = "LblScorePlayerOne";
            this.LblScorePlayerOne.Size = new System.Drawing.Size(50, 13);
            this.LblScorePlayerOne.TabIndex = 3;
            this.LblScorePlayerOne.Text = "Score : 0";
            // 
            // LblScorePlayerTwo
            // 
            this.LblScorePlayerTwo.AutoSize = true;
            this.LblScorePlayerTwo.Location = new System.Drawing.Point(719, 9);
            this.LblScorePlayerTwo.Name = "LblScorePlayerTwo";
            this.LblScorePlayerTwo.Size = new System.Drawing.Size(50, 13);
            this.LblScorePlayerTwo.TabIndex = 4;
            this.LblScorePlayerTwo.Text = "Score : 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.radButDiceNumberSix);
            this.groupBox1.Controls.Add(this.radButDiceNumberFive);
            this.groupBox1.Controls.Add(this.radButDiceNumberFour);
            this.groupBox1.Controls.Add(this.radButDiceNumberThree);
            this.groupBox1.Controls.Add(this.radButDiceNumberTwo);
            this.groupBox1.Controls.Add(this.radButDiceNumberOne);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(210, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // radButDiceNumberSix
            // 
            this.radButDiceNumberSix.AutoSize = true;
            this.radButDiceNumberSix.Location = new System.Drawing.Point(470, 31);
            this.radButDiceNumberSix.Name = "radButDiceNumberSix";
            this.radButDiceNumberSix.Size = new System.Drawing.Size(42, 29);
            this.radButDiceNumberSix.TabIndex = 12;
            this.radButDiceNumberSix.TabStop = true;
            this.radButDiceNumberSix.Text = "6";
            this.radButDiceNumberSix.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButDiceNumberSix.UseVisualStyleBackColor = true;
            // 
            // radButDiceNumberFive
            // 
            this.radButDiceNumberFive.AutoSize = true;
            this.radButDiceNumberFive.Location = new System.Drawing.Point(376, 31);
            this.radButDiceNumberFive.Name = "radButDiceNumberFive";
            this.radButDiceNumberFive.Size = new System.Drawing.Size(42, 29);
            this.radButDiceNumberFive.TabIndex = 11;
            this.radButDiceNumberFive.TabStop = true;
            this.radButDiceNumberFive.Text = "5";
            this.radButDiceNumberFive.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButDiceNumberFive.UseVisualStyleBackColor = true;
            // 
            // radButDiceNumberFour
            // 
            this.radButDiceNumberFour.AutoSize = true;
            this.radButDiceNumberFour.Location = new System.Drawing.Point(277, 31);
            this.radButDiceNumberFour.Name = "radButDiceNumberFour";
            this.radButDiceNumberFour.Size = new System.Drawing.Size(42, 29);
            this.radButDiceNumberFour.TabIndex = 10;
            this.radButDiceNumberFour.TabStop = true;
            this.radButDiceNumberFour.Text = "4";
            this.radButDiceNumberFour.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButDiceNumberFour.UseVisualStyleBackColor = true;
            // 
            // radButDiceNumberThree
            // 
            this.radButDiceNumberThree.AutoSize = true;
            this.radButDiceNumberThree.Location = new System.Drawing.Point(186, 31);
            this.radButDiceNumberThree.Name = "radButDiceNumberThree";
            this.radButDiceNumberThree.Size = new System.Drawing.Size(42, 29);
            this.radButDiceNumberThree.TabIndex = 9;
            this.radButDiceNumberThree.TabStop = true;
            this.radButDiceNumberThree.Text = "3";
            this.radButDiceNumberThree.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButDiceNumberThree.UseVisualStyleBackColor = true;
            // 
            // radButDiceNumberTwo
            // 
            this.radButDiceNumberTwo.AutoSize = true;
            this.radButDiceNumberTwo.Location = new System.Drawing.Point(112, 31);
            this.radButDiceNumberTwo.Name = "radButDiceNumberTwo";
            this.radButDiceNumberTwo.Size = new System.Drawing.Size(42, 29);
            this.radButDiceNumberTwo.TabIndex = 8;
            this.radButDiceNumberTwo.TabStop = true;
            this.radButDiceNumberTwo.Text = "2";
            this.radButDiceNumberTwo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButDiceNumberTwo.UseVisualStyleBackColor = true;
            // 
            // radButDiceNumberOne
            // 
            this.radButDiceNumberOne.AutoSize = true;
            this.radButDiceNumberOne.Checked = true;
            this.radButDiceNumberOne.Location = new System.Drawing.Point(30, 31);
            this.radButDiceNumberOne.Name = "radButDiceNumberOne";
            this.radButDiceNumberOne.Size = new System.Drawing.Size(42, 29);
            this.radButDiceNumberOne.TabIndex = 7;
            this.radButDiceNumberOne.TabStop = true;
            this.radButDiceNumberOne.Text = "1";
            this.radButDiceNumberOne.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.radButDiceNumberOne.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "How many dice do you want to Roll";
            // 
            // pictBoxDiceOne
            // 
            this.pictBoxDiceOne.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceOne.Location = new System.Drawing.Point(374, 205);
            this.pictBoxDiceOne.Name = "pictBoxDiceOne";
            this.pictBoxDiceOne.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceOne.TabIndex = 6;
            this.pictBoxDiceOne.TabStop = false;
            this.pictBoxDiceOne.Visible = false;
            // 
            // pictBoxDiceTwo
            // 
            this.pictBoxDiceTwo.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceTwo.Location = new System.Drawing.Point(554, 205);
            this.pictBoxDiceTwo.Name = "pictBoxDiceTwo";
            this.pictBoxDiceTwo.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceTwo.TabIndex = 7;
            this.pictBoxDiceTwo.TabStop = false;
            this.pictBoxDiceTwo.Visible = false;
            // 
            // pictBoxDiceThree
            // 
            this.pictBoxDiceThree.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceThree.Location = new System.Drawing.Point(200, 205);
            this.pictBoxDiceThree.Name = "pictBoxDiceThree";
            this.pictBoxDiceThree.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceThree.TabIndex = 8;
            this.pictBoxDiceThree.TabStop = false;
            this.pictBoxDiceThree.Visible = false;
            // 
            // pictBoxDiceFour
            // 
            this.pictBoxDiceFour.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceFour.Location = new System.Drawing.Point(730, 205);
            this.pictBoxDiceFour.Name = "pictBoxDiceFour";
            this.pictBoxDiceFour.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceFour.TabIndex = 9;
            this.pictBoxDiceFour.TabStop = false;
            this.pictBoxDiceFour.Visible = false;
            // 
            // pictBoxDiceFive
            // 
            this.pictBoxDiceFive.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceFive.Location = new System.Drawing.Point(27, 205);
            this.pictBoxDiceFive.Name = "pictBoxDiceFive";
            this.pictBoxDiceFive.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceFive.TabIndex = 10;
            this.pictBoxDiceFive.TabStop = false;
            this.pictBoxDiceFive.Visible = false;
            // 
            // pictBoxDiceSix
            // 
            this.pictBoxDiceSix.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceSix.Location = new System.Drawing.Point(910, 205);
            this.pictBoxDiceSix.Name = "pictBoxDiceSix";
            this.pictBoxDiceSix.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceSix.TabIndex = 11;
            this.pictBoxDiceSix.TabStop = false;
            this.pictBoxDiceSix.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(435, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "First to ";
            // 
            // FrmSixOfOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 482);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pictBoxDiceSix);
            this.Controls.Add(this.pictBoxDiceFive);
            this.Controls.Add(this.pictBoxDiceFour);
            this.Controls.Add(this.pictBoxDiceThree);
            this.Controls.Add(this.pictBoxDiceTwo);
            this.Controls.Add(this.pictBoxDiceOne);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblScorePlayerTwo);
            this.Controls.Add(this.LblScorePlayerOne);
            this.Controls.Add(this.BtnRoll);
            this.Controls.Add(this.LblPlayerTwoName);
            this.Controls.Add(this.LblPlayerOneName);
            this.Name = "FrmSixOfOne";
            this.Text = "Six Of One";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceFour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceFive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBoxDiceSix)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblPlayerOneName;
        private System.Windows.Forms.Label LblPlayerTwoName;
        private System.Windows.Forms.Button BtnRoll;
        private System.Windows.Forms.Label LblScorePlayerOne;
        private System.Windows.Forms.Label LblScorePlayerTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBoxDiceOne;
        private System.Windows.Forms.PictureBox pictBoxDiceTwo;
        private System.Windows.Forms.PictureBox pictBoxDiceThree;
        private System.Windows.Forms.PictureBox pictBoxDiceFour;
        private System.Windows.Forms.PictureBox pictBoxDiceFive;
        private System.Windows.Forms.PictureBox pictBoxDiceSix;
        private System.Windows.Forms.RadioButton radButDiceNumberSix;
        private System.Windows.Forms.RadioButton radButDiceNumberFive;
        private System.Windows.Forms.RadioButton radButDiceNumberFour;
        private System.Windows.Forms.RadioButton radButDiceNumberThree;
        private System.Windows.Forms.RadioButton radButDiceNumberTwo;
        private System.Windows.Forms.RadioButton radButDiceNumberOne;
        private System.Windows.Forms.Label lblScore;
    }
}