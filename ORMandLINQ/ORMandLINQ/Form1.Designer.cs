namespace ORMandLINQ
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btAvIntenseAllStrikes = new System.Windows.Forms.Button();
            this.btLargestThreeFires = new System.Windows.Forms.Button();
            this.btPicInfo = new System.Windows.Forms.Button();
            this.btFirebyLightning = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(738, 212);
            this.listBox1.TabIndex = 0;
            // 
            // btAvIntenseAllStrikes
            // 
            this.btAvIntenseAllStrikes.Location = new System.Drawing.Point(29, 305);
            this.btAvIntenseAllStrikes.Name = "btAvIntenseAllStrikes";
            this.btAvIntenseAllStrikes.Size = new System.Drawing.Size(102, 50);
            this.btAvIntenseAllStrikes.TabIndex = 1;
            this.btAvIntenseAllStrikes.Text = "Average intensity for all strikes";
            this.btAvIntenseAllStrikes.UseVisualStyleBackColor = true;
            this.btAvIntenseAllStrikes.Click += new System.EventHandler(this.btAvIntenseAllStrikes_Click);
            // 
            // btLargestThreeFires
            // 
            this.btLargestThreeFires.Location = new System.Drawing.Point(137, 305);
            this.btLargestThreeFires.Name = "btLargestThreeFires";
            this.btLargestThreeFires.Size = new System.Drawing.Size(102, 50);
            this.btLargestThreeFires.TabIndex = 2;
            this.btLargestThreeFires.Text = "Largest 3 Fires";
            this.btLargestThreeFires.UseVisualStyleBackColor = true;
            this.btLargestThreeFires.Click += new System.EventHandler(this.btLargestThreeFires_Click);
            // 
            // btPicInfo
            // 
            this.btPicInfo.Location = new System.Drawing.Point(245, 305);
            this.btPicInfo.Name = "btPicInfo";
            this.btPicInfo.Size = new System.Drawing.Size(102, 50);
            this.btPicInfo.TabIndex = 3;
            this.btPicInfo.Text = "Picture Information";
            this.btPicInfo.UseVisualStyleBackColor = true;
            this.btPicInfo.Click += new System.EventHandler(this.btPicInfo_Click);
            // 
            // btFirebyLightning
            // 
            this.btFirebyLightning.Location = new System.Drawing.Point(353, 305);
            this.btFirebyLightning.Name = "btFirebyLightning";
            this.btFirebyLightning.Size = new System.Drawing.Size(102, 50);
            this.btFirebyLightning.TabIndex = 4;
            this.btFirebyLightning.Text = "Fires Caused by Lightning";
            this.btFirebyLightning.UseVisualStyleBackColor = true;
            this.btFirebyLightning.Click += new System.EventHandler(this.btFirebyLightning_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 367);
            this.Controls.Add(this.btFirebyLightning);
            this.Controls.Add(this.btPicInfo);
            this.Controls.Add(this.btLargestThreeFires);
            this.Controls.Add(this.btAvIntenseAllStrikes);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btAvIntenseAllStrikes;
        private System.Windows.Forms.Button btLargestThreeFires;
        private System.Windows.Forms.Button btPicInfo;
        private System.Windows.Forms.Button btFirebyLightning;

    }
}

