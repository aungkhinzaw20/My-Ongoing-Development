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
    public partial class RoomList : Form
    {
        public RoomList()
        {
            InitializeComponent();
        }

        private void RoomList_Load(object sender, EventArgs e)
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
                    MyDT = MyDS.Tables[0];
                    dtpRoomList.Rows.Clear();

                    for (int i = 0; i < MyDT.Rows.Count; i++)
                    {
                        dtpRoomList.Rows.Add();
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RMNPrefix"].Value = Convert.ToString(MyDT.Rows[i]["RMNPrefix"]);
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMNumber"].Value = Convert.ToString(MyDT.Rows[i]["RNMNumber"]);
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMScheduleStartDate"].Value = Convert.ToString(Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).AddMonths(DateTime.Now.Month - Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Month));
                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDueDate"].Value = Convert.ToString(Convert.ToDateTime(MyDT.Rows[i]["RNMDueDate"]).AddMonths(DateTime.Now.Month - Convert.ToDateTime(MyDT.Rows[i]["RNMDueDate"]).Month));
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
                MessageBox.Show(ex.Message);
            }
        }

        private void RoomList_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dtpRoomList.Rows.Clear();
            RoomList_Load(sender, e);            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                if (!Global.OverrideFile)
                {
                    DataSet MyDS = new DataSet();
                    MyDS.ReadXml(Application.StartupPath + "\\MyRoomlist.xml");
                    if (MyDS.Tables.Count > 0)
                        dt = MyDS.Tables[0];
                }

                if (dt.Columns.Count <= 0)
                {
                    foreach (DataGridViewColumn col in dtpRoomList.Columns)
                    {
                        dt.Columns.Add(col.Name);
                    }
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
                    if (Global.OverrideFile)
                    {
                        File.Copy(Application.StartupPath + "\\MyRoomlist.xml", Application.StartupPath + "\\MyRoomlist" + DateTime.Now.ToString("ddMMMyyyyhhmmss") + ".xml");
                        File.Delete(Application.StartupPath + "\\MyRoomlist.xml");
                    }
                }
                dt.WriteXml(Application.StartupPath + "\\MyRoomlist.xml",true);

                MessageBox.Show("Saving Successful.");

                this.RoomList_FormClosed(sender, new FormClosedEventArgs(CloseReason.UserClosing));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
