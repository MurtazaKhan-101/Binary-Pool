namespace UI_Design
{
    partial class Manage_Devices
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
            this.Device_Record = new System.Windows.Forms.DataGridView();
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_System = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change_Status = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Under_Maintainance = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Device_Timer = new System.Windows.Forms.Timer(this.components);
            this.btn_FreeAll = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Device_Record)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // Device_Record
            // 
            this.Device_Record.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Device_Record.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Device_Record.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Device_ID,
            this.OS_System,
            this.Status,
            this.Change_Status,
            this.Under_Maintainance});
            this.Device_Record.Location = new System.Drawing.Point(9, 149);
            this.Device_Record.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Device_Record.Name = "Device_Record";
            this.Device_Record.RowHeadersWidth = 62;
            this.Device_Record.Size = new System.Drawing.Size(639, 277);
            this.Device_Record.TabIndex = 5;
            this.Device_Record.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Device_Record_CellClick);
            this.Device_Record.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Device_Record_CellContentClick);
            // 
            // Device_ID
            // 
            this.Device_ID.HeaderText = "Device ID";
            this.Device_ID.MinimumWidth = 8;
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.Width = 150;
            // 
            // OS_System
            // 
            this.OS_System.HeaderText = "OS System";
            this.OS_System.MinimumWidth = 8;
            this.OS_System.Name = "OS_System";
            this.OS_System.Width = 150;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.Width = 150;
            // 
            // Change_Status
            // 
            this.Change_Status.HeaderText = "Change_Status";
            this.Change_Status.MinimumWidth = 8;
            this.Change_Status.Name = "Change_Status";
            this.Change_Status.Width = 150;
            // 
            // Under_Maintainance
            // 
            this.Under_Maintainance.HeaderText = "Under Maintainance";
            this.Under_Maintainance.MinimumWidth = 8;
            this.Under_Maintainance.Name = "Under_Maintainance";
            this.Under_Maintainance.Width = 150;
            // 
            // Device_Timer
            // 
            this.Device_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_FreeAll
            // 
            this.btn_FreeAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FreeAll.Location = new System.Drawing.Point(536, 436);
            this.btn_FreeAll.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FreeAll.Name = "btn_FreeAll";
            this.btn_FreeAll.Size = new System.Drawing.Size(112, 35);
            this.btn_FreeAll.TabIndex = 6;
            this.btn_FreeAll.Text = "Free All";
            this.btn_FreeAll.UseVisualStyleBackColor = true;
            this.btn_FreeAll.Click += new System.EventHandler(this.btn_FreeAll_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::UI_Design.Properties.Resources.management;
            this.pictureBox5.Location = new System.Drawing.Point(267, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(122, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // Manage_Devices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btn_FreeAll);
            this.Controls.Add(this.Device_Record);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Manage_Devices";
            this.Text = "Manage_Devices";
            ((System.ComponentModel.ISupportInitialize)(this.Device_Record)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Device_Record;
        private System.Windows.Forms.Timer Device_Timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_System;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Change_Status;
        private System.Windows.Forms.DataGridViewButtonColumn Under_Maintainance;
        private System.Windows.Forms.Button btn_FreeAll;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}