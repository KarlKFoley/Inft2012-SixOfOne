namespace KarlFoleyJamesMoon
{
    partial class frmRules
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
            this.lblRulesTitle = new System.Windows.Forms.Label();
            this.lblRuleOne = new System.Windows.Forms.Label();
            this.lblRuleTwo = new System.Windows.Forms.Label();
            this.lblRuleThree = new System.Windows.Forms.Label();
            this.lblRuleFour = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRulesTitle
            // 
            this.lblRulesTitle.AutoSize = true;
            this.lblRulesTitle.Location = new System.Drawing.Point(211, 13);
            this.lblRulesTitle.Name = "lblRulesTitle";
            this.lblRulesTitle.Size = new System.Drawing.Size(34, 13);
            this.lblRulesTitle.TabIndex = 0;
            this.lblRulesTitle.Text = "Rules";
            // 
            // lblRuleOne
            // 
            this.lblRuleOne.AutoSize = true;
            this.lblRuleOne.Location = new System.Drawing.Point(38, 44);
            this.lblRuleOne.Name = "lblRuleOne";
            this.lblRuleOne.Size = new System.Drawing.Size(261, 13);
            this.lblRuleOne.TabIndex = 1;
            this.lblRuleOne.Text = "Rule 1: If you roll one 1, you score no points your turn.";
            // 
            // lblRuleTwo
            // 
            this.lblRuleTwo.AutoSize = true;
            this.lblRuleTwo.Location = new System.Drawing.Point(38, 84);
            this.lblRuleTwo.Name = "lblRuleTwo";
            this.lblRuleTwo.Size = new System.Drawing.Size(229, 13);
            this.lblRuleTwo.TabIndex = 2;
            this.lblRuleTwo.Text = "Rule 2: If you roll two 1\'s, your points reset to 0.";
            // 
            // lblRuleThree
            // 
            this.lblRuleThree.AutoSize = true;
            this.lblRuleThree.Location = new System.Drawing.Point(38, 122);
            this.lblRuleThree.Name = "lblRuleThree";
            this.lblRuleThree.Size = new System.Drawing.Size(277, 13);
            this.lblRuleThree.TabIndex = 3;
            this.lblRuleThree.Text = "Rule 3: If you roll three 1\'s, your opponent wins the game.";
            // 
            // lblRuleFour
            // 
            this.lblRuleFour.AutoSize = true;
            this.lblRuleFour.Location = new System.Drawing.Point(38, 158);
            this.lblRuleFour.Name = "lblRuleFour";
            this.lblRuleFour.Size = new System.Drawing.Size(215, 13);
            this.lblRuleFour.TabIndex = 4;
            this.lblRuleFour.Text = "Rule 4: If you roll four 1\'s, you win the game!";
            // 
            // frmRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 221);
            this.Controls.Add(this.lblRuleFour);
            this.Controls.Add(this.lblRuleThree);
            this.Controls.Add(this.lblRuleTwo);
            this.Controls.Add(this.lblRuleOne);
            this.Controls.Add(this.lblRulesTitle);
            this.Name = "frmRules";
            this.Text = "Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRulesTitle;
        private System.Windows.Forms.Label lblRuleOne;
        private System.Windows.Forms.Label lblRuleTwo;
        private System.Windows.Forms.Label lblRuleThree;
        private System.Windows.Forms.Label lblRuleFour;
    }
}