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
using System.IO;

namespace Employee_Training
{
    public partial class JobCardMasterRep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnExcel.Visible = false;
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        

        protected void btnOverAll_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "")
            {
                EmpDetails();
                btnExcel.Visible = true;
            }
            else if (txtCode.Text != "")
            {

                if (Common.msConn.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();

                    string query = "select * from UDT_MAS_TrainingJobCardMaster(NOLOCK) where  Code='" + txtCode.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Common.msConn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                btnExcel.Visible = true;
            }
                
        }

        protected void EmpDetails()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingJobCardMaster(NOLOCK)";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }

        protected void btnExcel_Click(object sender, EventArgs e)
        {
            Response.ClearContent();
            Response.Buffer = true;
            Response.AddHeader("content-disposition", string.Format("attachment; filename={0}", "Data.xls"));
            Response.ContentType = "application/Ms-excel";
            StringWriter sw = new StringWriter();
            HtmlTextWriter ht = new HtmlTextWriter(sw);
            GridView1.AllowPaging = false;


            for (int i = 0; i < GridView1.HeaderRow.Cells.Count; i++)
            {

            }
            GridView1.RenderControl(ht);
            Response.Write(sw.ToString());
            Response.End();
        }
    }
}