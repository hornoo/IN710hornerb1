namespace ABOPracticalDataViewer
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
            this.btdbConnect = new System.Windows.Forms.Button();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbuser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbConnectStatus = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.blListAllPTandE = new System.Windows.Forms.Button();
            this.atAsDue2week = new System.Windows.Forms.Button();
            this.btAveMark = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btdbConnect
            // 
            this.btdbConnect.Location = new System.Drawing.Point(77, 108);
            this.btdbConnect.Name = "btdbConnect";
            this.btdbConnect.Size = new System.Drawing.Size(100, 23);
            this.btdbConnect.TabIndex = 0;
            this.btdbConnect.Text = "Connect to DB";
            this.btdbConnect.UseVisualStyleBackColor = true;
            this.btdbConnect.Click += new System.EventHandler(this.btdbConnect_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(77, 39);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(100, 20);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "hornerb1";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(77, 65);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(100, 20);
            this.tbPassword.TabIndex = 2;
            // 
            // lbuser
            // 
            this.lbuser.AutoSize = true;
            this.lbuser.Location = new System.Drawing.Point(16, 42);
            this.lbuser.Name = "lbuser";
            this.lbuser.Size = new System.Drawing.Size(55, 13);
            this.lbuser.TabIndex = 3;
            this.lbuser.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Password";
            // 
            // lbConnectStatus
            // 
            this.lbConnectStatus.AutoSize = true;
            this.lbConnectStatus.Location = new System.Drawing.Point(74, 88);
            this.lbConnectStatus.Name = "lbConnectStatus";
            this.lbConnectStatus.Size = new System.Drawing.Size(79, 13);
            this.lbConnectStatus.TabIndex = 5;
            this.lbConnectStatus.Text = "Not Connected";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 233);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.SetInputDataFromDGV);
            // 
            // blListAllPTandE
            // 
            this.blListAllPTandE.Enabled = false;
            this.blListAllPTandE.Location = new System.Drawing.Point(19, 162);
            this.blListAllPTandE.Name = "blListAllPTandE";
            this.blListAllPTandE.Size = new System.Drawing.Size(158, 23);
            this.blListAllPTandE.TabIndex = 7;
            this.blListAllPTandE.Text = "Papers and Tutors";
            this.blListAllPTandE.UseVisualStyleBackColor = true;
            this.blListAllPTandE.Click += new System.EventHandler(this.blListAllPTandE_Click);
            // 
            // atAsDue2week
            // 
            this.atAsDue2week.Enabled = false;
            this.atAsDue2week.Location = new System.Drawing.Point(19, 191);
            this.atAsDue2week.Name = "atAsDue2week";
            this.atAsDue2week.Size = new System.Drawing.Size(158, 23);
            this.atAsDue2week.TabIndex = 8;
            this.atAsDue2week.Text = "Assignments due in 2 weeks";
            this.atAsDue2week.UseVisualStyleBackColor = true;
            this.atAsDue2week.Click += new System.EventHandler(this.atAsDue2week_Click);
            // 
            // btAveMark
            // 
            this.btAveMark.Enabled = false;
            this.btAveMark.Location = new System.Drawing.Point(19, 220);
            this.btAveMark.Name = "btAveMark";
            this.btAveMark.Size = new System.Drawing.Size(158, 23);
            this.btAveMark.TabIndex = 9;
            this.btAveMark.Text = "Average Mark in paper";
            this.btAveMark.UseVisualStyleBackColor = true;
            this.btAveMark.Click += new System.EventHandler(this.btAveMark_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(19, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Show All Assignments";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 292);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btAveMark);
            this.Controls.Add(this.atAsDue2week);
            this.Controls.Add(this.blListAllPTandE);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbConnectStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbuser);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btdbConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btdbConnect;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbuser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbConnectStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button blListAllPTandE;
        private System.Windows.Forms.Button atAsDue2week;
        private System.Windows.Forms.Button btAveMark;
        private System.Windows.Forms.Button button1;
    }
}

