namespace UnitTestProject1
{
    partial class TestForm1
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
            this.Testlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Testlabel1
            // 
            this.Testlabel1.AutoSize = true;
            this.Testlabel1.Location = new System.Drawing.Point(101, 121);
            this.Testlabel1.Name = "Testlabel1";
            this.Testlabel1.Size = new System.Drawing.Size(35, 13);
            this.Testlabel1.TabIndex = 0;
            this.Testlabel1.Text = "label1";
            this.Testlabel1.Click += new System.EventHandler(this.Testlabel1_Click);
            // 
            // TestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Testlabel1);
            this.Name = "TestForm1";
            this.Text = "TestForm1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Testlabel1;
    }
}