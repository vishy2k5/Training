using System;
using System.Collections.Generic;
using System.Linq;
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
    public partial class OJTDelete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropdownCode();
            }
        }


        public void DropdownCode()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select Code from UDT_MAS_TrainingJobCardMaster(NOLOCK)";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpCode.DataSource = ds;
                drpCode.DataTextField = "Code";
                drpCode.DataValueField = "Code";
                drpCode.DataBind();
                drpCode.Items.Insert(0, ListItem.FromString("---Select---"));
                drpCode.SelectedIndex = 0;
            }
        }
        protected void btndelete_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "Delete from  UDT_MAS_TrainingOJT where  Empcode='" + txtEmpcode.Text + "' and JobCode='" + drpCode.SelectedItem + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Deleted Successfully" + txtEmpcode.Text;
                
            }
        }
    }
}