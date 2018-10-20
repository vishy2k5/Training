using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Web.Services;
using System.Web.Script.Services;
using Employee_Training;

namespace Employee_Training
{
    public partial class JobCardMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingJobCardMaster(Code,StationName,ProjectName,Status,Score,Location,WorkingStatus,Createdby,CreatedDate,Modifiedby,ModifyDate)values('" + txtCode.Text + "','" + txtStationName.Text + "','" + txtProject.Text + "','" + drpStationStatus.SelectedItem + "','"+txtScore.Text+"','" + txtLocation.Text + "','" + drpstatus.SelectedItem + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Station Saved Successfully" + txtStationName.Text;
                txtCode.Text = "";
                txtLocation.Text = "";
                txtProject.Text = "";
                txtScore.Text = "";
                txtStationName.Text = "";
                btnSave.Visible = false;
               
            }
        }

        protected void txtCode_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }
    }
}