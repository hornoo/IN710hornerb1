﻿namespace Strategy_Clocks
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
            this.analogClock1 = new AnalogClockControl.AnalogClock();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDigital = new System.Windows.Forms.RadioButton();
            this.rdAnalogue = new System.Windows.Forms.RadioButton();
            this.btStart = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.lbDigital = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // analogClock1
            // 
            this.analogClock1.Draw1MinuteTicks = true;
            this.analogClock1.Draw5MinuteTicks = true;
            this.analogClock1.HourHandColor = System.Drawing.Color.DarkMagenta;
            this.analogClock1.Location = new System.Drawing.Point(33, 99);
            this.analogClock1.MinuteHandColor = System.Drawing.Color.Green;
            this.analogClock1.Name = "analogClock1";
            this.analogClock1.SecondHandColor = System.Drawing.Color.Red;
            this.analogClock1.Size = new System.Drawing.Size(249, 249);
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
            this.groupBox1.Text = "Select Clock";
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
            this.rdDigital.CheckedChanged += new System.EventHandler(this.rdDigital_CheckedChanged);
            // 
            // rdAnalogue
            // 
            this.rdAnalogue.AutoSize = true;
            this.rdAnalogue.Checked = true;
            this.rdAnalogue.Location = new System.Drawing.Point(7, 20);
            this.rdAnalogue.Name = "rdAnalogue";
            this.rdAnalogue.Size = new System.Drawing.Size(70, 17);
            this.rdAnalogue.TabIndex = 0;
            this.rdAnalogue.TabStop = true;
            this.rdAnalogue.Text = "Analogue";
            this.rdAnalogue.UseVisualStyleBackColor = true;
            this.rdAnalogue.CheckedChanged += new System.EventHandler(this.rdAnalogue_CheckedChanged);
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(42, 51);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 23);
            this.btStart.TabIndex = 2;
            this.btStart.Text = "Start Clock";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(42, 86);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 23);
            this.btStop.TabIndex = 3;
            this.btStop.Text = "Stop Clock";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // lbDigital
            // 
            this.lbDigital.AutoSize = true;
            this.lbDigital.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDigital.Location = new System.Drawing.Point(51, 192);
            this.lbDigital.Name = "lbDigital";
            this.lbDigital.Size = new System.Drawing.Size(212, 55);
            this.lbDigital.TabIndex = 4;
            this.lbDigital.Text = "00:00:00";
            this.lbDigital.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 360);
            this.Controls.Add(this.lbDigital);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.analogClock1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AnalogClockControl.AnalogClock analogClock1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDigital;
        private System.Windows.Forms.RadioButton rdAnalogue;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Label lbDigital;
        private System.Windows.Forms.Timer timer1;
    }
}

