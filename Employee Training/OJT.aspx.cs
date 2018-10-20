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
    public partial class OJT : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropdownCode();
                btnsubmit.Visible = false;
                btnUpdate.Visible = false;
                if (drpstatus.SelectedValue == "Fail")
                {
                    txtfaildate.Visible = true;
                    Image3.Visible = true;
                }
                else
                {
                    txtfaildate.Visible = false;
                    Image3.Visible = false;

                }
            }
        }

        protected void drpCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtStation();
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select OJTType  from UDT_MAS_TrainingOJT(NOLOCK) where empcode='" + txtEmpcode.Text + "' and Status='Pass' and jobcode='" + drpCode .SelectedItem+ "' order by  id desc";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                   HiddenField1.Value = reader["OJTType"].ToString();
                    if( HiddenField1.Value == "Practical")
                    {
                        txtOJTType.Text = "OJT";
                       // btnsubmit.Visible = true;

                    }
                    else if (HiddenField1.Value == "OJT")
                    {
                        txtOJTType.Text = "Certification";
                        //btnsubmit.Visible = true;
                    }
                    else  if (HiddenField1.Value == "Certification")
                    {
                        txtOJTType.Text = "Recertification";
                       // btnsubmit.Visible = true;

                    }
                   // else if (HiddenField1.Value == "Decertication")
                    else if (HiddenField1.Value == "Recertification")
                    {
                        txtOJTType.Text = "Recertification";
                        //txtOJTType.Text = "";
                        //btnsubmit.Visible = true;
                    }
                   
                   
                  
                }
                else
                {
                    txtOJTType.Text = "Practical";
                    //btnsubmit.Visible = true;



                }

                
                reader.Close();
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
        public void txtStation()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select StationName,ProjectName,Status from UDT_MAS_TrainingJobCardMaster(NOLOCK) where Code='" + drpCode.SelectedItem + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtStationName.Text = reader["StationName"].ToString();
                    txtproject.Text = reader["ProjectName"].ToString();
                    txtStationStatus.Text = reader["Status"].ToString();
                }

                reader.Close();
            }
        }
       
        public void ClearExceptEmpt()
        {
            txtEndDate.Text = "";
            txtfaildate.Text = "";
           txtName.Text = "";
           txtproject.Text = "";
            txtStartDate.Text = "";
            txtStationName.Text = "";
            txtType.Text = "";
            txtOJTType.Text = "";
            txtStationStatus.Text = "";
  


        }
        public void ClearExceptEmpStation()
        {
            txtEndDate.Text = "";
            txtfaildate.Text = "";
            //txtName.Text = "";
           // txtproject.Text = "";
            txtStartDate.Text = "";
           // txtStationName.Text = "";
            //txtType.Text = "";
            txtOJTType.Text = "";
            //txtStationStatus.Text = "";


        }
        public void txtEmpDetails()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select EmpType,Name from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where empcode='" + txtEmpcode.Text + "' and workstatus='Active' and   EmpType in ('CDL','FDL','FTTA','FTTB')";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtType.Text = reader["EmpType"].ToString();
                    txtName.Text = reader["Name"].ToString();
                    //txtproject.Text = reader["Project"].ToString();
                    btnsubmit.Visible = true;
                    btnUpdate.Visible = false;
                   
                }
                else
                {
                    Lblmessage.Text = "Employee Code does not exisit";
                    ClearExceptEmpt();
                    btnsubmit.Visible = false;
                    btnUpdate.Visible = false;
                   
                 

                } 
                reader.Close();
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingOJT(Type,Empcode,Name,JobCode,StationName,Project,OJTType,StartDate,EndDate,FailedDueDate,Status,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate,StationStatus,Score)values('" + txtType.Text + "','" + txtEmpcode.Text + "','" + txtName.Text + "','" + drpCode.SelectedItem + "','" + txtStationName.Text + "','" + txtproject.Text + "','" + txtOJTType.Text + "','" + txtStartDate.Text + "','" + txtEndDate.Text + "','" + txtfaildate.Text + "','" + drpstatus.SelectedItem + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','"+txtStationStatus.Text+"','"+txtScore.Text+"')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;
                ClearExceptEmpt();
                txtEmpcode.Text = "";
            }

        }


        //  protected void ScoreReader()
        //{
        //    if (Common.msConn.State == ConnectionState.Open)
        //    {
        //        SqlDataReader reader = null;
        //        string query = "select Score from  UDT_MAS_TrainingOJT(NOLOCK) where Empcode='" + txtEmpcode.Text + "' and JobCode='" + drpCode.SelectedItem + "' and OJTType='" + txtOJTType.Text + "' order by id desc";
        //        SqlCommand cmd = new SqlCommand(query, Common.msConn);
        //        reader = cmd.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            txtScore.Text = reader["Score"].ToString();
        //        }

        //        reader.Close();

        //    }

        //}
        protected void ReadOJT()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select Type,Empcode,Name,JobCode,StationName,Project,OJTType,StartDate,EndDate,FailedDueDate,Status,StationStatus,Score from  UDT_MAS_TrainingOJT(NOLOCK) where Empcode='" + txtEmpcode.Text + "' order by id desc";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    txtType.Text = reader["Type"].ToString();
                    txtEmpcode.Text = reader["Empcode"].ToString();
                    txtName.Text = reader["Name"].ToString();
                    drpCode.SelectedValue = reader["JobCode"].ToString();
                    txtStationName.Text = reader["StationName"].ToString();
                    txtproject.Text = reader["Project"].ToString();
                    txtOJTType.Text = reader["OJTType"].ToString();
                    txtStartDate.Text = reader["StartDate"].ToString();
                    txtEndDate.Text = reader["EndDate"].ToString();
                    txtfaildate.Text = reader["FailedDueDate"].ToString();
                    drpstatus.SelectedValue = reader["Status"].ToString();
                    txtStationStatus.Text = reader["StationStatus"].ToString();
                    //ScoreReader();

                    if(drpstatus.SelectedValue == "Fail")
                    {
                        btnsubmit.Visible = false;
                        btnUpdate.Visible = true;
                    }
                    else if(drpstatus.SelectedValue == "Pass")
                    {
                if (txtOJTType.Text == "Practical")
                {
                    ClearExceptEmpStation();
                        txtOJTType.Text = "OJT";
                        btnsubmit.Visible = true;
                        btnUpdate.Visible = false;

                    }
                        else if (txtOJTType.Text == "OJT")
                {
                    ClearExceptEmpStation();
                        txtOJTType.Text = "Certification";
                        btnsubmit.Visible = true;
                        btnUpdate.Visible = false;
                    }
                        else if (txtOJTType.Text == "Certification")
                {
                    ClearExceptEmpStation();
                        txtOJTType.Text = "Recertification";
                        btnsubmit.Visible = true;
                        btnUpdate.Visible = false;

                    }
                        //else if (txtOJTType.Text == "Decertication")
                else if (txtOJTType.Text == "Recertification")
                {
                    ClearExceptEmpStation();
                        //txtOJTType.Text = "";
                    txtOJTType.Text = "Recertification";
                        btnsubmit.Visible = true;
                        btnUpdate.Visible = false;
                    }
              else
               {
                   ClearExceptEmpStation();
               txtOJTType.Text = "Practical";
               btnsubmit.Visible = true;
               btnUpdate.Visible = false;
                }

                       
                    }
                }
               
                reader.Close();

            }

        }
        protected void txtEmpcode_TextChanged(object sender, EventArgs e)
        {

            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Empcode from UDT_MAS_TrainingOJT(NOLOCK) where Empcode='" + txtEmpcode.Text + "' order by id desc";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Already Exists";
                 
                    ReadOJT();

                }
                else
                {
                    txtEmpDetails();

                }
            }
       
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingOJT set OJTType='" + txtOJTType.Text + "',StartDate='" + txtStartDate.Text + "',EndDate='" + txtEndDate.Text + "',FailedDueDate='" + txtfaildate.Text + "',Status='" + drpstatus.SelectedItem + "',ModifiedBy='" + Session["UserID"].ToString() + "',ModifiedDate='" + DateTime.Now + "',Score='"+txtScore.Text+"' where Empcode='" + txtEmpcode.Text + "' AND JobCode='" + drpCode.SelectedItem + "' and OJTType='" + txtOJTType.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Empcode Updated Successfully" + txtEmpcode.Text;
                ClearExceptEmpt();
                txtEmpcode.Text = "";
            }
        }

        protected void drpstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(drpstatus.SelectedValue== "Fail")
            {
                txtfaildate.Visible = true;
                Image3.Visible = true;
            }
            else
            {
                txtfaildate.Visible = false;
                Image3.Visible = false;

            }
        }
    }
}