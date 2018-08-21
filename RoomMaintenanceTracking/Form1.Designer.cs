namespace RoomMaintenanceTracking
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisable = new System.Windows.Forms.Button();
            this.btnIndue = new System.Windows.Forms.Button();
            this.btnInSchedule = new System.Windows.Forms.Button();
            this.txtDueDate = new System.Windows.Forms.TextBox();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpScheduleEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpScheduleStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttoRoomNumber = new System.Windows.Forms.TextBox();
            this.txtfromRoomNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CLDShow = new System.Windows.Forms.ColorDialog();
            this.chkOverride = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkOverride);
            this.groupBox1.Controls.Add(this.btnDisable);
            this.groupBox1.Controls.Add(this.btnIndue);
            this.groupBox1.Controls.Add(this.btnInSchedule);
            this.groupBox1.Controls.Add(this.txtDueDate);
            this.groupBox1.Controls.Add(this.txtPrefix);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnGenerate);
            this.groupBox1.Controls.Add(this.dtpScheduleEnd);
            this.groupBox1.Controls.Add(this.dtpScheduleStart);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txttoRoomNumber);
            this.groupBox1.Controls.Add(this.txtfromRoomNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // btnDisable
            // 
            this.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDisable.Location = new System.Drawing.Point(250, 153);
            this.btnDisable.Name = "btnDisable";
            this.btnDisable.Size = new System.Drawing.Size(114, 24);
            this.btnDisable.TabIndex = 7;
            this.btnDisable.Text = "Due Expiry";
            this.btnDisable.UseVisualStyleBackColor = true;
            this.btnDisable.Click += new System.EventHandler(this.btnDisable_Click);
            // 
            // btnIndue
            // 
            this.btnIndue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIndue.Location = new System.Drawing.Point(130, 153);
            this.btnIndue.Name = "btnIndue";
            this.btnIndue.Size = new System.Drawing.Size(114, 24);
            this.btnIndue.TabIndex = 6;
            this.btnIndue.Text = "In Due";
            this.btnIndue.UseVisualStyleBackColor = true;
            this.btnIndue.Click += new System.EventHandler(this.btnIndue_Click);
            // 
            // btnInSchedule
            // 
            this.btnInSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInSchedule.Location = new System.Drawing.Point(9, 153);
            this.btnInSchedule.Name = "btnInSchedule";
            this.btnInSchedule.Size = new System.Drawing.Size(114, 24);
            this.btnInSchedule.TabIndex = 5;
            this.btnInSchedule.Text = "In Schedule";
            this.btnInSchedule.UseVisualStyleBackColor = true;
            this.btnInSchedule.Click += new System.EventHandler(this.btnInSchedule_Click);
            // 
            // txtDueDate
            // 
            this.txtDueDate.Location = new System.Drawing.Point(119, 97);
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.Size = new System.Drawing.Size(283, 20);
            this.txtDueDate.TabIndex = 4;
            // 
            // txtPrefix
            // 
            this.txtPrefix.Location = new System.Drawing.Point(119, 20);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(283, 20);
            this.txtPrefix.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(71, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Prefix";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(287, 188);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(115, 35);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "&Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtpScheduleEnd
            // 
            this.dtpScheduleEnd.Checked = false;
            this.dtpScheduleEnd.CustomFormat = "dd/MMM/yyyy";
            this.dtpScheduleEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduleEnd.Location = new System.Drawing.Point(119, 126);
            this.dtpScheduleEnd.Name = "dtpScheduleEnd";
            this.dtpScheduleEnd.ShowCheckBox = true;
            this.dtpScheduleEnd.Size = new System.Drawing.Size(283, 20);
            this.dtpScheduleEnd.TabIndex = 9;
            this.dtpScheduleEnd.Visible = false;
            // 
            // dtpScheduleStart
            // 
            this.dtpScheduleStart.CustomFormat = "dd/MMM/yyyy";
            this.dtpScheduleStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpScheduleStart.Location = new System.Drawing.Point(119, 74);
            this.dtpScheduleStart.Name = "dtpScheduleStart";
            this.dtpScheduleStart.Size = new System.Drawing.Size(283, 20);
            this.dtpScheduleStart.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Schedule End";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Due Date ( Month )";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Schedule Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // txttoRoomNumber
            // 
            this.txttoRoomNumber.Location = new System.Drawing.Point(277, 46);
            this.txttoRoomNumber.Name = "txttoRoomNumber";
            this.txttoRoomNumber.Size = new System.Drawing.Size(125, 20);
            this.txttoRoomNumber.TabIndex = 2;
            // 
            // txtfromRoomNumber
            // 
            this.txtfromRoomNumber.Location = new System.Drawing.Point(119, 46);
            this.txtfromRoomNumber.Name = "txtfromRoomNumber";
            this.txtfromRoomNumber.Size = new System.Drawing.Size(125, 20);
            this.txtfromRoomNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Number";
            // 
            // chkOverride
            // 
            this.chkOverride.AutoSize = true;
            this.chkOverride.Location = new System.Drawing.Point(9, 188);
            this.chkOverride.Name = "chkOverride";
            this.chkOverride.Size = new System.Drawing.Size(66, 17);
            this.chkOverride.TabIndex = 12;
            this.chkOverride.Text = "Override";
            this.chkOverride.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 254);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Maintenance Schedule";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttoRoomNumber;
        private System.Windows.Forms.TextBox txtfromRoomNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpScheduleEnd;
        private System.Windows.Forms.DateTimePicker dtpScheduleStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDueDate;
        private System.Windows.Forms.Button btnIndue;
        private System.Windows.Forms.Button btnInSchedule;
        private System.Windows.Forms.ColorDialog CLDShow;
        private System.Windows.Forms.Button btnDisable;
        private System.Windows.Forms.CheckBox chkOverride;
    }
}

