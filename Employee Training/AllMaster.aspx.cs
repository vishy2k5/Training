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
    public partial class AllMaster : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int s;
            btnDepSave.Visible = false;
            btnDepUpdate.Visible = false;
            //btnDesSave.Visible = false;
            //btnDesUpdate.Visible = false;
            btnEduSave.Visible = false;
            btnEduUpdate.Visible = false;
            btnCommonSave.Visible = false;
            btnCommonUpdate.Visible = false;
            btnLocSave.Visible = false;
            btnLocUpdate.Visible = false;
            btnProjectSave.Visible = false;
            btnProUpdate.Visible = false;
            btnContractSave.Visible = false;
            btncontractUpdate.Visible = false;
            DropdownType();
        }
     

        protected void btnDepSave_Click(object sender, EventArgs e)
        {

            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingDepartment(Department,Createdby,Createddate,Status)values('" + txtDep.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + drpDepStatus.SelectedValue + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Department Saved Successfully" + txtDep.Text;
                Clear();

            }


        }
        protected void Clear()
        {
            txtDep.Text = "";
            txtDes.Text = "";
            txtEdu.Text = "";
            txtGrade.Text = "";
            txtContract.Text = "";
            txtLoc.Text = "";
            txtProject.Text = "";
        }


        protected void txtDep_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Department from UDT_MAS_TrainingDepartment(NOLOCK) where Department='" + txtDep.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = " Department Already Exists";
                    btnDepSave.Visible = false;
                    btnDepUpdate.Visible = true;

                }
                else
                {
                    btnDepSave.Visible = true;
                    btnDepUpdate.Visible = false;
                }

            }
        }

        protected void btnDepUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingDepartment set Department='" + txtDep.Text + "',Createdby='" + Session["UserID"].ToString() + "',Createddate='" + DateTime.Now + "',Status='" + drpDepStatus.SelectedValue + "' where   Department='" + txtDep.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Department Updated Successfully" + txtDep.Text;
                Clear();
            }
        }

       

        protected void txtEdu_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select education from UDT_MAS_TrainingEducation(NOLOCK) where education='" + txtEdu.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Education Already Exists";
                    btnEduSave.Visible = false;
                    btnEduUpdate.Visible = true;

                }
                else
                {
                    btnEduSave.Visible = true;
                    btnEduUpdate.Visible = false;
                }

            }
        }

        protected void btnEduSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingEducation(education,Createdby,Createddate,Status)values('" + txtEdu.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + drpEduStatus.SelectedValue + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Education Saved Successfully" + txtEdu.Text;
                Clear();
            }
        }

        protected void btnEduUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingEducation set education='" + txtEdu.Text + "',Createdby='" + Session["UserID"].ToString() + "',Createddate='" + DateTime.Now + "',Status='" + drpEduStatus.SelectedValue + "' where education='" + txtEdu.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Education Updated Successfully" + txtEdu.Text;
                Clear();
            }
        }

        

        
        protected void btnGradeUpdate_Click(object sender, EventArgs e)
        {
           
        }

        protected void txtLoc_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Location from UDT_MAS_TrainingLocation(NOLOCK) where Location='" + txtLoc.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = " Location Already Exists";
                    btnLocSave.Visible = false;
                    btnLocUpdate.Visible = true;

                }
                else
                {
                    btnLocSave.Visible = true;
                    btnLocUpdate.Visible = false;
                }

            }

        }

        protected void btnLocSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingLocation(Location,Createdby,Createddate,Status)values('" + txtLoc.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + drpLocStatus.SelectedValue + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Location Saved Successfully" + txtLoc.Text;
                Clear();
            }
        }

        protected void btnLocUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingLocation set Location='" + txtLoc.Text + "',Createdby='" + Session["UserID"].ToString() + "',Createddate='" + DateTime.Now + "',Status='" + drpLocStatus.SelectedValue + "' where  Location='" + txtLoc.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Location Updated Successfully" + txtLoc.Text;
                Clear();
            }
        }

        protected void txtProject_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Project from UDT_MAS_TrainingProject(NOLOCK) where Project='" + txtProject.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Project Already Exists";
                    btnProjectSave.Visible = false;
                    btnProUpdate.Visible = true;

                }
                else
                {
                    btnProjectSave.Visible = true;
                    btnProUpdate.Visible = false;
                }
            }
        }

        protected void btnProjectSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingProject(Project,Createdby,Createddate,Status)values('" + txtProject.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + drpProStatus.SelectedValue + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Project Saved Successfully" + txtProject.Text;
                Clear();
            }

        }

        protected void btnProUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingProject set Project='" + txtProject.Text + "',Createdby='" + Session["UserID"].ToString() + "',Createddate='" + DateTime.Now + "',Status='" + drpProStatus.SelectedValue + "' where Project='" + txtProject.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Project Updated Successfully" + txtProject.Text;
                Clear();
            }

        }

      

        protected void btnCommonSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingDesGraType(Designation,Grade,Type,Createdby,Createddate,Status)values('" + txtDes.Text + "','" + txtGrade.Text + "','" + drpType.SelectedItem + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + drpCommonStatus.SelectedValue + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = " Saved Successfully" + txtGrade.Text;
                Clear();
            }
        }

        protected void btnCommonUpdate_Click(object sender, EventArgs e)
        { if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingDesGraType set Designation='" + txtDes.Text + "',Grade='" + txtGrade.Text + "',Type='" + drpType.SelectedValue + "',Createdby='" + Session["UserID"].ToString() + "',Createddate='" + DateTime.Now + "',Status='" + drpCommonStatus.SelectedValue + "' where  Designation='" + txtDes.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = " Updated Successfully" + txtGrade.Text;
                Clear();
            }

        }
        public void DropdownType()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct Type from UDT_MAS_TrainingDesGraType(nolock) where  status=1  order by Type ";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpType.DataSource = ds;
                drpType.DataTextField = "Type";
                drpType.DataValueField = "Type";
                drpType.DataBind();
                //drpType.Items.Insert(0, ListItem.FromString("---Select---"));
                drpType.SelectedIndex = 0;


            }
        }
        protected void txtDes_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                DataTable dt = new DataTable();
                string query = "select Designation,Grade,Type from UDT_MAS_TrainingDesGraType(NOLOCK) where Designation='" + txtDes.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtDes.Text = reader["Designation"].ToString();
                    txtGrade.Text = reader["Grade"].ToString();
                    drpType.SelectedValue = reader["Type"].ToString();
                }
                reader.Close();
                    if (dt.Rows.Count > 0)
                    {
                       
                        Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                        Lblmessage.Text = " Designation Already Exists";
                        btnCommonSave.Visible = false;
                        btnCommonUpdate.Visible = true;

                    }
                    else
                    {
                        btnCommonSave.Visible = true;
                        btnCommonUpdate.Visible = false;
                    }
              
            }
        }

        protected void btnContractSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingContractName(ContractName,Status,Createdby,Createddate)values('" + txtContract.Text + "','" + drpProStatus.SelectedValue + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = " Saved Successfully" + txtContract.Text;
                Clear();
            }
        }

        protected void txtContract_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select ContractName from UDT_MAS_TrainingContractName(NOLOCK) where ContractName='" + txtContract.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Contract Already Exists";
                    btnContractSave.Visible = false;
                    btncontractUpdate.Visible = true;

                 

                }
                else
                {
                    btnContractSave.Visible = true;
                    btncontractUpdate.Visible = false;
                }

            }
           
        }

        protected void btncontractUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingContractName set ContractName='" + txtContract.Text + "',Createdby='" + Session["UserID"].ToString() + "',Createddate='" + DateTime.Now + "',Status='" + drpContract.SelectedValue + "' where ContractName='" + txtContract.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "ContractName Updated Successfully" + txtEdu.Text;
                Clear();
            }
        }
    }
}