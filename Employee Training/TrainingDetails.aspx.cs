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
    public partial class Training_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
                btnSave.Visible = false;
                btnUpdate.Visible = false;
                txtScore.Text = "0";
                drpStatus.Text = "Unallocated";
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
              
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingEmployeeTrainingDetails(EmpType,Empcode,Name,TrainingTopic,StartDate,EndDate,TotalDays,Trainer,Venue,Score,TrainingStatus,Createdby,Createddate,Modifiedby,Modifieddate)values('" + txtType.Text + "','" + txtEmpcode.Text + "','" + txtEmpName.Text + "','" + txtTopic.Text + "','" + txtStartDate.Text + "','" + txtEnddate.Text + "','" + txtTotaldays.Text + "','" + txtTrainer.Text + "','" + txtVenu.Text + "','" + txtScore.Text + "','" + drpStatus.Text + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;
                ClearTraining();
            }
        }
        protected void ClearTraining()
        {
            txtEmpcode.Text = "";
            txtEmpName.Text = "";
            txtType.Text = "";
            txtTopic.Text = "";
            txtStartDate.Text = "";
            txtEnddate.Text = "";
            txtTotaldays.Text = "";
            txtTrainer.Text = "";
            txtVenu.Text = "";
            txtScore.Text = "";
            drpStatus.Text = "";


        }
        protected void ClearTrainingExceptEmpcode()
        {
          
            txtEmpName.Text = "";
            txtType.Text = "";
            txtTopic.Text = "";
            txtStartDate.Text = "";
            txtEnddate.Text = "";
            txtTotaldays.Text = "";
            txtTrainer.Text = "";
            txtVenu.Text = "";
            txtScore.Text = "";
            drpStatus.Text = "";



        }

        protected void txtEmpcode_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                //DataTable dt = new DataTable();
                //string query = "select Empcode from UDT_MAS_TrainingEmployeeTrainingDetails where Empcode='" + txtEmpcode.Text + "'";
                //SqlCommand cmd = new SqlCommand(query, Common.msConn);
                //SqlDataAdapter sda = new SqlDataAdapter(cmd);
                //sda.Fill(dt);

                //if (dt.Rows.Count > 0)
                //{
                //    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                //    Lblmessage.Text = "Already Exists";
                //    btnSave.Visible = false;
                //    ReadTrainingMaster();
                //    btnSave.Visible = false;
                //    btnUpdate.Visible = true;

                //}
                //else
                //{
                    ReadEmp();
                    //btnSave.Visible = true;
                    //btnUpdate.Visible = false;
                //    Lblmessage.Text = "";
               
                //}
            }
            
           
           
        }
        protected void ReadTrainingMaster()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select EmpType,Name,TrainingTopic,StartDate,EndDate,TotalDays,Trainer,Venue,Score,TrainingStatus     from  UDT_MAS_TrainingEmployeeTrainingDetails(NOLOCK) where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    txtType.Text = reader["EmpType"].ToString();
                    txtEmpName.Text = reader["Name"].ToString();
                    txtTopic.Text = reader["TrainingTopic"].ToString();
                    txtStartDate.Text = reader["StartDate"].ToString();
                    txtEnddate.Text = reader["EndDate"].ToString();
                    txtTotaldays.Text = reader["TotalDays"].ToString();
                    txtTrainer.Text = reader["Trainer"].ToString();
                    txtVenu.Text = reader["Venue"].ToString();
                    txtScore.Text = reader["Score"].ToString();
                    drpStatus.Text = reader["TrainingStatus"].ToString();
                    
                }

                reader.Close();

            }
        }
        protected void ReadEmp()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select Name,EmpType from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtEmpName.Text = reader["Name"].ToString();
                    txtType.Text = reader["EmpType"].ToString();
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                    txtScore.Text = "0";
                    drpStatus.Text = "Unallocated";


                }
                else
                {
                    btnSave.Visible = false;
                    btnUpdate.Visible = false;
                    txtEmpName.Text = "";
                    txtType.Text = "";
                    ClearTrainingExceptEmpcode();
                }

                reader.Close();
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingEmployeeTrainingDetails set TrainingTopic='" + txtTopic.Text + "',StartDate='" + txtStartDate.Text + "',EndDate='" + txtEnddate.Text + "',TotalDays='" + txtTotaldays.Text + "',Trainer='" + txtTrainer.Text + "',Venue='" + txtVenu.Text + "',Score='" + txtScore.Text + "',TrainingStatus='" + drpStatus.Text + "',Modifiedby='" + Session["UserID"].ToString() + "',Modifieddate='" + DateTime.Now + "'  where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Updated Successfully" + txtEmpcode.Text;
            }
        }

        protected void txtEnddate_TextChanged(object sender, EventArgs e)
        {
            if (txtStartDate.Text == "")
            {
                Lblmessage.Text = "You First select the StartDate and then Select enddate";
                txtEnddate.Text = "";
            }
            else
            {
                Lblmessage.Text = "";
                DateTime dt1 = Convert.ToDateTime(txtStartDate.Text);
                DateTime dt2 = Convert.ToDateTime(txtEnddate.Text);

                TimeSpan ts = dt1 - dt2;

                int NoOfdays = ts.Days;
                txtTotaldays.Text = (NoOfdays * (-1)).ToString();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
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

                    drpStatus.Text = "Fail";
                   
                }
                else if (Score >= 80)
                {
                    drpStatus.Text = "Pass";
                   
               

                }
                else if (txtScore.Text == "0")
                {
                    drpStatus.Text = "Unallocated";
                   
                    
                }
            }
        }
    }
}