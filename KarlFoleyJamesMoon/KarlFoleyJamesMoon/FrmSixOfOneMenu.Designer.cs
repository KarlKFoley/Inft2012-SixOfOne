namespace KarlFoleyJamesMoon
{
    partial class FrmSixOfOneMenu
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
            this.LblSetup = new System.Windows.Forms.Label();
            this.GboxPlayers = new System.Windows.Forms.GroupBox();
            this.RadButPlayerTwo = new System.Windows.Forms.RadioButton();
            this.RadButPlayersOne = new System.Windows.Forms.RadioButton();
            this.LblPlayerOne = new System.Windows.Forms.Label();
            this.TbxPlayerOne = new System.Windows.Forms.TextBox();
            this.TbxPlayerTwo = new System.Windows.Forms.TextBox();
            this.LblPlayerTwo = new System.Windows.Forms.Label();
            this.BtnPlay = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.TbxRules = new System.Windows.Forms.TextBox();
            this.LblPlayToScore = new System.Windows.Forms.Label();
            this.TbxPlayToScore = new System.Windows.Forms.TextBox();
            this.GboxPlayers.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblSetup
            // 
            this.LblSetup.AutoSize = true;
            this.LblSetup.Location = new System.Drawing.Point(13, 13);
            this.LblSetup.Name = "LblSetup";
            this.LblSetup.Size = new System.Drawing.Size(87, 13);
            this.LblSetup.TabIndex = 0;
            this.LblSetup.Text = "Six of One Setup";
            // 
            // GboxPlayers
            // 
            this.GboxPlayers.Controls.Add(this.RadButPlayerTwo);
            this.GboxPlayers.Controls.Add(this.RadButPlayersOne);
            this.GboxPlayers.Location = new System.Drawing.Point(16, 41);
            this.GboxPlayers.Name = "GboxPlayers";
            this.GboxPlayers.Size = new System.Drawing.Size(177, 55);
            this.GboxPlayers.TabIndex = 1;
            this.GboxPlayers.TabStop = false;
            this.GboxPlayers.Text = "Players";
            // 
            // RadButPlayerTwo
            // 
            this.RadButPlayerTwo.AutoSize = true;
            this.RadButPlayerTwo.Location = new System.Drawing.Point(88, 19);
            this.RadButPlayerTwo.Name = "RadButPlayerTwo";
            this.RadButPlayerTwo.Size = new System.Drawing.Size(83, 17);
            this.RadButPlayerTwo.TabIndex = 1;
            this.RadButPlayerTwo.TabStop = true;
            this.RadButPlayerTwo.Text = "Two Players";
            this.RadButPlayerTwo.UseVisualStyleBackColor = true;
            // 
            // RadButPlayersOne
            // 
            this.RadButPlayersOne.AutoSize = true;
            this.RadButPlayersOne.Checked = true;
            this.RadButPlayersOne.Location = new System.Drawing.Point(7, 20);
            this.RadButPlayersOne.Name = "RadButPlayersOne";
            this.RadButPlayersOne.Size = new System.Drawing.Size(77, 17);
            this.RadButPlayersOne.TabIndex = 0;
            this.RadButPlayersOne.TabStop = true;
            this.RadButPlayersOne.Text = "One Player";
            this.RadButPlayersOne.UseVisualStyleBackColor = true;
            this.RadButPlayersOne.CheckedChanged += new System.EventHandler(this.RadButPlayersOne_CheckedChanged);
            // 
            // LblPlayerOne
            // 
            this.LblPlayerOne.AutoSize = true;
            this.LblPlayerOne.Location = new System.Drawing.Point(16, 103);
            this.LblPlayerOne.Name = "LblPlayerOne";
            this.LblPlayerOne.Size = new System.Drawing.Size(67, 13);
            this.LblPlayerOne.TabIndex = 2;
            this.LblPlayerOne.Text = "Player Name";
            // 
            // TbxPlayerOne
            // 
            this.TbxPlayerOne.Location = new System.Drawing.Point(19, 120);
            this.TbxPlayerOne.Name = "TbxPlayerOne";
            this.TbxPlayerOne.Size = new System.Drawing.Size(100, 20);
            this.TbxPlayerOne.TabIndex = 3;
            // 
            // TbxPlayerTwo
            // 
            this.TbxPlayerTwo.Location = new System.Drawing.Point(19, 168);
            this.TbxPlayerTwo.Name = "TbxPlayerTwo";
            this.TbxPlayerTwo.Size = new System.Drawing.Size(100, 20);
            this.TbxPlayerTwo.TabIndex = 5;
            this.TbxPlayerTwo.Visible = false;
            // 
            // LblPlayerTwo
            // 
            this.LblPlayerTwo.AutoSize = true;
            this.LblPlayerTwo.Location = new System.Drawing.Point(16, 151);
            this.LblPlayerTwo.Name = "LblPlayerTwo";
            this.LblPlayerTwo.Size = new System.Drawing.Size(91, 13);
            this.LblPlayerTwo.TabIndex = 4;
            this.LblPlayerTwo.Text = "Player Two Name";
            this.LblPlayerTwo.Visible = false;
            // 
            // BtnPlay
            // 
            this.BtnPlay.Location = new System.Drawing.Point(118, 209);
            this.BtnPlay.Name = "BtnPlay";
            this.BtnPlay.Size = new System.Drawing.Size(75, 23);
            this.BtnPlay.TabIndex = 6;
            this.BtnPlay.Text = "Play!";
            this.BtnPlay.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(221, 209);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 7;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // TbxRules
            // 
            this.TbxRules.BackColor = System.Drawing.SystemColors.Control;
            this.TbxRules.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbxRules.Location = new System.Drawing.Point(36, 257);
            this.TbxRules.Name = "TbxRules";
            this.TbxRules.Size = new System.Drawing.Size(317, 13);
            this.TbxRules.TabIndex = 8;
            // 
            // LblPlayToScore
            // 
            this.LblPlayToScore.AutoSize = true;
            this.LblPlayToScore.Location = new System.Drawing.Point(255, 103);
            this.LblPlayToScore.Name = "LblPlayToScore";
            this.LblPlayToScore.Size = new System.Drawing.Size(70, 13);
            this.LblPlayToScore.TabIndex = 9;
            this.LblPlayToScore.Text = "Play to Score";
            // 
            // TbxPlayToScore
            // 
            this.TbxPlayToScore.Location = new System.Drawing.Point(258, 119);
            this.TbxPlayToScore.Name = "TbxPlayToScore";
            this.TbxPlayToScore.Size = new System.Drawing.Size(100, 20);
            this.TbxPlayToScore.TabIndex = 0;
            // 
            // FrmSixOfOneMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 337);
            this.Controls.Add(this.TbxPlayToScore);
            this.Controls.Add(this.LblPlayToScore);
            this.Controls.Add(this.TbxRules);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BtnPlay);
            this.Controls.Add(this.TbxPlayerTwo);
            this.Controls.Add(this.LblPlayerTwo);
            this.Controls.Add(this.TbxPlayerOne);
            this.Controls.Add(this.LblPlayerOne);
            this.Controls.Add(this.GboxPlayers);
            this.Controls.Add(this.LblSetup);
            this.Name = "FrmSixOfOneMenu";
            this.Text = "Six Of One Menu";
            this.GboxPlayers.ResumeLayout(false);
            this.GboxPlayers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSetup;
        private System.Windows.Forms.GroupBox GboxPlayers;
        private System.Windows.Forms.RadioButton RadButPlayerTwo;
        private System.Windows.Forms.RadioButton RadButPlayersOne;
        private System.Windows.Forms.Label LblPlayerOne;
        private System.Windows.Forms.TextBox TbxPlayerOne;
        private System.Windows.Forms.TextBox TbxPlayerTwo;
        private System.Windows.Forms.Label LblPlayerTwo;
        private System.Windows.Forms.Button BtnPlay;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.TextBox TbxRules;
        private System.Windows.Forms.Label LblPlayToScore;
        private System.Windows.Forms.TextBox TbxPlayToScore;
    }
}

