namespace Encryption_practical
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
            this.rdRot13 = new System.Windows.Forms.RadioButton();
            this.rdReverseEn = new System.Windows.Forms.RadioButton();
            this.tbInPut = new System.Windows.Forms.TextBox();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButEncrypt = new System.Windows.Forms.Button();
            this.ButDecrypt = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdReverseEn);
            this.groupBox1.Controls.Add(this.rdRot13);
            this.groupBox1.Location = new System.Drawing.Point(78, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption Algorithm";
            // 
            // rdRot13
            // 
            this.rdRot13.AutoSize = true;
            this.rdRot13.Location = new System.Drawing.Point(6, 31);
            this.rdRot13.Name = "rdRot13";
            this.rdRot13.Size = new System.Drawing.Size(60, 17);
            this.rdRot13.TabIndex = 0;
            this.rdRot13.TabStop = true;
            this.rdRot13.Text = "ROT13";
            this.rdRot13.UseVisualStyleBackColor = true;
            // 
            // rdReverseEn
            // 
            this.rdReverseEn.AutoSize = true;
            this.rdReverseEn.Location = new System.Drawing.Point(6, 64);
            this.rdReverseEn.Name = "rdReverseEn";
            this.rdReverseEn.Size = new System.Drawing.Size(115, 17);
            this.rdReverseEn.TabIndex = 1;
            this.rdReverseEn.TabStop = true;
            this.rdReverseEn.Text = "ReverseEncryption";
            this.rdReverseEn.UseVisualStyleBackColor = true;
            // 
            // tbInPut
            // 
            this.tbInPut.Location = new System.Drawing.Point(120, 180);
            this.tbInPut.Name = "tbInPut";
            this.tbInPut.Size = new System.Drawing.Size(411, 20);
            this.tbInPut.TabIndex = 1;
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(120, 219);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.ReadOnly = true;
            this.tbOutput.Size = new System.Drawing.Size(411, 20);
            this.tbOutput.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output";
            // 
            // ButEncrypt
            // 
            this.ButEncrypt.Location = new System.Drawing.Point(319, 39);
            this.ButEncrypt.Name = "ButEncrypt";
            this.ButEncrypt.Size = new System.Drawing.Size(75, 23);
            this.ButEncrypt.TabIndex = 5;
            this.ButEncrypt.Text = "Encrypt";
            this.ButEncrypt.UseVisualStyleBackColor = true;
            this.ButEncrypt.Click += new System.EventHandler(this.ButEncrypt_Click);
            // 
            // ButDecrypt
            // 
            this.ButDecrypt.Location = new System.Drawing.Point(456, 39);
            this.ButDecrypt.Name = "ButDecrypt";
            this.ButDecrypt.Size = new System.Drawing.Size(75, 23);
            this.ButDecrypt.TabIndex = 6;
            this.ButDecrypt.Text = "Decrypt";
            this.ButDecrypt.UseVisualStyleBackColor = true;
            this.ButDecrypt.Click += new System.EventHandler(this.ButDecrypt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 299);
            this.Controls.Add(this.ButDecrypt);
            this.Controls.Add(this.ButEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.tbInPut);
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
        private System.Windows.Forms.RadioButton rdReverseEn;
        private System.Windows.Forms.RadioButton rdRot13;
        private System.Windows.Forms.TextBox tbInPut;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButEncrypt;
        private System.Windows.Forms.Button ButDecrypt;
    }
}

