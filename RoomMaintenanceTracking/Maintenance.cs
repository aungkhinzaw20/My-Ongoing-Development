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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(Application.StartupPath + "\\MyRoomlist.xml"))
                {
                    MessageBox.Show("Rooms haven't setup yet.");
                    return;
                }
                string dtname = "MyRoomDonelist_[" + DateTime.Now.Month + "]_[" + DateTime.Now.Year + "]";
                DataSet MyDS = new DataSet();
                DataTable MyDT = new DataTable("MyRoomList");
                DataSet MyDoneDS = new DataSet();
                DataTable MyDoneDT = new DataTable(dtname);
                bool DoneListCheck = false; 
                MyDS.ReadXml(Application.StartupPath + "\\MyRoomlist.xml");
                MyDT = MyDS.Tables[0];
                dtpRoomList.Rows.Clear();
                if (File.Exists(Application.StartupPath + "\\" + dtname + ".xml"))
                {                    
                    MyDoneDS.ReadXml(Application.StartupPath + "\\" + dtname + ".xml");
                    MyDoneDT = MyDoneDS.Tables[0];
                }

                if (MyDoneDT.Rows.Count > 0)
                {
                    for (int i = 0; i < MyDT.Rows.Count; i++)
                    {
                        for (int j = 0; j < MyDoneDT.Rows.Count; j++)
                        {
                            lblDisable.BackColor = (Color)new ColorConverter().ConvertFromString("#" + Convert.ToString(MyDT.Rows[i]["indead"]));
                            lblDue.BackColor = (Color)new ColorConverter().ConvertFromString("#" + Convert.ToString(MyDT.Rows[i]["indue"]));
                            lblInSchedule.BackColor = (Color)new ColorConverter().ConvertFromString("#" + Convert.ToString(MyDT.Rows[i]["inschedule"]));

                            if (Convert.ToString(MyDT.Rows[i]["RNMNumber"]) == Convert.ToString(MyDoneDT.Rows[j]["RNMNumber"]))
                            {
                                DoneListCheck = true;
                                break;
                            }
                        }
                        if (!DoneListCheck)
                        {
                            dtpRoomList.Rows.Add();
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RMNPrefix"].Value = Convert.ToString(MyDT.Rows[i]["RMNPrefix"]);
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMNumber"].Value = Convert.ToString(MyDT.Rows[i]["RNMNumber"]);
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDoneDate"].Value = DateTime.Now.ToString("dd/MMM/yyyy");

                            if (DateTime.Now.Month > Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Month)
                                dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMScheduleStartDate"].Value = Convert.ToString(Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Day + "/" + DateTime.Now.Month + "/" + DateTime.Now.Year);
                            else
                                dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMScheduleStartDate"].Value = Convert.ToString(MyDT.Rows[i]["RNMScheduleStartDate"]);

                            Global.DueDate = Convert.ToDateTime(MyDT.Rows[i]["RNMDueDate"]).Month - Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Month;

                            if (Global.DueDate > 0)
                                dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDueDate"].Value = Convert.ToString(Convert.ToDateTime(MyDT.Rows[i]["RNMScheduleStartDate"]).Day + "/" + DateTime.Now.Month + Global.DueDate + "/" + DateTime.Now.Year);
                            else
                                dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDueDate"].Value = Convert.ToString(MyDT.Rows[i]["RNMScheduleStartDate"]);

                            if (DateTime.Compare(Convert.ToDateTime(MyDT.Rows[i]["RNMDueDate"]), DateTime.Now) <= 0)
                                dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].DefaultCellStyle.BackColor = lblDue.BackColor;
                            else
                                dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].DefaultCellStyle.BackColor = lblInSchedule.BackColor;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < MyDT.Rows.Count; i++)
                    {
                        lblDisable.BackColor = (Color)new ColorConverter().ConvertFromString("#" + Convert.ToString(MyDT.Rows[i]["indead"]));
                        lblDue.BackColor = (Color)new ColorConverter().ConvertFromString("#" + Convert.ToString(MyDT.Rows[i]["indue"]));
                        lblInSchedule.BackColor = (Color)new ColorConverter().ConvertFromString("#" + Convert.ToString(MyDT.Rows[i]["inschedule"]));

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

                        dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].Cells["RNMDoneDate"].Value = DateTime.Now.ToString("dd/MMM/yyyy");

                        if (DateTime.Compare(Convert.ToDateTime(MyDT.Rows[i]["RNMDueDate"]), DateTime.Now) <= 0)
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].DefaultCellStyle.BackColor = lblDue.BackColor;
                        else
                            dtpRoomList.Rows[dtpRoomList.Rows.Count - 1].DefaultCellStyle.BackColor = lblInSchedule.BackColor;                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Maintenance_Load(sender, e);
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtpRoomList.Rows.Count; i++)
            {
                if (DateTime.Compare(Convert.ToDateTime(dtpRoomList.Rows[i].Cells["RNMDueDate"].Value), DateTime.Now) <= 0 && String.IsNullOrEmpty(Convert.ToString(dtpRoomList.Rows[i].Cells["RNMDoneDate"].Value)))
                {
                    dtpRoomList.Rows[i].Cells["RNMStatus"].Value = 0;
                    dtpRoomList.Rows[i].DefaultCellStyle.BackColor = lblDisable.BackColor;
                }
                else if (DateTime.Compare(Convert.ToDateTime(dtpRoomList.Rows[i].Cells["RNMDueDate"].Value), Convert.ToDateTime(dtpRoomList.Rows[i].Cells["RNMDoneDate"].Value)) >= 0)
                {
                    dtpRoomList.Rows[i].Cells["RNMStatus"].Value = 1;
                    dtpRoomList.Rows[i].DefaultCellStyle.BackColor = lblInSchedule.BackColor;
                }
                else if (DateTime.Compare(Convert.ToDateTime(dtpRoomList.Rows[i].Cells["RNMDueDate"].Value), Convert.ToDateTime(dtpRoomList.Rows[i].Cells["RNMDoneDate"].Value)) < 0)
                {
                    dtpRoomList.Rows[i].Cells["RNMStatus"].Value = 1;
                    dtpRoomList.Rows[i].DefaultCellStyle.BackColor = lblDisable.BackColor;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string dtname = "MyRoomDonelist_[" + DateTime.Now.Month + "]_[" + DateTime.Now.Year + "]";
                bool addrown = false;
                if (File.Exists(Application.StartupPath + "\\" + dtname + ".xml"))
                {
                    DataSet MyDS = new DataSet();
                    DataTable dt = new DataTable(dtname);
                    MyDS.ReadXml(Application.StartupPath + "\\" + dtname + ".xml");

                    dt = MyDS.Tables[0];

                    foreach (DataGridViewRow row in dtpRoomList.Rows)
                    {
                        if (row.Cells["RNMStatus"].Value.ToString() == "1")
                        {
                            DataRow dRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                                addrown = true;
                            }
                            if (addrown)
                                dt.Rows.Add(dRow);
                            addrown = false;
                        }
                    }
                    if (File.Exists(Application.StartupPath + "\\" + dtname + ".xml"))
                    {
                        File.Delete(Application.StartupPath + "\\" + dtname + ".xml");
                    }
                    dt.WriteXml(Application.StartupPath + "\\" + dtname + ".xml", true);
                }
                else
                {
                    DataTable dt = new DataTable();
                    foreach (DataGridViewColumn col in dtpRoomList.Columns)
                    {
                        dt.Columns.Add(col.Name);
                    }
                    foreach (DataGridViewRow row in dtpRoomList.Rows)
                    {
                        if (row.Cells["RNMStatus"].Value.ToString() == "1")
                        {
                            DataRow dRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                                addrown = true;
                            }
                            if (addrown)
                                dt.Rows.Add(dRow);
                            addrown = false;
                        }
                    }
                    dt.TableName = dtname;
                    dt.WriteXml(Application.StartupPath + "\\" + dtname + ".xml", true);
                }
                btnRefresh_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
