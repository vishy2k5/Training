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
    public partial class IDLInduction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = false;
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string query1 = "insert into UDT_MAS_TrainingIDLInduction(Empcode,Name,DOJ,Dep,Grade,Designation,RepName,RepEmail,Phone,UserId,StartDate,EndDate,FormDistribution,Createdby,Createddate,Modifiedby,Modifieddate,Totaldays)values('" + txtEmpcode.Text + "','" + txtEmpName.Text + "','" + txtDOJ.Text + "','" + txtDep.Text + "','" + txtGrade.Text + "','" + txtDes.Text + "','" + txtRepName.Text + "','" + txtRepEmail.Text + "','" + txtPhone.Text + "','" + txtUserName.Text + "','" + txtStartDate.Text + "','" + txtEndDate.Text + "','" + drpForm.SelectedValue + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + txttotal.Text+ "')";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;
                ClearIDL();
            }
        }
        protected void ClearIDLExpectEmpcode()
        {
           
            txtEmpName.Text = "";
            txtDOJ.Text = "";
            txtDep.Text = "";
            txtGrade.Text = "";
            txtDes.Text = "";
            txtRepName.Text = "";
            txtRepEmail.Text = "";
            txtPhone.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
            txtUserName.Text = "";
            drpForm.SelectedValue = "";
            txttotal.Text = "";


        }
        protected void ClearIDL()
        {
            txtEmpcode.Text = "";
            txtEmpName.Text = "";
            txtDOJ.Text = "";
            txtDep.Text = "";
            txtGrade.Text = "";
            txtDes.Text = "";
            txtRepName.Text = "";
            txtRepEmail.Text = "";
            txtPhone.Text = "";
            //txtStartDate.Text = "";
            //txtEndDate.Text = "";
            txtUserName.Text = "";
            //drpForm.SelectedValue= "";
            //txttotal.Text = "";


        }

        protected void txtEmpcode_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Empcode from UDT_MAS_TrainingIDLInduction(NOLOCK) where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Already Exists";
                    btnSave.Visible = false;
                    btnUpdate.Visible = true;
                    ReadIDLMaster();

                }
                else
                {
                    ReadEmp();                  
                    
                }
            }
            
           
        }
        protected void ReadIDLMaster()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select Name,DOJ,Dep,Grade,Designation,RepName,RepEmail,Phone,UserId,StartDate,EndDate,FormDistribution,Totaldays from  UDT_MAS_TrainingIDLInduction(NOLOCK) where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                
                    txtEmpName.Text = reader["Name"].ToString();
                    txtDOJ.Text = reader["DOJ"].ToString();
                    txtDep.Text = reader["Dep"].ToString();
                    txtGrade.Text = reader["Grade"].ToString();
                    txtDes.Text = reader["Designation"].ToString();
                    txtRepName.Text = reader["RepName"].ToString();
                    txtRepEmail.Text = reader["RepEmail"].ToString();
                    txtPhone.Text = reader["Phone"].ToString();
                    txtUserName.Text = reader["UserId"].ToString();
                    txtStartDate.Text = reader["StartDate"].ToString();
                    txtEndDate.Text = reader["EndDate"].ToString();
                    drpForm.SelectedValue = reader["FormDistribution"].ToString();
                    txttotal.Text = reader["Totaldays"].ToString();

                }

                reader.Close();

            }
           
            
        }

        protected void ReadEmp()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                SqlDataReader reader = null;
                string query = "select Name,DOJ,Dep,Grade,Designation,RepName,RepEmail,UserName,phone from UDT_MAS_TrainingEmployeeMaster(NOLOCK) where Empcode='" + txtEmpcode.Text + "' and EmpType in ('IDL ( FTTG & GET)','IDL')  and workstatus='Active'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtEmpName.Text = reader["Name"].ToString();
                    txtDOJ.Text = reader["DOJ"].ToString();
                    txtDep.Text = reader["Dep"].ToString();
                    txtGrade.Text = reader["Grade"].ToString();
                    txtDes.Text = reader["Designation"].ToString();
                    txtRepName.Text = reader["RepName"].ToString();
                    txtRepEmail.Text = reader["RepEmail"].ToString();
                    txtUserName.Text = reader["UserName"].ToString();
                    txtPhone.Text = reader["phone"].ToString();
                    Lblmessage.Text = "";
                    btnSave.Visible = true;
                    btnUpdate.Visible = false;
                }
                else
                {
                    Lblmessage.Text = "Employee Code does not exisit in IDL";
                    btnSave.Visible = false;
                    btnUpdate.Visible = false;
                    ClearIDLExpectEmpcode();
                }
                reader.Close();
              
              
            }
           
           
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
          
            if (Common.msConn.State == ConnectionState.Open)
            {

                string query1 = "Update UDT_MAS_TrainingIDLInduction set Name='" + txtEmpName.Text + "',DOJ='" + txtDOJ.Text + "',Dep='" + txtDep.Text + "',Grade='" + txtGrade.Text + "',Designation='" + txtDes.Text + "',RepName='" + txtRepName.Text + "',RepEmail='" + txtRepEmail.Text + "',Phone='" + txtPhone.Text + "',UserId='" + txtUserName.Text + "',StartDate='" + txtStartDate.Text + "',EndDate='" + txtEndDate.Text + "',FormDistribution='" + drpForm.SelectedItem + "',Modifiedby='" + Session["UserID"].ToString() + "',Modifieddate='" + DateTime.Now + "',Totaldays='"+txttotal.Text+"'  where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Updated Successfully" + txtEmpcode.Text;
                ClearIDL();
            }
        }

        protected void txtEndDate_TextChanged(object sender, EventArgs e)
        {

            //if (txtStartDate.Text == "" || txtEndDate.Text == "")
            //{
            //    txtStartDate.Text = "0";
            //    txtEndDate.Text = "0";
            //    txttotal.Text = "0";
            //}
            //else
            //{
                DateTime dt1 = Convert.ToDateTime(txtStartDate.Text);
                DateTime dt2 = Convert.ToDateTime(txtEndDate.Text);

                TimeSpan ts = dt1 - dt2;

                int NoOfdays = ts.Days;
                txttotal.Text = (NoOfdays * (-1)).ToString();
                btnSave.Visible = true;
                btnUpdate.Visible = false;
               
            //}
          
        }
    }
}