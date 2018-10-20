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
    public partial class OJTRep : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               DropStationName();
               Dropcreatedby();
               DropdownContract();
               DropProject();
               btnExcelDown.Visible = false;
            }
        }
    
        public void DropStationName()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select StationName from UDT_MAS_TrainingJobCardMaster(NOLOCK)";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpStation.DataSource = ds;
                drpStation.DataTextField = "StationName";
                drpStation.DataValueField = "StationName";
                drpStation.DataBind();
                drpStation.Items.Insert(0, ListItem.FromString("---Select---"));
                drpStation.SelectedIndex = 0;
            }
        }
        public void Dropcreatedby()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct  Createdby from UDT_MAS_TrainingOJT(NOLOCK)";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpcreatedby.DataSource = ds;
                drpcreatedby.DataTextField = "Createdby";
                drpcreatedby.DataValueField = "Createdby";
                drpcreatedby.DataBind();
                drpcreatedby.Items.Insert(0, ListItem.FromString("---Select---"));
                drpcreatedby.SelectedIndex = 0;
            }
        }
        public void DropProject()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct  Project from UDT_MAS_TrainingOJT(NOLOCK)";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpProject.DataSource = ds;
                drpProject.DataTextField = "Project";
                drpProject.DataValueField = "Project";
                drpProject.DataBind();
                drpProject.Items.Insert(0, ListItem.FromString("---Select---"));
                drpProject.SelectedIndex = 0;
            }
        }
     
         public override void VerifyRenderingInServerForm(Control control)
        {
            /* Verifies that the control is rendered */
        }
        protected void btnDate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,OJT.FailedDueDate,OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where    OJT.EndDate between '" + txtFromDate.Text + "' and '" + txtToDate.Text + "' and OJT.Status='Pass'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;
        }

        protected void btnExcelDown_Click(object sender, EventArgs e)
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

        protected void btnStation_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,OJT.FailedDueDate,OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where    OJT.StationName= '" + drpStation.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;
        }

        protected void btnEmpcode_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,REPLACE(ISNULL(CONVERT(DATE, OJT.FailedDueDate), ''), '1900-01-01', '') AS 'FailedDueDate',OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where    OJT.Empcode= '" + txtEmpcode.Text + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;
        }

        protected void btnStationStatus_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,OJT.FailedDueDate,OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where    OJT.StationStatus= '" + drpStationStatus.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;
        }

        protected void btncreatedby_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,OJT.FailedDueDate,OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where    OJT.createdby= '" + drpcreatedby.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;
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
                drpContact.DataSource = ds;
                drpContact.DataTextField = "ContractName";
                drpContact.DataValueField = "ContractName";
                drpContact.DataBind();
                drpContact.Items.Insert(0, ListItem.FromString("---Select---"));
                drpContact.SelectedIndex = 0;


            }
        }
        protected void btnContract_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,OJT.FailedDueDate,OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where mas.ContractName= '" + drpContact.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
              
            if (Common.msConn.State == ConnectionState.Open)
            {
                GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
                int Id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
                SqlCommand cmd = new SqlCommand("delete from UDT_MAS_TrainingOJT where Id='" + Id + "'", Common.msConn);
                cmd.ExecuteNonQuery();
               
            }
                        
        }

        protected void btnProject_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select OJT.Id,OJT.Type,OJT.Empcode,OJT.Name,MAS.ContractName,OJT.JobCode,OJT.StationName,OJT.StationStatus,OJT.Project,OJT.OJTType,OJT.StartDate,OJT.EndDate,OJT.FailedDueDate,OJT.Score,OJT.[Status],OJT.CreatedBy,OJT.CreatedDate  from UDT_MAS_TrainingOJT OJT inner join UDT_MAS_TrainingEmployeeMaster MAS on MAS.Empcode = OJT.Empcode where OJT.Project= '" + drpProject.SelectedItem + "' ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            btnExcelDown.Visible = true;

        }
    }
}