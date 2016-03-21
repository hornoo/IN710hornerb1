namespace MonsterFactory
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
            this.pbhead = new System.Windows.Forms.PictureBox();
            this.pbbody = new System.Windows.Forms.PictureBox();
            this.pbLegs = new System.Windows.Forms.PictureBox();
            this.cbhead = new System.Windows.Forms.ComboBox();
            this.cbbody = new System.Windows.Forms.ComboBox();
            this.cblegs = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbhead)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbhead
            // 
            this.pbhead.Location = new System.Drawing.Point(61, 43);
            this.pbhead.Name = "pbhead";
            this.pbhead.Size = new System.Drawing.Size(150, 150);
            this.pbhead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbhead.TabIndex = 0;
            this.pbhead.TabStop = false;
            // 
            // pbbody
            // 
            this.pbbody.Location = new System.Drawing.Point(61, 190);
            this.pbbody.Name = "pbbody";
            this.pbbody.Size = new System.Drawing.Size(150, 150);
            this.pbbody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbbody.TabIndex = 1;
            this.pbbody.TabStop = false;
            // 
            // pbLegs
            // 
            this.pbLegs.Location = new System.Drawing.Point(61, 336);
            this.pbLegs.Name = "pbLegs";
            this.pbLegs.Size = new System.Drawing.Size(150, 150);
            this.pbLegs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLegs.TabIndex = 2;
            this.pbLegs.TabStop = false;
            this.pbLegs.Click += new System.EventHandler(this.pbLegs_Click);
            // 
            // cbhead
            // 
            this.cbhead.FormattingEnabled = true;
            this.cbhead.Location = new System.Drawing.Point(331, 43);
            this.cbhead.Name = "cbhead";
            this.cbhead.Size = new System.Drawing.Size(146, 21);
            this.cbhead.TabIndex = 3;
            // 
            // cbbody
            // 
            this.cbbody.FormattingEnabled = true;
            this.cbbody.Location = new System.Drawing.Point(331, 107);
            this.cbbody.Name = "cbbody";
            this.cbbody.Size = new System.Drawing.Size(146, 21);
            this.cbbody.TabIndex = 4;
            // 
            // cblegs
            // 
            this.cblegs.FormattingEnabled = true;
            this.cblegs.Location = new System.Drawing.Point(331, 172);
            this.cblegs.Name = "cblegs";
            this.cblegs.Size = new System.Drawing.Size(146, 21);
            this.cblegs.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(331, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Make Monster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cblegs);
            this.Controls.Add(this.cbbody);
            this.Controls.Add(this.cbhead);
            this.Controls.Add(this.pbLegs);
            this.Controls.Add(this.pbbody);
            this.Controls.Add(this.pbhead);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbhead)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbbody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLegs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbhead;
        private System.Windows.Forms.PictureBox pbbody;
        private System.Windows.Forms.PictureBox pbLegs;
        private System.Windows.Forms.ComboBox cbhead;
        private System.Windows.Forms.ComboBox cbbody;
        private System.Windows.Forms.ComboBox cblegs;
        private System.Windows.Forms.Button button1;
    }
}

