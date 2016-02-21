namespace WindowsFormsApplication2
{
    partial class Form1
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
            this.dealButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.topScoreTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.playerScoreList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dealButton
            // 
            this.dealButton.Location = new System.Drawing.Point(47, 52);
            this.dealButton.Name = "dealButton";
            this.dealButton.Size = new System.Drawing.Size(75, 23);
            this.dealButton.TabIndex = 0;
            this.dealButton.Text = "Deal";
            this.dealButton.UseVisualStyleBackColor = true;
            this.dealButton.Click += new System.EventHandler(this.dealButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(47, 491);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // scoreListBox
            // 
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.Location = new System.Drawing.Point(221, 52);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(136, 459);
            this.scoreListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top Scoring Player";
            // 
            // topScoreTextBox
            // 
            this.topScoreTextBox.Location = new System.Drawing.Point(47, 119);
            this.topScoreTextBox.Name = "topScoreTextBox";
            this.topScoreTextBox.Size = new System.Drawing.Size(94, 20);
            this.topScoreTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Player Scores";
            // 
            // playerScoreList
            // 
            this.playerScoreList.FormattingEnabled = true;
            this.playerScoreList.Location = new System.Drawing.Point(47, 212);
            this.playerScoreList.Name = "playerScoreList";
            this.playerScoreList.Size = new System.Drawing.Size(94, 82);
            this.playerScoreList.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 550);
            this.Controls.Add(this.playerScoreList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.topScoreTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreListBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.dealButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dealButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox topScoreTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox playerScoreList;

    }
}

