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
            this.lblTotalDiceRoll = new System.Windows.Forms.Label();
            this.pictBoxDiceOne = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceTwo = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceThree = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceFour = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceFive = new System.Windows.Forms.PictureBox();
            this.pictBoxDiceSix = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.LblTurnOutcome = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxNewScore = new System.Windows.Forms.TextBox();
            this.LblNewGame = new System.Windows.Forms.Label();
            this.lblNewScore = new System.Windows.Forms.Label();
            this.tbxTotalWins = new System.Windows.Forms.TextBox();
            this.LblTotalWins = new System.Windows.Forms.Label();
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
            this.LblPlayerOneName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblPlayerOneName.AutoSize = true;
            this.LblPlayerOneName.Location = new System.Drawing.Point(207, 9);
            this.LblPlayerOneName.Name = "LblPlayerOneName";
            this.LblPlayerOneName.Size = new System.Drawing.Size(59, 13);
            this.LblPlayerOneName.TabIndex = 0;
            this.LblPlayerOneName.Text = "Player One";
            // 
            // LblPlayerTwoName
            // 
            this.LblPlayerTwoName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblPlayerTwoName.AutoSize = true;
            this.LblPlayerTwoName.Location = new System.Drawing.Point(653, 9);
            this.LblPlayerTwoName.Name = "LblPlayerTwoName";
            this.LblPlayerTwoName.Size = new System.Drawing.Size(60, 13);
            this.LblPlayerTwoName.TabIndex = 1;
            this.LblPlayerTwoName.Text = "Player Two";
            // 
            // BtnRoll
            // 
            this.BtnRoll.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRoll.Location = new System.Drawing.Point(454, 163);
            this.BtnRoll.Name = "BtnRoll";
            this.BtnRoll.Size = new System.Drawing.Size(75, 23);
            this.BtnRoll.TabIndex = 2;
            this.BtnRoll.Text = "Roll !";
            this.BtnRoll.UseVisualStyleBackColor = true;
            this.BtnRoll.Click += new System.EventHandler(this.BtnRoll_Click);
            // 
            // LblScorePlayerOne
            // 
            this.LblScorePlayerOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblScorePlayerOne.AutoSize = true;
            this.LblScorePlayerOne.Location = new System.Drawing.Point(272, 9);
            this.LblScorePlayerOne.Name = "LblScorePlayerOne";
            this.LblScorePlayerOne.Size = new System.Drawing.Size(50, 13);
            this.LblScorePlayerOne.TabIndex = 3;
            this.LblScorePlayerOne.Text = "Score : 0";
            // 
            // LblScorePlayerTwo
            // 
            this.LblScorePlayerTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.groupBox1.Controls.Add(this.lblTotalDiceRoll);
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
            // lblTotalDiceRoll
            // 
            this.lblTotalDiceRoll.AutoSize = true;
            this.lblTotalDiceRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDiceRoll.Location = new System.Drawing.Point(169, 0);
            this.lblTotalDiceRoll.Name = "lblTotalDiceRoll";
            this.lblTotalDiceRoll.Size = new System.Drawing.Size(305, 24);
            this.lblTotalDiceRoll.TabIndex = 6;
            this.lblTotalDiceRoll.Text = "How many dice do you want to Roll";
            // 
            // pictBoxDiceOne
            // 
            this.pictBoxDiceOne.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxDiceOne.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceOne.Location = new System.Drawing.Point(374, 244);
            this.pictBoxDiceOne.Name = "pictBoxDiceOne";
            this.pictBoxDiceOne.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceOne.TabIndex = 6;
            this.pictBoxDiceOne.TabStop = false;
            this.pictBoxDiceOne.Visible = false;
            // 
            // pictBoxDiceTwo
            // 
            this.pictBoxDiceTwo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxDiceTwo.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceTwo.Location = new System.Drawing.Point(554, 244);
            this.pictBoxDiceTwo.Name = "pictBoxDiceTwo";
            this.pictBoxDiceTwo.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceTwo.TabIndex = 7;
            this.pictBoxDiceTwo.TabStop = false;
            this.pictBoxDiceTwo.Visible = false;
            // 
            // pictBoxDiceThree
            // 
            this.pictBoxDiceThree.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxDiceThree.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceThree.Location = new System.Drawing.Point(200, 244);
            this.pictBoxDiceThree.Name = "pictBoxDiceThree";
            this.pictBoxDiceThree.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceThree.TabIndex = 8;
            this.pictBoxDiceThree.TabStop = false;
            this.pictBoxDiceThree.Visible = false;
            // 
            // pictBoxDiceFour
            // 
            this.pictBoxDiceFour.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxDiceFour.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceFour.Location = new System.Drawing.Point(730, 244);
            this.pictBoxDiceFour.Name = "pictBoxDiceFour";
            this.pictBoxDiceFour.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceFour.TabIndex = 9;
            this.pictBoxDiceFour.TabStop = false;
            this.pictBoxDiceFour.Visible = false;
            // 
            // pictBoxDiceFive
            // 
            this.pictBoxDiceFive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxDiceFive.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceFive.Location = new System.Drawing.Point(27, 244);
            this.pictBoxDiceFive.Name = "pictBoxDiceFive";
            this.pictBoxDiceFive.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceFive.TabIndex = 10;
            this.pictBoxDiceFive.TabStop = false;
            this.pictBoxDiceFive.Visible = false;
            // 
            // pictBoxDiceSix
            // 
            this.pictBoxDiceSix.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictBoxDiceSix.BackColor = System.Drawing.Color.Black;
            this.pictBoxDiceSix.Location = new System.Drawing.Point(910, 244);
            this.pictBoxDiceSix.Name = "pictBoxDiceSix";
            this.pictBoxDiceSix.Size = new System.Drawing.Size(100, 100);
            this.pictBoxDiceSix.TabIndex = 11;
            this.pictBoxDiceSix.TabStop = false;
            this.pictBoxDiceSix.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(435, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(41, 13);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "First to ";
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.Location = new System.Drawing.Point(440, 131);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(0, 25);
            this.lblPlayerTurn.TabIndex = 13;
            // 
            // LblTurnOutcome
            // 
            this.LblTurnOutcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblTurnOutcome.AutoSize = true;
            this.LblTurnOutcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTurnOutcome.Location = new System.Drawing.Point(376, 475);
            this.LblTurnOutcome.Name = "LblTurnOutcome";
            this.LblTurnOutcome.Size = new System.Drawing.Size(0, 25);
            this.LblTurnOutcome.TabIndex = 15;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNewGame.Location = new System.Drawing.Point(374, 526);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 23);
            this.btnNewGame.TabIndex = 16;
            this.btnNewGame.Text = "Start Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Visible = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnExit.Location = new System.Drawing.Point(554, 526);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxNewScore
            // 
            this.tbxNewScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tbxNewScore.Location = new System.Drawing.Point(374, 500);
            this.tbxNewScore.Name = "tbxNewScore";
            this.tbxNewScore.Size = new System.Drawing.Size(75, 20);
            this.tbxNewScore.TabIndex = 18;
            this.tbxNewScore.Visible = false;
            // 
            // LblNewGame
            // 
            this.LblNewGame.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNewGame.AutoSize = true;
            this.LblNewGame.Location = new System.Drawing.Point(378, 466);
            this.LblNewGame.Name = "LblNewGame";
            this.LblNewGame.Size = new System.Drawing.Size(60, 13);
            this.LblNewGame.TabIndex = 19;
            this.LblNewGame.Text = "New Game";
            this.LblNewGame.Visible = false;
            // 
            // lblNewScore
            // 
            this.lblNewScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNewScore.AutoSize = true;
            this.lblNewScore.Location = new System.Drawing.Point(378, 484);
            this.lblNewScore.Name = "lblNewScore";
            this.lblNewScore.Size = new System.Drawing.Size(60, 13);
            this.lblNewScore.TabIndex = 20;
            this.lblNewScore.Text = "New Score";
            this.lblNewScore.Visible = false;
            // 
            // tbxTotalWins
            // 
            this.tbxTotalWins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbxTotalWins.BackColor = System.Drawing.SystemColors.Control;
            this.tbxTotalWins.Location = new System.Drawing.Point(12, 463);
            this.tbxTotalWins.Multiline = true;
            this.tbxTotalWins.Name = "tbxTotalWins";
            this.tbxTotalWins.Size = new System.Drawing.Size(58, 37);
            this.tbxTotalWins.TabIndex = 21;
            // 
            // LblTotalWins
            // 
            this.LblTotalWins.AutoSize = true;
            this.LblTotalWins.Location = new System.Drawing.Point(12, 447);
            this.LblTotalWins.Name = "LblTotalWins";
            this.LblTotalWins.Size = new System.Drawing.Size(58, 13);
            this.LblTotalWins.TabIndex = 22;
            this.LblTotalWins.Text = "Total Wins";
            // 
            // FrmSixOfOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 561);
            this.Controls.Add(this.LblTotalWins);
            this.Controls.Add(this.tbxTotalWins);
            this.Controls.Add(this.lblNewScore);
            this.Controls.Add(this.LblNewGame);
            this.Controls.Add(this.tbxNewScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.LblTurnOutcome);
            this.Controls.Add(this.lblPlayerTurn);
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
            this.Load += new System.EventHandler(this.FrmSixOfOne_Load);
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
        private System.Windows.Forms.Label lblTotalDiceRoll;
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
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label LblTurnOutcome;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxNewScore;
        private System.Windows.Forms.Label LblNewGame;
        private System.Windows.Forms.Label lblNewScore;
        private System.Windows.Forms.TextBox tbxTotalWins;
        private System.Windows.Forms.Label LblTotalWins;
    }
}