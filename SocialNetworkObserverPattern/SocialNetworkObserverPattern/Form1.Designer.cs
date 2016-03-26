namespace SocialNetworkObserverPattern
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
            this.TabBox = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbMain = new System.Windows.Forms.ListBox();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.btInput = new System.Windows.Forms.Button();
            this.lbf1 = new System.Windows.Forms.ListBox();
            this.lbf2 = new System.Windows.Forms.ListBox();
            this.lbf3 = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbf4 = new System.Windows.Forms.ListBox();
            this.TabBox.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabBox
            // 
            this.TabBox.Controls.Add(this.tabPage1);
            this.TabBox.Controls.Add(this.tabPage2);
            this.TabBox.Controls.Add(this.tabPage3);
            this.TabBox.Controls.Add(this.tabPage4);
            this.TabBox.Controls.Add(this.tabPage5);
            this.TabBox.Location = new System.Drawing.Point(12, 12);
            this.TabBox.Name = "TabBox";
            this.TabBox.SelectedIndex = 0;
            this.TabBox.Size = new System.Drawing.Size(465, 392);
            this.TabBox.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btInput);
            this.tabPage1.Controls.Add(this.tbInput);
            this.tabPage1.Controls.Add(this.lbMain);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(457, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbf1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(457, 366);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Friend 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lbf2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(457, 366);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Friend 2";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lbf3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(457, 366);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Friend 3";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lbMain
            // 
            this.lbMain.FormattingEnabled = true;
            this.lbMain.Location = new System.Drawing.Point(6, 6);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(445, 303);
            this.lbMain.TabIndex = 0;
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(104, 328);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(347, 20);
            this.tbInput.TabIndex = 1;
            // 
            // btInput
            // 
            this.btInput.Location = new System.Drawing.Point(6, 326);
            this.btInput.Name = "btInput";
            this.btInput.Size = new System.Drawing.Size(92, 23);
            this.btInput.TabIndex = 1;
            this.btInput.Text = "Update Status";
            this.btInput.UseVisualStyleBackColor = true;
            this.btInput.Click += new System.EventHandler(this.btInput_Click);
            // 
            // lbf1
            // 
            this.lbf1.FormattingEnabled = true;
            this.lbf1.Location = new System.Drawing.Point(6, 6);
            this.lbf1.Name = "lbf1";
            this.lbf1.Size = new System.Drawing.Size(445, 303);
            this.lbf1.TabIndex = 1;
            // 
            // lbf2
            // 
            this.lbf2.FormattingEnabled = true;
            this.lbf2.Location = new System.Drawing.Point(6, 6);
            this.lbf2.Name = "lbf2";
            this.lbf2.Size = new System.Drawing.Size(445, 303);
            this.lbf2.TabIndex = 1;
            // 
            // lbf3
            // 
            this.lbf3.FormattingEnabled = true;
            this.lbf3.Location = new System.Drawing.Point(6, 6);
            this.lbf3.Name = "lbf3";
            this.lbf3.Size = new System.Drawing.Size(445, 303);
            this.lbf3.TabIndex = 1;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.lbf4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(457, 366);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Friend 4";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // lbf4
            // 
            this.lbf4.FormattingEnabled = true;
            this.lbf4.Location = new System.Drawing.Point(6, 6);
            this.lbf4.Name = "lbf4";
            this.lbf4.Size = new System.Drawing.Size(445, 303);
            this.lbf4.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 416);
            this.Controls.Add(this.TabBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TabBox.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabBox;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btInput;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ListBox lbMain;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbf1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lbf2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListBox lbf3;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ListBox lbf4;
    }
}

