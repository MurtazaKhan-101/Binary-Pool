namespace UI_Design
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Device_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Initial_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Final_Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_search = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.DatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.Student_name,
            this.Device_ID,
            this.Initial_Time,
            this.Final_Time,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(13, 237);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(630, 257);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student_ID
            // 
            this.Student_ID.HeaderText = "Student ID";
            this.Student_ID.MinimumWidth = 8;
            this.Student_ID.Name = "Student_ID";
            this.Student_ID.Width = 150;
            // 
            // Student_name
            // 
            this.Student_name.HeaderText = "Student Name";
            this.Student_name.MinimumWidth = 8;
            this.Student_name.Name = "Student_name";
            this.Student_name.Width = 150;
            // 
            // Device_ID
            // 
            this.Device_ID.HeaderText = "Device ID";
            this.Device_ID.MinimumWidth = 8;
            this.Device_ID.Name = "Device_ID";
            this.Device_ID.Width = 150;
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
            this.Final_Time.Width = 150;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.Width = 150;
            // 
            // lbl_search
            // 
            this.lbl_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(182, 184);
            this.lbl_search.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(121, 20);
            this.lbl_search.TabIndex = 1;
            this.lbl_search.Text = "Search By Date";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Location = new System.Drawing.Point(537, 182);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(380, 138);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Order By";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Image = global::UI_Design.Properties.Resources.edit__1_;
            this.pictureBox5.Location = new System.Drawing.Point(264, 12);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(122, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.BackColor = System.Drawing.Color.Transparent;
            this.DatePicker.BorderRadius = 1;
            this.DatePicker.Color = System.Drawing.Color.Silver;
            this.DatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePicker.DisabledColor = System.Drawing.Color.Gray;
            this.DatePicker.DisplayWeekNumbers = false;
            this.DatePicker.DPHeight = 0;
            this.DatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker.FillDatePicker = false;
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePicker.ForeColor = System.Drawing.Color.Black;
            this.DatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker.Icon")));
            this.DatePicker.IconColor = System.Drawing.Color.Gray;
            this.DatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePicker.LeftTextMargin = 5;
            this.DatePicker.Location = new System.Drawing.Point(310, 184);
            this.DatePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(220, 32);
            this.DatePicker.TabIndex = 9;
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_search);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Record";
            this.Text = "Record";
            this.Load += new System.EventHandler(this.Record_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Device_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Initial_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Final_Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private Bunifu.UI.WinForms.BunifuDatePicker DatePicker;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}