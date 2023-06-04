namespace UI_Design
{
    partial class Ban_Student
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
            this.lbl_message = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ban = new System.Windows.Forms.DataGridViewButtonColumn();
            this.devicesTableAdapter1 = new UI_Design.Project_DatabaseDataSetTableAdapters.DEVICESTableAdapter();
            this.Ban_Timer = new System.Windows.Forms.Timer(this.components);
            this.child_pannel = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.Gridview_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_message
            // 
            this.lbl_message.AutoSize = true;
            this.lbl_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_message.Location = new System.Drawing.Point(13, 9);
            this.lbl_message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_message.Name = "lbl_message";
            this.lbl_message.Size = new System.Drawing.Size(143, 29);
            this.lbl_message.TabIndex = 0;
            this.lbl_message.Text = "Ban Student";
            this.lbl_message.Click += new System.EventHandler(this.lbl_message_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.Student_Name,
            this.Password,
            this.Ban});
            this.dataGridView1.Location = new System.Drawing.Point(18, 40);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(626, 135);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student ID";
            this.Student_ID.MinimumWidth = 8;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.ReadOnly = true;
            this.Student_ID.Width = 150;
            // 
            // Student_Name
            // 
            this.Student_Name.HeaderText = "Student Name";
            this.Student_Name.MinimumWidth = 8;
            this.Student_Name.Name = "Student_Name";
            this.Student_Name.ReadOnly = true;
            this.Student_Name.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 150;
            // 
            // Ban
            // 
            this.Ban.HeaderText = "Ban";
            this.Ban.MinimumWidth = 8;
            this.Ban.Name = "Ban";
            this.Ban.ReadOnly = true;
            this.Ban.Width = 150;
            // 
            // devicesTableAdapter1
            // 
            this.devicesTableAdapter1.ClearBeforeFill = true;
            // 
            // Ban_Timer
            // 
            this.Ban_Timer.Interval = 100000;
            this.Ban_Timer.Tick += new System.EventHandler(this.Ban_Timer_Tick);
            // 
            // child_pannel
            // 
            this.child_pannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.child_pannel.Location = new System.Drawing.Point(0, 178);
            this.child_pannel.Name = "child_pannel";
            this.child_pannel.Size = new System.Drawing.Size(661, 325);
            this.child_pannel.TabIndex = 5;
            this.child_pannel.Paint += new System.Windows.Forms.PaintEventHandler(this.child_pannel_Paint);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(562, 5);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 33);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Gridview_Timer
            // 
            this.Gridview_Timer.Interval = 10000000;
            // 
            // Ban_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.child_pannel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_message);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ban_Student";
            this.Text = "Ban_Student";
            this.Load += new System.EventHandler(this.Ban_Student_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_message;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Ban;
        private Project_DatabaseDataSetTableAdapters.DEVICESTableAdapter devicesTableAdapter1;
        private System.Windows.Forms.Timer Ban_Timer;
        private System.Windows.Forms.Panel child_pannel;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Timer Gridview_Timer;
    }
}