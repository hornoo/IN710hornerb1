namespace DelegateScorer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btScore = new System.Windows.Forms.Button();
            this.lbScore = new System.Windows.Forms.Label();
            this.rbadult = new System.Windows.Forms.RadioButton();
            this.rbchild = new System.Windows.Forms.RadioButton();
            this.tbcorrect = new System.Windows.Forms.TextBox();
            this.tbincorrect = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbchild);
            this.groupBox1.Controls.Add(this.rbadult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 166);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Team type";
            // 
            // btScore
            // 
            this.btScore.Location = new System.Drawing.Point(12, 184);
            this.btScore.Name = "btScore";
            this.btScore.Size = new System.Drawing.Size(198, 68);
            this.btScore.TabIndex = 1;
            this.btScore.Text = "Compute Score";
            this.btScore.UseVisualStyleBackColor = true;
            this.btScore.Click += new System.EventHandler(this.btScore_Click);
            // 
            // lbScore
            // 
            this.lbScore.AutoSize = true;
            this.lbScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore.Location = new System.Drawing.Point(309, 207);
            this.lbScore.Name = "lbScore";
            this.lbScore.Size = new System.Drawing.Size(19, 20);
            this.lbScore.TabIndex = 2;
            this.lbScore.Text = "0";
            // 
            // rbadult
            // 
            this.rbadult.AutoSize = true;
            this.rbadult.Location = new System.Drawing.Point(51, 46);
            this.rbadult.Name = "rbadult";
            this.rbadult.Size = new System.Drawing.Size(49, 17);
            this.rbadult.TabIndex = 3;
            this.rbadult.TabStop = true;
            this.rbadult.Text = "Adult";
            this.rbadult.UseVisualStyleBackColor = true;
            // 
            // rbchild
            // 
            this.rbchild.AutoSize = true;
            this.rbchild.Location = new System.Drawing.Point(51, 107);
            this.rbchild.Name = "rbchild";
            this.rbchild.Size = new System.Drawing.Size(48, 17);
            this.rbchild.TabIndex = 3;
            this.rbchild.TabStop = true;
            this.rbchild.Text = "Child";
            this.rbchild.UseVisualStyleBackColor = true;
            // 
            // tbcorrect
            // 
            this.tbcorrect.Location = new System.Drawing.Point(410, 55);
            this.tbcorrect.Name = "tbcorrect";
            this.tbcorrect.Size = new System.Drawing.Size(100, 20);
            this.tbcorrect.TabIndex = 3;
            this.tbcorrect.Text = "0";
            // 
            // tbincorrect
            // 
            this.tbincorrect.Location = new System.Drawing.Point(410, 120);
            this.tbincorrect.Name = "tbincorrect";
            this.tbincorrect.Size = new System.Drawing.Size(100, 20);
            this.tbincorrect.TabIndex = 4;
            this.tbincorrect.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Correct ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incorrect";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbincorrect);
            this.Controls.Add(this.tbcorrect);
            this.Controls.Add(this.lbScore);
            this.Controls.Add(this.btScore);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbchild;
        private System.Windows.Forms.RadioButton rbadult;
        private System.Windows.Forms.Button btScore;
        private System.Windows.Forms.Label lbScore;
        private System.Windows.Forms.TextBox tbcorrect;
        private System.Windows.Forms.TextBox tbincorrect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

