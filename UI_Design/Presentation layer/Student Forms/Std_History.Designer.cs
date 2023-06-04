namespace UI_Design
{
    partial class Std_History
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
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Initial_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device_ID,
            this.Student_ID,
            this.Initial_Time,
            this.Final_Time,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(13, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(635, 238);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Device_ID
            // 
            this.Device_ID.HeaderText = "Device ID";
            this.Device_ID.MinimumWidth = 8;
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.ReadOnly = true;
            this.Device_ID.Width = 150;
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student ID";
            this.Student_ID.MinimumWidth = 8;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Width = 150;
            // 
            // Initial_Time
            // 
            this.Initial_Time.HeaderText = "Initial Time";
            this.Initial_Time.MinimumWidth = 8;
            this.Initial_Time.Name = "Initial_Time";
            this.Initial_Time.Width = 150;
            // 
            // Final_Time
            // 
            this.Final_Time.HeaderText = "Final Time";
            this.Final_Time.MinimumWidth = 8;
            this.Final_Time.Name = "Final_Time";
            this.Final_Time.ReadOnly = true;
            this.Final_Time.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.Image = global::UI_Design.Properties.Resources.history;
            this.pictureBox3.Location = new System.Drawing.Point(263, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(122, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // Std_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Std_History";
            this.Text = "Std_History";
            this.Load += new System.EventHandler(this.Std_History_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initial_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}