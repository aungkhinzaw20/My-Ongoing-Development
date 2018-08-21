namespace RoomMaintenanceTracking
{
    partial class RoomInformationListing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpRoomList = new System.Windows.Forms.DataGridView();
            this.RMNPrefix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inschedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.indue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMScheduleStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNMStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.mynoti = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpRoomList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 69);
            this.panel1.TabIndex = 2;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(130, 6);
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
            this.panel2.Size = new System.Drawing.Size(1052, 324);
            this.panel2.TabIndex = 4;
            // 
            // dtpRoomList
            // 
            this.dtpRoomList.AllowUserToAddRows = false;
            this.dtpRoomList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtpRoomList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RMNPrefix,
            this.inschedule,
            this.indead,
            this.indue,
            this.RNMNumber,
            this.RNMScheduleStartDate,
            this.RNMDueDate,
            this.RNMStatus});
            this.dtpRoomList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpRoomList.Location = new System.Drawing.Point(0, 0);
            this.dtpRoomList.Name = "dtpRoomList";
            this.dtpRoomList.Size = new System.Drawing.Size(1052, 324);
            this.dtpRoomList.TabIndex = 1;
            // 
            // RMNPrefix
            // 
            this.RMNPrefix.HeaderText = "Room Number Prefix";
            this.RMNPrefix.Name = "RMNPrefix";
            this.RMNPrefix.Width = 70;
            // 
            // inschedule
            // 
            this.inschedule.HeaderText = "inschedule";
            this.inschedule.Name = "inschedule";
            this.inschedule.Visible = false;
            // 
            // indead
            // 
            this.indead.HeaderText = "indead";
            this.indead.Name = "indead";
            this.indead.Visible = false;
            // 
            // indue
            // 
            this.indue.HeaderText = "indue";
            this.indue.Name = "indue";
            this.indue.Visible = false;
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
            // RNMStatus
            // 
            this.RNMStatus.FalseValue = "0";
            this.RNMStatus.HeaderText = "Active";
            this.RNMStatus.Name = "RNMStatus";
            this.RNMStatus.TrueValue = "1";
            this.RNMStatus.Width = 50;
            // 
            // mynoti
            // 
            this.mynoti.Text = "notifyIcon1";
            this.mynoti.Visible = true;
            // 
            // RoomInformationListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 393);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "RoomInformationListing";
            this.Text = "RoomInformationListing";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RoomInformationListing_FormClosed);
            this.Load += new System.EventHandler(this.RoomInformationListing_Load);
            this.Resize += new System.EventHandler(this.RoomInformationListing_Resize);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpRoomList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtpRoomList;
        private System.Windows.Forms.DataGridViewTextBoxColumn RMNPrefix;
        private System.Windows.Forms.DataGridViewTextBoxColumn inschedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn indead;
        private System.Windows.Forms.DataGridViewTextBoxColumn indue;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMScheduleStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNMDueDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn RNMStatus;
        private System.Windows.Forms.NotifyIcon mynoti;
    }
}