namespace BicycleDashBoard
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
            this.btTrigger = new System.Windows.Forms.Button();
            this.tbspeed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRPM = new System.Windows.Forms.Label();
            this.lbCal = new System.Windows.Forms.Label();
            this.lbkmsh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btTrigger
            // 
            this.btTrigger.Location = new System.Drawing.Point(44, 40);
            this.btTrigger.Name = "btTrigger";
            this.btTrigger.Size = new System.Drawing.Size(75, 46);
            this.btTrigger.TabIndex = 0;
            this.btTrigger.Text = "Change Speed";
            this.btTrigger.UseVisualStyleBackColor = true;
            this.btTrigger.Click += new System.EventHandler(this.btTrigger_Click);
            // 
            // tbspeed
            // 
            this.tbspeed.Location = new System.Drawing.Point(159, 54);
            this.tbspeed.Name = "tbspeed";
            this.tbspeed.Size = new System.Drawing.Size(100, 20);
            this.tbspeed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RPM";
            // 
            // lbRPM
            // 
            this.lbRPM.AutoSize = true;
            this.lbRPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRPM.Location = new System.Drawing.Point(153, 167);
            this.lbRPM.Name = "lbRPM";
            this.lbRPM.Size = new System.Drawing.Size(71, 31);
            this.lbRPM.TabIndex = 3;
            this.lbRPM.Text = "label";
            // 
            // lbCal
            // 
            this.lbCal.AutoSize = true;
            this.lbCal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCal.Location = new System.Drawing.Point(153, 237);
            this.lbCal.Name = "lbCal";
            this.lbCal.Size = new System.Drawing.Size(71, 31);
            this.lbCal.TabIndex = 4;
            this.lbCal.Text = "label";
            // 
            // lbkmsh
            // 
            this.lbkmsh.AutoSize = true;
            this.lbkmsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkmsh.Location = new System.Drawing.Point(153, 314);
            this.lbkmsh.Name = "lbkmsh";
            this.lbkmsh.Size = new System.Drawing.Size(71, 31);
            this.lbkmsh.TabIndex = 5;
            this.lbkmsh.Text = "label";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Calories Per Hour";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kms Per Hour";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 418);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbkmsh);
            this.Controls.Add(this.lbCal);
            this.Controls.Add(this.lbRPM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbspeed);
            this.Controls.Add(this.btTrigger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btTrigger;
        private System.Windows.Forms.TextBox tbspeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbRPM;
        private System.Windows.Forms.Label lbCal;
        private System.Windows.Forms.Label lbkmsh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

