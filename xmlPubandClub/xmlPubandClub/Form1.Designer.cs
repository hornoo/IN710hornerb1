namespace xmlPubandClub
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvBandName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvVenue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btUpcoming = new System.Windows.Forms.Button();
            this.btHardRock = new System.Windows.Forms.Button();
            this.btThisMonth = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btSShakes = new System.Windows.Forms.Button();
            this.btAddGig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvBandName,
            this.dgvGenre,
            this.dgvVenue,
            this.dgvDate,
            this.dgvTime});
            this.dataGridView1.Location = new System.Drawing.Point(91, 151);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dgvBandName
            // 
            this.dgvBandName.HeaderText = "Band Name";
            this.dgvBandName.Name = "dgvBandName";
            this.dgvBandName.ReadOnly = true;
            // 
            // dgvGenre
            // 
            this.dgvGenre.HeaderText = "Genre";
            this.dgvGenre.Name = "dgvGenre";
            this.dgvGenre.ReadOnly = true;
            // 
            // dgvVenue
            // 
            this.dgvVenue.HeaderText = "Venue";
            this.dgvVenue.Name = "dgvVenue";
            this.dgvVenue.ReadOnly = true;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Date";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // dgvTime
            // 
            this.dgvTime.HeaderText = "Time";
            this.dgvTime.Name = "dgvTime";
            this.dgvTime.ReadOnly = true;
            // 
            // btUpcoming
            // 
            this.btUpcoming.Location = new System.Drawing.Point(91, 75);
            this.btUpcoming.Name = "btUpcoming";
            this.btUpcoming.Size = new System.Drawing.Size(116, 38);
            this.btUpcoming.TabIndex = 1;
            this.btUpcoming.Text = "Upcoming Gigs";
            this.btUpcoming.UseVisualStyleBackColor = true;
            this.btUpcoming.Click += new System.EventHandler(this.btUpcoming_Click);
            // 
            // btHardRock
            // 
            this.btHardRock.Location = new System.Drawing.Point(213, 75);
            this.btHardRock.Name = "btHardRock";
            this.btHardRock.Size = new System.Drawing.Size(116, 38);
            this.btHardRock.TabIndex = 3;
            this.btHardRock.Text = "HardRock Gigs";
            this.btHardRock.UseVisualStyleBackColor = true;
            this.btHardRock.Click += new System.EventHandler(this.btHardRock_Click);
            // 
            // btThisMonth
            // 
            this.btThisMonth.Location = new System.Drawing.Point(335, 75);
            this.btThisMonth.Name = "btThisMonth";
            this.btThisMonth.Size = new System.Drawing.Size(116, 38);
            this.btThisMonth.TabIndex = 4;
            this.btThisMonth.Text = "Gigs This Month";
            this.btThisMonth.UseVisualStyleBackColor = true;
            this.btThisMonth.Click += new System.EventHandler(this.btThisMonth_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(91, 385);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(545, 95);
            this.listBox1.TabIndex = 5;
            // 
            // btSShakes
            // 
            this.btSShakes.Location = new System.Drawing.Point(91, 341);
            this.btSShakes.Name = "btSShakes";
            this.btSShakes.Size = new System.Drawing.Size(116, 38);
            this.btSShakes.TabIndex = 6;
            this.btSShakes.Text = "Alabama Shakes";
            this.btSShakes.UseVisualStyleBackColor = true;
            this.btSShakes.Click += new System.EventHandler(this.btSShakes_Click);
            // 
            // btAddGig
            // 
            this.btAddGig.Location = new System.Drawing.Point(457, 75);
            this.btAddGig.Name = "btAddGig";
            this.btAddGig.Size = new System.Drawing.Size(116, 38);
            this.btAddGig.TabIndex = 7;
            this.btAddGig.Text = "Add Gig";
            this.btAddGig.UseVisualStyleBackColor = true;
            this.btAddGig.Click += new System.EventHandler(this.btAddGig_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 550);
            this.Controls.Add(this.btAddGig);
            this.Controls.Add(this.btSShakes);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btThisMonth);
            this.Controls.Add(this.btHardRock);
            this.Controls.Add(this.btUpcoming);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBandName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvVenue;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTime;
        private System.Windows.Forms.Button btUpcoming;
        private System.Windows.Forms.Button btHardRock;
        private System.Windows.Forms.Button btThisMonth;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btSShakes;
        private System.Windows.Forms.Button btAddGig;
    }
}

