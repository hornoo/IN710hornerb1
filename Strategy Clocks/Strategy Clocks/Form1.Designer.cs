namespace Strategy_Clocks
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
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDigital = new System.Windows.Forms.RadioButton();
            this.rdAnalogue = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(80, 179);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(150, 150);
            this.analogClock1.TabIndex = 0;
            this.analogClock1.TicksColor = System.Drawing.Color.Black;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDigital);
            this.groupBox1.Controls.Add(this.rdAnalogue);
            this.groupBox1.Location = new System.Drawing.Point(170, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // rdDigital
            // 
            this.rdDigital.AutoSize = true;
            this.rdDigital.Location = new System.Drawing.Point(7, 44);
            this.rdDigital.Name = "rdDigital";
            this.rdDigital.Size = new System.Drawing.Size(54, 17);
            this.rdDigital.TabIndex = 1;
            this.rdDigital.TabStop = true;
            this.rdDigital.Text = "Digital";
            this.rdDigital.UseVisualStyleBackColor = true;
            this.rdDigital.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdAnalogue
            // 
            this.rdAnalogue.AutoSize = true;
            this.rdAnalogue.Location = new System.Drawing.Point(7, 20);
            this.rdAnalogue.Name = "rdAnalogue";
            this.rdAnalogue.Size = new System.Drawing.Size(70, 17);
            this.rdAnalogue.TabIndex = 0;
            this.rdAnalogue.TabStop = true;
            this.rdAnalogue.Text = "Analogue";
            this.rdAnalogue.UseVisualStyleBackColor = true;
            this.rdAnalogue.CheckedChanged += new System.EventHandler(this.rdAnalogue_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 360);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDigital;
        private System.Windows.Forms.RadioButton rdAnalogue;
    }
}

