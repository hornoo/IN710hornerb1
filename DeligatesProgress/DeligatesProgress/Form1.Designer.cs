namespace DeligatesProgress
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSpinBox = new System.Windows.Forms.RadioButton();
            this.rbProgressBar = new System.Windows.Forms.RadioButton();
            this.rbTrackBar = new System.Windows.Forms.RadioButton();
            this.UD1 = new System.Windows.Forms.NumericUpDown();
            this.PB1 = new System.Windows.Forms.ProgressBar();
            this.TB1 = new System.Windows.Forms.TrackBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btStart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UD1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbTrackBar);
            this.groupBox1.Controls.Add(this.rbProgressBar);
            this.groupBox1.Controls.Add(this.rbSpinBox);
            this.groupBox1.Location = new System.Drawing.Point(44, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Progress Bar";
            // 
            // rbSpinBox
            // 
            this.rbSpinBox.AutoSize = true;
            this.rbSpinBox.Location = new System.Drawing.Point(24, 39);
            this.rbSpinBox.Name = "rbSpinBox";
            this.rbSpinBox.Size = new System.Drawing.Size(67, 17);
            this.rbSpinBox.TabIndex = 1;
            this.rbSpinBox.TabStop = true;
            this.rbSpinBox.Text = "Spin Box";
            this.rbSpinBox.UseVisualStyleBackColor = true;
            // 
            // rbProgressBar
            // 
            this.rbProgressBar.AutoSize = true;
            this.rbProgressBar.Location = new System.Drawing.Point(24, 62);
            this.rbProgressBar.Name = "rbProgressBar";
            this.rbProgressBar.Size = new System.Drawing.Size(85, 17);
            this.rbProgressBar.TabIndex = 1;
            this.rbProgressBar.TabStop = true;
            this.rbProgressBar.Text = "Progress Bar";
            this.rbProgressBar.UseVisualStyleBackColor = true;
            // 
            // rbTrackBar
            // 
            this.rbTrackBar.AutoSize = true;
            this.rbTrackBar.Location = new System.Drawing.Point(24, 85);
            this.rbTrackBar.Name = "rbTrackBar";
            this.rbTrackBar.Size = new System.Drawing.Size(72, 17);
            this.rbTrackBar.TabIndex = 1;
            this.rbTrackBar.TabStop = true;
            this.rbTrackBar.Text = "Track Bar";
            this.rbTrackBar.UseVisualStyleBackColor = true;
            // 
            // UD1
            // 
            this.UD1.Location = new System.Drawing.Point(353, 80);
            this.UD1.Name = "UD1";
            this.UD1.Size = new System.Drawing.Size(120, 20);
            this.UD1.TabIndex = 1;
            // 
            // PB1
            // 
            this.PB1.Location = new System.Drawing.Point(353, 119);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(271, 23);
            this.PB1.TabIndex = 2;
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(353, 165);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(271, 45);
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
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UD1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbTrackBar;
        private System.Windows.Forms.RadioButton rbProgressBar;
        private System.Windows.Forms.RadioButton rbSpinBox;
        private System.Windows.Forms.NumericUpDown UD1;
        private System.Windows.Forms.ProgressBar PB1;
        private System.Windows.Forms.TrackBar TB1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btStart;
    }
}

