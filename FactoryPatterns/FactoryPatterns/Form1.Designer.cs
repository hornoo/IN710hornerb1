namespace FactoryPatterns
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
            this.btAuz = new System.Windows.Forms.Button();
            this.btUSA = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btAuz
            // 
            this.btAuz.Location = new System.Drawing.Point(252, 484);
            this.btAuz.Name = "btAuz";
            this.btAuz.Size = new System.Drawing.Size(151, 23);
            this.btAuz.TabIndex = 0;
            this.btAuz.Text = "Australia";
            this.btAuz.UseVisualStyleBackColor = true;
            this.btAuz.Click += new System.EventHandler(this.btAuz_Click);
            // 
            // btUSA
            // 
            this.btUSA.Location = new System.Drawing.Point(409, 484);
            this.btUSA.Name = "btUSA";
            this.btUSA.Size = new System.Drawing.Size(151, 23);
            this.btUSA.TabIndex = 1;
            this.btUSA.Text = "North America";
            this.btUSA.UseVisualStyleBackColor = true;
            this.btUSA.Click += new System.EventHandler(this.btUSA_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(252, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(308, 394);
            this.listBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 548);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btUSA);
            this.Controls.Add(this.btAuz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btAuz;
        private System.Windows.Forms.Button btUSA;
        private System.Windows.Forms.ListBox listBox1;
    }
}

