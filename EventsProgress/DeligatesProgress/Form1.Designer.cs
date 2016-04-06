namespace EventsProgress
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
            this.components = new System.ComponentModel.Container();
            this.UD1 = new System.Windows.Forms.NumericUpDown();
            this.PB1 = new System.Windows.Forms.ProgressBar();
            this.TB1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB1)).BeginInit();
            this.SuspendLayout();
            // 
            // UD1
            // 
            this.UD1.Location = new System.Drawing.Point(203, 80);
            this.UD1.Name = "UD1";
            this.UD1.Size = new System.Drawing.Size(270, 20);
            this.UD1.TabIndex = 1;
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(203, 119);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(421, 23);
            this.PB1.TabIndex = 2;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(203, 165);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(421, 45);
            this.TB1.TabIndex = 3;
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(44, 35);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 4;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 240);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.PB1);
            this.Controls.Add(this.UD1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown UD1;
        private System.Windows.Forms.ProgressBar PB1;
        private System.Windows.Forms.TrackBar TB1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStart;
    }
}

