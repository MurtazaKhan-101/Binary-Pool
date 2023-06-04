namespace UI_Design
{
    partial class Session_Timer
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
            this.LB_Initial = new System.Windows.Forms.Label();
            this.LB_FinalTime = new System.Windows.Forms.Label();
            this.devicesTableAdapter1 = new UI_Design.Project_DatabaseDataSetTableAdapters.DEVICESTableAdapter();
            this.I_TIME = new System.Windows.Forms.Label();
            this.F_Time = new System.Windows.Forms.Label();
            this.T_Left = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btn_End = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Initial
            // 
            this.LB_Initial.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LB_Initial.AutoSize = true;
            this.LB_Initial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Initial.Location = new System.Drawing.Point(66, 18);
            this.LB_Initial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Initial.Name = "LB_Initial";
            this.LB_Initial.Size = new System.Drawing.Size(137, 29);
            this.LB_Initial.TabIndex = 0;
            this.LB_Initial.Text = "Initial Time:";
            // 
            // LB_FinalTime
            // 
            this.LB_FinalTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LB_FinalTime.AutoSize = true;
            this.LB_FinalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FinalTime.Location = new System.Drawing.Point(69, 57);
            this.LB_FinalTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_FinalTime.Name = "LB_FinalTime";
            this.LB_FinalTime.Size = new System.Drawing.Size(134, 29);
            this.LB_FinalTime.TabIndex = 1;
            this.LB_FinalTime.Text = "Final Time:";
            // 
            // devicesTableAdapter1
            // 
            this.devicesTableAdapter1.ClearBeforeFill = true;
            // 
            // I_TIME
            // 
            this.I_TIME.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.I_TIME.AutoSize = true;
            this.I_TIME.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.I_TIME.Location = new System.Drawing.Point(228, 18);
            this.I_TIME.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.I_TIME.Name = "I_TIME";
            this.I_TIME.Size = new System.Drawing.Size(81, 29);
            this.I_TIME.TabIndex = 2;
            this.I_TIME.Text = "I Time";
            // 
            // F_Time
            // 
            this.F_Time.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.F_Time.AutoSize = true;
            this.F_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_Time.Location = new System.Drawing.Point(228, 57);
            this.F_Time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.F_Time.Name = "F_Time";
            this.F_Time.Size = new System.Drawing.Size(90, 29);
            this.F_Time.TabIndex = 3;
            this.F_Time.Text = "F Time";
            // 
            // T_Left
            // 
            this.T_Left.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.T_Left.AutoSize = true;
            this.T_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_Left.Location = new System.Drawing.Point(83, 96);
            this.T_Left.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.T_Left.Name = "T_Left";
            this.T_Left.Size = new System.Drawing.Size(120, 29);
            this.T_Left.TabIndex = 4;
            this.T_Left.Text = "Time Left:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "T Left";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btn_End
            // 
            this.btn_End.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_End.Location = new System.Drawing.Point(71, 156);
            this.btn_End.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_End.Name = "btn_End";
            this.btn_End.Size = new System.Drawing.Size(121, 41);
            this.btn_End.TabIndex = 6;
            this.btn_End.Text = "End Session";
            this.btn_End.UseVisualStyleBackColor = true;
            this.btn_End.Click += new System.EventHandler(this.btn_End_Click);
            // 
            // Session_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 229);
            this.Controls.Add(this.btn_End);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.T_Left);
            this.Controls.Add(this.F_Time);
            this.Controls.Add(this.I_TIME);
            this.Controls.Add(this.LB_FinalTime);
            this.Controls.Add(this.LB_Initial);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Session_Timer";
            this.Text = "Session_Timer";
            this.Load += new System.EventHandler(this.Session_Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Initial;
        private System.Windows.Forms.Label LB_FinalTime;
        private Project_DatabaseDataSetTableAdapters.DEVICESTableAdapter devicesTableAdapter1;
        private System.Windows.Forms.Label I_TIME;
        private System.Windows.Forms.Label F_Time;
        private System.Windows.Forms.Label T_Left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Button btn_End;
    }
}