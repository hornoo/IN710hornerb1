namespace WindowsFormsApplication1
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
            this.rbGame = new System.Windows.Forms.RadioButton();
            this.rbBus = new System.Windows.Forms.RadioButton();
            this.rbMultilM = new System.Windows.Forms.RadioButton();
            this.btPritnSpeck = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.rbLaptop = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLaptop);
            this.groupBox1.Controls.Add(this.rbMultilM);
            this.groupBox1.Controls.Add(this.rbBus);
            this.groupBox1.Controls.Add(this.rbGame);
            this.groupBox1.Location = new System.Drawing.Point(60, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(120, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machine Type";
            // 
            // rbGame
            // 
            this.rbGame.AutoSize = true;
            this.rbGame.Location = new System.Drawing.Point(16, 34);
            this.rbGame.Name = "rbGame";
            this.rbGame.Size = new System.Drawing.Size(61, 17);
            this.rbGame.TabIndex = 0;
            this.rbGame.TabStop = true;
            this.rbGame.Text = "Gaming";
            this.rbGame.UseVisualStyleBackColor = true;
            // 
            // rbBus
            // 
            this.rbBus.AutoSize = true;
            this.rbBus.Location = new System.Drawing.Point(16, 57);
            this.rbBus.Name = "rbBus";
            this.rbBus.Size = new System.Drawing.Size(67, 17);
            this.rbBus.TabIndex = 1;
            this.rbBus.TabStop = true;
            this.rbBus.Text = "Business";
            this.rbBus.UseVisualStyleBackColor = true;
            // 
            // rbMultilM
            // 
            this.rbMultilM.AutoSize = true;
            this.rbMultilM.Location = new System.Drawing.Point(16, 80);
            this.rbMultilM.Name = "rbMultilM";
            this.rbMultilM.Size = new System.Drawing.Size(75, 17);
            this.rbMultilM.TabIndex = 2;
            this.rbMultilM.TabStop = true;
            this.rbMultilM.Text = "Multimedia";
            this.rbMultilM.UseVisualStyleBackColor = true;
            // 
            // btPritnSpeck
            // 
            this.btPritnSpeck.Location = new System.Drawing.Point(60, 54);
            this.btPritnSpeck.Name = "btPritnSpeck";
            this.btPritnSpeck.Size = new System.Drawing.Size(120, 23);
            this.btPritnSpeck.TabIndex = 1;
            this.btPritnSpeck.Text = "Print Spec";
            this.btPritnSpeck.UseVisualStyleBackColor = true;
            this.btPritnSpeck.Click += new System.EventHandler(this.btPritnSpeck_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(217, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(352, 173);
            this.listBox1.TabIndex = 2;
            // 
            // rbLaptop
            // 
            this.rbLaptop.AutoSize = true;
            this.rbLaptop.Location = new System.Drawing.Point(16, 100);
            this.rbLaptop.Name = "rbLaptop";
            this.rbLaptop.Size = new System.Drawing.Size(58, 17);
            this.rbLaptop.TabIndex = 3;
            this.rbLaptop.TabStop = true;
            this.rbLaptop.Text = "Laptop";
            this.rbLaptop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 305);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btPritnSpeck);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbMultilM;
        private System.Windows.Forms.RadioButton rbBus;
        private System.Windows.Forms.RadioButton rbGame;
        private System.Windows.Forms.Button btPritnSpeck;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RadioButton rbLaptop;
    }
}

