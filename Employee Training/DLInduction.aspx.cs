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
    public partial class DLInduction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (txtScore.Text == "0")
            {
                drpTraStatus.Text = "Unallocated";
                txtHandOverDate.Visible = false;
                drpHandoverStatus.Visible = false;
                Image3.Visible = false;
            }
            if (!IsPostBack)
            {
                BtnSave.Visible = false;
                BtnUpdate.Visible = false;
            }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            if (drpHandoverStatus.SelectedValue == "Present")
            {
                if (txtHandOverDate.Text == "")
                {
                    Lblmessage.Text = "HandOverDate should be Mandetory";

                }
                else
                {
                    Lblmessage.Text = "";
                    if (Common.msConn.State == ConnectionState.Open)
                    {
                        string query1 = "insert into UDT_MAS_TrainingDLInduction(Empcode,Name,EmpType,Gender,Dep,Project,Topics,Trainer,StartDate,EndDate,TotalDays,Score,TrainingStatus,HandOverDate,HandOverStatus,RepName,RepEmail,Type,Shift,Createdby,Createddate,Modifiedby,Mdifieddate)values('" + txtEmpcode.Text + "','" + txtEmpName.Text + "','" + txtType.Text + "','" + txtGender.Text + "','" + txtDep.Text + "','" + txtProj.Text + "','" + txtTopics.Text + "','" + txtTrainer.Text + "','" + txtStartDate.Text + "','" + txtEndDate.Text + "','" + txtTotalDays.Text + "','" + txtScore.Text + "','" + drpTraStatus.Text + "','" + txtHandOverDate.Text + "','" + drpHandoverStatus.SelectedValue + "','" + txtRepName.Text + "','" + txtRepEmail.Text + "','" + txtType.Text + "','" + txtShift.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "')";
                        SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                        cmd1.ExecuteNonQuery();
                        Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;
                        ClearDL();
                    }

                }

            }
            else
            {
                if (Common.msConn.State == ConnectionState.Open)
                {
                    string query1 = "insert into UDT_MAS_TrainingDLInduction(Empcode,Name,EmpType,Gender,Dep,Project,Topics,Trainer,StartDate,EndDate,TotalDays,Score,TrainingStatus,HandOverDate,HandOverStatus,RepName,RepEmail,Type,Shift,Createdby,Createddate,Modifiedby,Mdifieddate)values('" + txtEmpcode.Text + "','" + txtEmpName.Text + "','" + txtType.Text + "','" + txtGender.Text + "','" + txtDep.Text + "','" + txtProj.Text + "','" + txtTopics.Text + "','" + txtTrainer.Text + "','" + txtStartDate.Text + "','" + txtEndDate.Text + "','" + txtTotalDays.Text + "','" + txtScore.Text + "','" + drpTraStatus.Text + "','" + txtHandOverDate.Text + "','" + drpHandoverStatus.SelectedValue + "','" + txtRepName.Text + "','" + txtRepEmail.Text + "','" + txtType.Text + "','" + txtShift.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "')";
                    SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                    cmd1.ExecuteNonQuery();
                    Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;
                    ClearDL();
                }
            }
            
           
        }

        protected void txtEmpcode_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Empcode from UDT_MAS_TrainingDLInduction(NOLOCK) where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Already Exists";
                    BtnSave.Visible = false;
                    BtnUpdate.Visible = true;
                   
                    ReadDLMaster();
                    
                }
                else
                {
                    ReadEmp();
                               
                   // ClearDLExpectEmpcode();
                }
            }
            
        }
        protected void ReadDLMaster()
        {
      
        
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select Name,EmpType,Gender,Dep,Project,Topics,Trainer,StartDate,EndDate,TotalDays,Score,TrainingStatus,HandOverDate,HandOverStatus,RepName,RepEmail,Type,Shift from UDT_MAS_TrainingDLInduction(NOLOCK) where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEmpName.Text = reader["Name"].ToString();
                    txtType.Text = reader["EmpType"].ToString();
                    txtGender.Text = reader["Gender"].ToString();
                    txtDep.Text = reader["Dep"].ToString();
                    txtProj.Text = reader["Project"].ToString();
                    txtTopics.Text = reader["Topics"].ToString();
                    txtTrainer.Text = reader["Trainer"].ToString();
                    txtStartDate.Text = reader["StartDate"].ToString();
                    txtEndDate.Text = reader["EndDate"].ToString();
                    txtTotalDays.Text = reader["TotalDays"].ToString();
                    txtScore.Text = reader["Score"].ToString();

                    if (txtScore.Text == "")
                    {
                        txtScore.Text = "0";
                    }
                    else
                    {
                        Decimal Score = Convert.ToDecimal(txtScore.Text);
                            //ToInt32



                        if (Score < 80 && Score > 0)
                        {

                            drpTraStatus.Text = "Fail";
                            txtHandOverDate.Visible = false;
                            drpHandoverStatus.Visible = false;
                            Image3.Visible = false;
                        }
                        else if (Score >= 80)
                        {
                            drpTraStatus.Text = "Pass";
                            txtHandOverDate.Visible = true;
                            drpHandoverStatus.Visible = true;
                            Image3.Visible = true;

                        }
                        else if (txtScore.Text == "0")
                        {
                            drpTraStatus.Text = "Unallocated";
                            txtHandOverDate.Visible = false;
                            drpHandoverStatus.Visible = false;
                            Image3.Visible = false;
                        }
                    }
                    drpTraStatus.Text = reader["TrainingStatus"].ToString();
                    txtHandOverDate.Text = reader["HandOverDate"].ToString();
                    drpHandoverStatus.SelectedValue = reader["HandOverStatus"].ToString();
                    txtRepName.Text = reader["RepName"].ToString();
                    txtRepEmail.Text = reader["RepEmail"].ToString();
                    txtShift.Text = reader["Shift"].ToString();

                }

                reader.Close();

            }
        }
        protected void ReadEmp()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select Name,Gender,Dep,Project,EmpType,RepName,RepEmail from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where Empcode='" + txtEmpcode.Text + "' and EmpType in ('CDL','FDL','FTTA','FTTB')  and workstatus='Active'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtEmpName.Text = reader["Name"].ToString();
                    txtGender.Text = reader["Gender"].ToString();
                    txtDep.Text = reader["Dep"].ToString();
                    txtProj.Text = reader["Project"].ToString();
                    txtType.Text = reader["EmpType"].ToString();
                    txtRepName.Text = reader["RepName"].ToString();
                    txtRepEmail.Text = reader["RepEmail"].ToString();
                    Lblmessage.Text = "";
                    BtnSave.Visible = true;
                    BtnUpdate.Visible = false;
                    txtScore.Text = "0";
                    txtHandOverDate.Text = "";

                    if (txtScore.Text == "0")
                    {
                        drpTraStatus.Text = "Unallocated";
                        txtHandOverDate.Visible = false;
                        drpHandoverStatus.Visible = false;
                        Image3.Visible = false;
                    }

                }
                else
                {
                    Lblmessage.Text = "Employee Code does not exisit in DL";
                    ClearDLExpectEmpcode();
                    BtnSave.Visible = false;
                    BtnUpdate.Visible = false; 

                }
               

                reader.Close();

            }
        }
        protected void ClearDLExpectEmpcode()
        {
         
            txtEmpName.Text = "";
            txtGender.Text = "";
            txtDep.Text = "";
            txtProj.Text = "";
            txtShift.Text = "";
            txtType.Text = "";
            //txtTopics.Text = "";
            txtTrainer.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtTotalDays.Text = "";
            txtScore.Text = ""; 
            txtRepEmail.Text = ""; txtRepName.Text = ""; 
            txtHandOverDate.Text = "";


        }
        protected void ClearDL()
        {
            txtEmpcode.Text = "";
            txtEmpName.Text = "";
            txtGender.Text = "";
            txtDep.Text = "";
            txtProj.Text = "";
            txtShift.Text = "";
            txtType.Text = "";
            //txtTopics.Text = "";
            //txtTrainer.Text = "";
            //txtStartDate.Text = "";
            //txtEndDate.Text = "";
            //txtTotalDays.Text = "";
            txtScore.Text = "0";
            if (txtScore.Text == "0")
            {
                drpTraStatus.Text = "Unallocated";
                txtHandOverDate.Visible = false;
                txtHandOverDate.Text = "";
                drpHandoverStatus.Visible = false;

                Image3.Visible = false;
            }

            txtRepEmail.Text = ""; txtRepName.Text = ""; 
            txtHandOverDate.Text = "";
            

        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (drpHandoverStatus.SelectedValue == "Present")
            {
                if (txtHandOverDate.Text == "")
                {
                    Lblmessage.Text = "HandOverDate should be Mandetory";

                }
                else
                {
                    Lblmessage.Text = "";
                        if (Common.msConn.State == ConnectionState.Open)
                        {

                            string query1 = "Update UDT_MAS_TrainingDLInduction set Name='"+txtEmpName.Text+"',EmpType='"+txtType.Text+"',Gender='"+txtGender.Text+"',Dep='"+txtDep.Text+"',Project='"+txtProj.Text+"',Shift='"+txtShift.Text+"',Topics='" + txtTopics.Text + "',Trainer='" + txtTrainer.Text + "',StartDate='" + txtStartDate.Text + "',EndDate='" + txtEndDate.Text + "',TotalDays='" + txtTotalDays.Text + "',Score='" + txtScore.Text + "',TrainingStatus='" + drpTraStatus.Text + "',HandOverDate='" + txtHandOverDate.Text + "', HandOverStatus='" + drpHandoverStatus.SelectedItem + "',RepName='" + txtRepName.Text + "',RepEmail='" + txtRepEmail.Text + "',Modifiedby='" + Session["UserID"].ToString() + "',Mdifieddate='" + DateTime.Now + "'  where Empcode='" + txtEmpcode.Text + "'";
                            SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                            cmd1.ExecuteNonQuery();
                            Lblmessage.Text = "Updated Successfully" + txtEmpcode.Text;
                            ClearDL();
                        }
                }

            }
            else
            {
                if (Common.msConn.State == ConnectionState.Open)
                {

                    string query1 = "Update UDT_MAS_TrainingDLInduction set Name='" + txtEmpName.Text + "',EmpType='" + txtType.Text + "',Gender='" + txtGender.Text + "',Dep='" + txtDep.Text + "',Project='" + txtProj.Text + "',Shift='" + txtShift.Text + "',Topics='" + txtTopics.Text + "',Trainer='" + txtTrainer.Text + "',StartDate='" + txtStartDate.Text + "',EndDate='" + txtEndDate.Text + "',TotalDays='" + txtTotalDays.Text + "',Score='" + txtScore.Text + "',TrainingStatus='" + drpTraStatus.Text + "',HandOverDate='" + txtHandOverDate.Text + "', HandOverStatus='" + drpHandoverStatus.SelectedItem + "',RepName='" + txtRepName.Text + "',RepEmail='" + txtRepEmail.Text + "',Modifiedby='" + Session["UserID"].ToString() + "',Mdifieddate='" + DateTime.Now + "'  where Empcode='" + txtEmpcode.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                    cmd1.ExecuteNonQuery();
                    Lblmessage.Text = "Updated Successfully" + txtEmpcode.Text;
                    ClearDL();
                }
            }
        }

        protected void txtEndDate_TextChanged(object sender, EventArgs e)
        {
            if(txtStartDate.Text =="")
        {
            Lblmessage.Text = "You First select the StartDate and then Select enddate";
            txtEndDate.Text = "";
        }
            else
            {  
            DateTime dt1 = Convert.ToDateTime(txtStartDate.Text);
            DateTime dt2 = Convert.ToDateTime(txtEndDate.Text);

            TimeSpan ts = dt1 - dt2;

            int NoOfdays = ts.Days;
            txtTotalDays.Text = (NoOfdays*(-1)).ToString();
            BtnSave.Visible = true;
            BtnUpdate.Visible = false;
            Lblmessage.Text = "";

            }

          

        }

        protected void txtScore_TextChanged(object sender, EventArgs e)
        {
            
            if (txtScore.Text == "")
            {
                txtScore.Text = "0";
            }
            else
            {
                int Score = Convert.ToInt32(txtScore.Text);



                if (Score < 80 && Score > 0)
            {            
                
                drpTraStatus.Text = "Fail";
                txtHandOverDate.Visible = false;
                txtHandOverDate.Text = "";
                drpHandoverStatus.Visible = false;
              
                Image3.Visible = false;
            }
            else if (Score >= 80)
            {
                drpTraStatus.Text = "Pass";
                txtHandOverDate.Visible = true;
                drpHandoverStatus.Visible = true;
                Image3.Visible = true;
              
            }
            else if (txtScore.Text == "0")
            {
                drpTraStatus.Text = "Unallocated";
                txtHandOverDate.Visible = false;
                txtHandOverDate.Text = "";
                drpHandoverStatus.Visible = false;
               
                Image3.Visible = false;
            }
            }
        }

        protected void drpHandoverStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
         if(drpHandoverStatus.SelectedValue == "Present")
          {
                if(txtHandOverDate.Text == "")
                {
                    Lblmessage.Text = "HandOverDate should be Mandetory";

                }
                else
                {
                    Lblmessage.Text = "";

   
                }
             
  }
        
        }
    }
}