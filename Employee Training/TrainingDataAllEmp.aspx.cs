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
    public partial class TrainingDataAllEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (!IsPostBack)
            {
                txtScore.Text = "0";
                btnSave.Visible = false;
                drpStatus.Text = "Unallocated";
                truncateTable();
            }
        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
        
             if (Common.msConn.State == ConnectionState.Open)
            {
             
                string query1 = "INSERT INTO UDT_MAS_TrainingEmployeeTrainingDetails_Temp (Empcode, EmpType,Name)SELECT Empcode, EmpType,Name FROM UDT_MAS_TrainingEmployeeMaster where Empcode='"+txtEmpcode.Text+"'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
               
                bindsample();
                btnSave.Visible = true;
            }
             if (Common.msConn.State == ConnectionState.Open)
             {

                 string query1 = "update UDT_MAS_TrainingEmployeeTrainingDetails_Temp set Score='" + txtScore.Text + "',TrainingStatus='" + drpStatus.Text + "'   where Empcode='" + txtEmpcode.Text + "'";
                 SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                 cmd1.ExecuteNonQuery();
                
                 bindsample();
                 btnSave.Visible = true;
             }

        }
        protected void UpdateTemp()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "update UDT_MAS_TrainingEmployeeTrainingDetails_Temp set TrainingTopic='"+txtTopic.Text+"',StartDate='"+txtStartDate.Text+"',EndDate='"+txtEnddate.Text+"',TotalDays='"+txtTotaldays.Text+"',Trainer='"+txtTrainer.Text+"',Venue='"+txtVenu.Text+"',Score='"+txtScore.Text+"',TrainingStatus='"+drpStatus.Text+"',Createdby='"+ Session["UserID"].ToString()+"',Createddate='"+ DateTime.Now+"',Modifiedby='"+ Session["UserID"].ToString()+"',Modifieddate='"+ DateTime.Now+"'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                //Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;



            }

        }

        protected void btnSave_Click(object sender, System.EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                UpdateTemp();
                string query1 = "INSERT INTO UDT_MAS_TrainingEmployeeTrainingDetails (EmpType,Empcode,Name,TrainingTopic,StartDate,EndDate,TotalDays,Trainer,Venue,Score,TrainingStatus,Createdby,Createddate,Modifiedby,Modifieddate) SELECT EmpType,Empcode,Name,TrainingTopic,StartDate,EndDate,TotalDays,Trainer,Venue,Score,TrainingStatus,Createdby,Createddate,Modifiedby,Modifieddate FROM UDT_MAS_TrainingEmployeeTrainingDetails_Temp";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                truncateTable();
                Lblmessage.Text = "Saved Successfully"; 
                btnSave.Visible = false;
                txtEmpcode.Text = "";
                txtEnddate.Text = "";
                txtScore.Text = "0";
                txtStartDate.Text = "";
                txtTopic.Text = "";
                txtTotaldays.Text = "";
                txtTrainer.Text = "";
                txtVenu.Text = "";


            }

        }
        protected void bindsample()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();

                string query = "select * from UDT_MAS_TrainingEmployeeTrainingDetails_Temp(NOLOCK) ";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
          
        }
        protected void truncateTable()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "Truncate table UDT_MAS_TrainingEmployeeTrainingDetails_Temp";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
               



            }

        }

        protected void txtEnddate_TextChanged(object sender, System.EventArgs e)
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
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
                int id = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Value);
                SqlCommand cmd = new SqlCommand("Delete from UDT_MAS_TrainingEmployeeTrainingDetails_Temp where Id='" + id + "'", Common.msConn);
      
                cmd.ExecuteNonQuery();
                bindsample();
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