namespace RoomMaintenanceTracking
{
    partial class MyMenu
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUpRoomInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.roomMaintenanceCheckListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.roomInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpRoomInformationToolStripMenuItem,
            this.roomInformationToolStripMenuItem,
            this.roomMaintenanceCheckListToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // setUpRoomInformationToolStripMenuItem
            // 
            this.setUpRoomInformationToolStripMenuItem.Name = "setUpRoomInformationToolStripMenuItem";
            this.setUpRoomInformationToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.setUpRoomInformationToolStripMenuItem.Text = "Set Up Room Information";
            this.setUpRoomInformationToolStripMenuItem.Click += new System.EventHandler(this.setUpRoomInformationToolStripMenuItem_Click);
            // 
            // roomMaintenanceCheckListToolStripMenuItem
            // 
            this.roomMaintenanceCheckListToolStripMenuItem.Name = "roomMaintenanceCheckListToolStripMenuItem";
            this.roomMaintenanceCheckListToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.roomMaintenanceCheckListToolStripMenuItem.Text = "Room Maintenance Check List";
            this.roomMaintenanceCheckListToolStripMenuItem.Click += new System.EventHandler(this.roomMaintenanceCheckListToolStripMenuItem_Click);
            // 
            // roomInformationToolStripMenuItem
            // 
            this.roomInformationToolStripMenuItem.Name = "roomInformationToolStripMenuItem";
            this.roomInformationToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.roomInformationToolStripMenuItem.Text = "Room Information";
            this.roomInformationToolStripMenuItem.Click += new System.EventHandler(this.roomInformationToolStripMenuItem_Click);
            // 
            // MyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MyMenu";
            this.Text = "MyMenu";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setUpRoomInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomMaintenanceCheckListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem roomInformationToolStripMenuItem;
    }
}



