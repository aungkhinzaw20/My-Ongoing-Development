using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomMaintenanceTracking
{
    public partial class MyMenu : Form
    {
        private int childFormNumber = 0;

        public MyMenu()
        {
            InitializeComponent();
        }
        private void setUpRoomInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            Global.RoomListfromFile = false;
            frm.Show();
        }

        private void roomMaintenanceCheckListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance frm = new Maintenance();
            frm.MdiParent = this;
            frm.Show();
        }

        private void roomInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomInformationListing frm = new RoomInformationListing();
            frm.MdiParent = this;
            Global.RoomListfromFile = true;
            frm.Show();
        }
    }
}
