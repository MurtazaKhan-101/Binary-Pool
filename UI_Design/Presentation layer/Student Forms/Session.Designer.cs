namespace UI_Design
{
    partial class Session
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
            this.dEVICESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DatabaseDataSet = new UI_Design.Project_DatabaseDataSet();
            this.dEVICESTableAdapter = new UI_Design.Project_DatabaseDataSetTableAdapters.DEVICESTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DEVICE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OS_TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AVAILABLE_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USE_Device = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Gridview_Timer = new System.Windows.Forms.Timer(this.components);
            this.btnReload = new System.Windows.Forms.Button();
            this.Data_Timer = new System.Windows.Forms.Timer(this.components);
            this.child_pannel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dEVICESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dEVICESBindingSource
            // 
            this.dEVICESBindingSource.DataMember = "DEVICES";
            this.dEVICESBindingSource.DataSource = this.project_DatabaseDataSet;
            // 
            // project_DatabaseDataSet
            // 
            this.project_DatabaseDataSet.DataSetName = "Project_DatabaseDataSet";
            this.project_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dEVICESTableAdapter
            // 
            this.dEVICESTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DEVICE_ID,
            this.OS_TYPE,
            this.AVAILABLE_STATUS,
            this.USE_Device});
            this.dataGridView1.Location = new System.Drawing.Point(17, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(632, 110);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DEVICE_ID
            // 
            this.DEVICE_ID.HeaderText = "DEVICE_ID";
            this.DEVICE_ID.MinimumWidth = 8;
            this.DEVICE_ID.Name = "DEVICE_ID";
            this.DEVICE_ID.ReadOnly = true;
            this.DEVICE_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DEVICE_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DEVICE_ID.Width = 150;
            // 
            // OS_TYPE
            // 
            this.OS_TYPE.HeaderText = "OS_TYPE";
            this.OS_TYPE.MinimumWidth = 8;
            this.OS_TYPE.Name = "OS_TYPE";
            this.OS_TYPE.ReadOnly = true;
            this.OS_TYPE.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OS_TYPE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OS_TYPE.Width = 150;
            // 
            // AVAILABLE_STATUS
            // 
            this.AVAILABLE_STATUS.HeaderText = "AVAILABLE_STATUS";
            this.AVAILABLE_STATUS.MinimumWidth = 8;
            this.AVAILABLE_STATUS.Name = "AVAILABLE_STATUS";
            this.AVAILABLE_STATUS.ReadOnly = true;
            this.AVAILABLE_STATUS.Width = 150;
            // 
            // USE_Device
            // 
            this.USE_Device.HeaderText = "Use Device";
            this.USE_Device.MinimumWidth = 8;
            this.USE_Device.Name = "USE_Device";
            this.USE_Device.ReadOnly = true;
            this.USE_Device.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Devices Record";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(534, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "You can chose a device according to your choice";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Gridview_Timer
            // 
            this.Gridview_Timer.Interval = 10000000;
            this.Gridview_Timer.Tick += new System.EventHandler(this.Session_Timer_Tick);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Location = new System.Drawing.Point(567, 183);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(82, 28);
            this.btnReload.TabIndex = 3;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.button1_Click);
            // 
            // Data_Timer
            // 
            this.Data_Timer.Interval = 100000;
            this.Data_Timer.Tick += new System.EventHandler(this.Data_Timer_Tick);
            // 
            // child_pannel
            // 
            this.child_pannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.child_pannel.Location = new System.Drawing.Point(0, 217);
            this.child_pannel.Name = "child_pannel";
            this.child_pannel.Size = new System.Drawing.Size(661, 285);
            this.child_pannel.TabIndex = 4;
            // 
            // Session
            // 
            this.ClientSize = new System.Drawing.Size(661, 505);
            this.Controls.Add(this.child_pannel);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Session";
            this.Load += new System.EventHandler(this.Session_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dEVICESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView Device_Record;
        private Project_DatabaseDataSet project_DatabaseDataSet;
        private System.Windows.Forms.BindingSource dEVICESBindingSource;
        private Project_DatabaseDataSetTableAdapters.DEVICESTableAdapter dEVICESTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEVICE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OS_TYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn AVAILABLE_STATUS;
        private System.Windows.Forms.DataGridViewButtonColumn USE_Device;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer Gridview_Timer;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Timer Data_Timer;
        private System.Windows.Forms.Panel child_pannel;
    }
}