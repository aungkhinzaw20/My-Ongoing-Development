namespace RoomMaintenanceTracking
{
    partial class Maintenance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblDisable = new System.Windows.Forms.Label();
            this.lblInSchedule = new System.Windows.Forms.Label();
            this.lblDue = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpRoomList = new System.Windows.Forms.DataGridView();
            this.RMNPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMScheduleStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMDoneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompute);
            this.panel1.Controls.Add(this.lblDisable);
            this.panel1.Controls.Add(this.lblInSchedule);
            this.panel1.Controls.Add(this.lblDue);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 64);
            this.panel1.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(130, 6);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(112, 50);
            this.btnCompute.TabIndex = 7;
            this.btnCompute.Text = "&Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblDisable
            // 
            this.lblDisable.Location = new System.Drawing.Point(886, 15);
            this.lblDisable.Name = "lblDisable";
            this.lblDisable.Size = new System.Drawing.Size(166, 23);
            this.lblDisable.TabIndex = 6;
            this.lblDisable.Text = "Due Expiry";
            // 
            // lblInSchedule
            // 
            this.lblInSchedule.Location = new System.Drawing.Point(714, 15);
            this.lblInSchedule.Name = "lblInSchedule";
            this.lblInSchedule.Size = new System.Drawing.Size(166, 23);
            this.lblInSchedule.TabIndex = 5;
            this.lblInSchedule.Text = "In Schedule";
            // 
            // lblDue
            // 
            this.lblDue.Location = new System.Drawing.Point(542, 15);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(166, 23);
            this.lblDue.TabIndex = 4;
            this.lblDue.Text = "Due Expiry";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(248, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(112, 50);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "&Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 50);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpRoomList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 329);
            this.panel2.TabIndex = 5;
            // 
            // dtpRoomList
            // 
            this.dtpRoomList.AllowUserToAddRows = false;
            this.dtpRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMNPrefix,
            this.RNMNumber,
            this.RNMScheduleStartDate,
            this.RNMDueDate,
            this.RNMDoneDate,
            this.RNMStatus});
            this.dtpRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpRoomList.Location = new System.Drawing.Point(0, 0);
            this.dtpRoomList.Name = "dtpRoomList";
            this.dtpRoomList.Size = new System.Drawing.Size(1064, 329);
            this.dtpRoomList.TabIndex = 1;
            // 
            // RMNPrefix
            // 
            this.RMNPrefix.HeaderText = "Room Number Prefix";
            this.RMNPrefix.Name = "RMNPrefix";
            this.RMNPrefix.Width = 70;
            // 
            // RNMNumber
            // 
            this.RNMNumber.HeaderText = "Room Number";
            this.RNMNumber.Name = "RNMNumber";
            this.RNMNumber.Width = 200;
            // 
            // RNMScheduleStartDate
            // 
            this.RNMScheduleStartDate.HeaderText = "Manintenance Start Date";
            this.RNMScheduleStartDate.Name = "RNMScheduleStartDate";
            this.RNMScheduleStartDate.Width = 200;
            // 
            // RNMDueDate
            // 
            this.RNMDueDate.HeaderText = "Due Date";
            this.RNMDueDate.Name = "RNMDueDate";
            this.RNMDueDate.Width = 200;
            // 
            // RNMDoneDate
            // 
            this.RNMDoneDate.HeaderText = "Maintenance Date ( dd/mm/yyyy)";
            this.RNMDoneDate.Name = "RNMDoneDate";
            // 
            // RNMStatus
            // 
            this.RNMStatus.FalseValue = "0";
            this.RNMStatus.HeaderText = "Done";
            this.RNMStatus.Name = "RNMStatus";
            this.RNMStatus.TrueValue = "1";
            this.RNMStatus.Width = 50;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpRoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblDisable;
        private System.Windows.Forms.Label lblInSchedule;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtpRoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMNPrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMScheduleStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMDoneDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RNMStatus;
    }
}