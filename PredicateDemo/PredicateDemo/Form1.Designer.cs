namespace PredicateDemo
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
            this.btGenNum = new System.Windows.Forms.Button();
            this.lbGen = new System.Windows.Forms.ListBox();
            this.lbOutPut = new System.Windows.Forms.ListBox();
            this.btEven = new System.Windows.Forms.Button();
            this.btLessThan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGenNum
            // 
            this.btGenNum.Location = new System.Drawing.Point(29, 39);
            this.btGenNum.Name = "btGenNum";
            this.btGenNum.Size = new System.Drawing.Size(123, 49);
            this.btGenNum.TabIndex = 0;
            this.btGenNum.Text = "Generate Numbers";
            this.btGenNum.UseVisualStyleBackColor = true;
            this.btGenNum.Click += new System.EventHandler(this.btGenNum_Click);
            // 
            // lbGen
            // 
            this.lbGen.FormattingEnabled = true;
            this.lbGen.Location = new System.Drawing.Point(32, 114);
            this.lbGen.Name = "lbGen";
            this.lbGen.Size = new System.Drawing.Size(120, 316);
            this.lbGen.TabIndex = 1;
            // 
            // lbOutPut
            // 
            this.lbOutPut.FormattingEnabled = true;
            this.lbOutPut.Location = new System.Drawing.Point(211, 153);
            this.lbOutPut.Name = "lbOutPut";
            this.lbOutPut.Size = new System.Drawing.Size(120, 277);
            this.lbOutPut.TabIndex = 2;
            // 
            // btEven
            // 
            this.btEven.Location = new System.Drawing.Point(208, 39);
            this.btEven.Name = "btEven";
            this.btEven.Size = new System.Drawing.Size(123, 49);
            this.btEven.TabIndex = 3;
            this.btEven.Text = "Even Numbers";
            this.btEven.UseVisualStyleBackColor = true;
            this.btEven.Click += new System.EventHandler(this.btEven_Click);
            // 
            // btLessThan
            // 
            this.btLessThan.Location = new System.Drawing.Point(211, 94);
            this.btLessThan.Name = "btLessThan";
            this.btLessThan.Size = new System.Drawing.Size(123, 49);
            this.btLessThan.TabIndex = 4;
            this.btLessThan.Text = "Numbers < 10";
            this.btLessThan.UseVisualStyleBackColor = true;
            this.btLessThan.Click += new System.EventHandler(this.btLessThan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 461);
            this.Controls.Add(this.btLessThan);
            this.Controls.Add(this.btEven);
            this.Controls.Add(this.lbOutPut);
            this.Controls.Add(this.lbGen);
            this.Controls.Add(this.btGenNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGenNum;
        private System.Windows.Forms.ListBox lbGen;
        private System.Windows.Forms.ListBox lbOutPut;
        private System.Windows.Forms.Button btEven;
        private System.Windows.Forms.Button btLessThan;
    }
}

