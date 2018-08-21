using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoomMaintenanceTracking
{
    public partial class RoomInformationListing : Form
    {
        public RoomInformationListing()
        {
            InitializeComponent();
        }

        private void RoomInformationListing_Load(object sender, EventArgs e)
        {
            try
            {                
                if (Global.RoomListfromFile)
                {
                    if (!File.Exists(Application.StartupPath + "\\MyRoomlist.xml"))
                    {
                        MessageBox.Show("Rooms haven't setup yet.");
                        return;
                    }
                    DataSet MyDS = new DataSet();
                    DataTable MyDT = new DataTable("MyRoomList");
                    MyDS.ReadXml(Application.StartupPath + "\\MyRoomlist.xml");
                    if (MyDS.Tables[0].Rows.Count < 0)
                        throw new Exception("");
                    MyDT = MyDS.Tables[0];
                    dtpRoomList.Rows.Clear();

                    for (int i = 0; i < MyDT.Rows.Count; i++)
                    {
                        dtpRoomList.Rows.Add();
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RMNPrefix"].Value = Convert.ToString(MyDT.Rows[i]["RMNPrefix"]);
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMNumber"].Value = Convert.ToString(MyDT.Rows[i]["RNMNumber"]);
                        if (DateTime.Now.Month > Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Month)
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMScheduleStartDate"].Value = Convert.ToString(Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                        else
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMScheduleStartDate"].Value = Convert.ToString(MyDT.Rows[i]["RNMScheduleStartDate"]);

                        Global.DueDate = Convert.ToDateTime(MyDT.Rows[i]["RNMDueDate"]).Month - Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Month;

                        if (Global.DueDate > 0)
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDueDate"].Value = Convert.ToString(Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Day + "/" + Convert.ToString(DateTime.Now.Month + Global.DueDate) + "/" + DateTime.Now.Year);
                        else
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDueDate"].Value = Convert.ToString(MyDT.Rows[i]["RNMScheduleStartDate"]);
                        
                        #region Color
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["indead"].Value = Convert.ToString(MyDT.Rows[i]["indead"]);
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["inschedule"].Value = Convert.ToString(MyDT.Rows[i]["indue"]);
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["indue"].Value = Convert.ToString(MyDT.Rows[i]["inschedule"]);
                        #endregion
                    }
                }
                else
                {
                    for (int i = Global.fromRoomNumber - 1; i < Global.toRoomNumber; i++)
                    {
                        dtpRoomList.Rows.Add();
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RMNPrefix"].Value = Global.RoomNumberPrefix;
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMNumber"].Value = Convert.ToString(i + 1);
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMScheduleStartDate"].Value = Convert.ToString(Global.StartDate.ToString("dd/MM/yyyy"));
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDueDate"].Value = Global.StartDate.AddMonths(Global.DueDate).ToString("dd/MM/yyyy");

                        #region Color
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["indead"].Value = Global.indead;
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["inschedule"].Value = Global.inschedule;
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["indue"].Value = Global.indue;
                        #endregion

                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMStatus"].Value = 1;

                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn col in dtpRoomList.Columns)
                {
                    dt.Columns.Add(col.Name);
                }
                foreach (DataGridViewRow row in dtpRoomList.Rows)
                {
                    DataRow dRow = dt.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dRow[cell.ColumnIndex] = cell.Value;
                    }
                    dt.Rows.Add(dRow);
                }
                dt.TableName = "MyRoomList";
                if (File.Exists(Application.StartupPath + "\\MyRoomlist.xml"))
                {
                    File.Copy(Application.StartupPath + "\\MyRoomlist.xml", Application.StartupPath + "\\MyRoomlist" + DateTime.Now.ToString("ddMMMyyyyhhmmss") + ".xml");
                    File.Delete(Application.StartupPath + "\\MyRoomlist.xml");
                }
                dt.WriteXml(Application.StartupPath + "\\MyRoomlist.xml", true);

                MessageBox.Show("Saving Successful.");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpRoomList.Rows.Clear();
            RoomInformationListing_Load(sender, e);
        }

        private void RoomInformationListing_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void RoomInformationListing_Resize(object sender, EventArgs e)
        {
            if(FormWindowState.Minimized==this.WindowState)
            {
                mynoti.Visible = true;
                mynoti.ShowBalloonTip(500);
                this.Hide();
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                mynoti.Visible = false;
            }
        }
    }
}
