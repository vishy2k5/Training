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
    public partial class EmpMasterRep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

               
                DropdownDepartment();
                DropdownEmpType();
                DropdownStatus();
                DropdownContract();
                btnExcel.Visible = false;
               
            }
        }
        public void DropdownDepartment()
         {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct Department from UDT_MAS_TrainingDepartment(nolock) order by Department";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpDep.DataSource = ds;
                drpDep.DataTextField = "Department";
                drpDep.DataValueField = "Department";
                drpDep.DataBind();
                drpDep.Items.Insert(0, ListItem.FromString("---Select---"));
                drpDep.SelectedIndex = 0;
              

            }
        }
    public void DropdownEmpType()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct  Type from UDT_MAS_TrainingDesGraType(nolock) where  status=1  order by Type";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpType.DataSource = ds;
                drpType.DataTextField = "Type";
                drpType.DataValueField = "Type";
                drpType.DataBind();
                drpType.Items.Insert(0, ListItem.FromString("---Select---"));
                drpType.SelectedIndex = 0;
               

            }
        }
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }

        protected void btnExcel_Click(object sender, System.EventArgs e)
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
        protected void EmpDetails()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where workstatus='Active' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }

        }
        

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (txtempcode.Text == "")
            {
                EmpDetails();
                btnExcel.Visible = true;
            }
            else  if(txtempcode.Text!="")
            {

                if (Common.msConn.State == ConnectionState.Open)
                {
                    DataTable dt = new DataTable();

                    string query = "select * from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where  status=1  and Empcode='" + txtempcode.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Common.msConn);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    sda.Fill(dt);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                btnExcel.Visible = true;
            }
                
            }

        protected void btnDep_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where  status=1  and Dep='" + drpDep.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcel.Visible = true;
        }

        protected void btnType_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where  status=1  and EmpType='" + drpType.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcel.Visible = true;
        }
        public void DropdownStatus()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct  employeeStatus from UDT_MAS_TrainingEmployeeStatus(nolock) where  status=1 order by employeeStatus";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpStatus.DataSource = ds;
                drpStatus.DataTextField = "employeeStatus";
                drpStatus.DataValueField = "employeeStatus";
                drpStatus.DataBind();
                drpStatus.Items.Insert(0, ListItem.FromString("---Select---"));
                drpStatus.SelectedIndex = 0;


            }
        }
        public void DropdownContract()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct  ContractName from UDT_MAS_TrainingEmployeeMaster(nolock)  order by ContractName";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpContract.DataSource = ds;
                drpContract.DataTextField = "ContractName";
                drpContract.DataValueField = "ContractName";
                drpContract.DataBind();
                drpContract.Items.Insert(0, ListItem.FromString("---Select---"));
                drpContract.SelectedIndex = 0;


            }
        }
        protected void btnStatus_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where workstatus='"+drpStatus.SelectedItem+"' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnContract_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where ContractName='" + drpContract.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
      }
    }
