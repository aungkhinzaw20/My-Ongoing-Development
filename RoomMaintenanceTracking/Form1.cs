using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomMaintenanceTracking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex("[0-9]");
            try
            {
                if (!regex.IsMatch(txtfromRoomNumber.Text))
                    throw new Exception("Room Number much be numeric.");
                else if (!regex .IsMatch(txttoRoomNumber.Text))
                    throw new Exception("Room Number much be numeric.");
                else if (!regex.IsMatch(txtDueDate.Text))
                    throw new Exception("Due date much be numeric.");
                else if (dtpScheduleEnd.Checked == true)
                {
                    if (DateTime.Compare(dtpScheduleEnd.Value, dtpScheduleStart.Value) <= 0)
                        throw new Exception("Schedule end date much be greater than schedule start date.");
                }
                #region Calling for Generate
                RoomList frm = new RoomList();
                Global.RoomNumberPrefix = txtPrefix.Text;
                Global.fromRoomNumber = Convert.ToInt32(txtfromRoomNumber.Text);
                Global.toRoomNumber = Convert.ToInt32(txttoRoomNumber.Text);
                Global.DueDate = Convert.ToInt32(txtDueDate.Text);
                Global.haveexpiry = dtpScheduleEnd.Checked;
                Global.EndDate = dtpScheduleEnd.Value;
                Global.StartDate = dtpScheduleStart.Value;
                Global.OverrideFile = chkOverride.Checked;
                if (frm.ShowDialog() == DialogResult.OK)
                    this.Close();
                #endregion  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnInSchedule_Click(object sender, EventArgs e)
        {
            if (CLDShow.ShowDialog() == DialogResult.OK)
            {
                btnInSchedule.BackColor = CLDShow.Color;
                int ColorValue = CLDShow.Color.ToArgb();
                Global.inschedule = string.Format("{0:x6}", ColorValue);                
            }
        }

        private void btnIndue_Click(object sender, EventArgs e)
        {
            if (CLDShow.ShowDialog() == DialogResult.OK)
            {
                btnIndue.BackColor = CLDShow.Color;
                int ColorValue = CLDShow.Color.ToArgb();
                Global.indue = string.Format("{0:x6}", ColorValue);
            }
        }

        private void btnDisable_Click(object sender, EventArgs e)
        {
            if (CLDShow.ShowDialog() == DialogResult.OK)
            {
                btnDisable.BackColor = CLDShow.Color;
                int ColorValue = CLDShow.Color.ToArgb();
                Global.indead = string.Format("{0:x6}", ColorValue);                
            }
        }
    }
}
