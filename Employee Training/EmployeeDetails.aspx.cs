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
    public partial class EmployeeDetails : System.Web.UI.Page
    {
        string ErrorFlag;
        string updateflag;
        protected void Page_Load(object sender, EventArgs e)
        {

            //DropdownDepartment(); DropdownProject(); DropdownLocation();
            //DropdownEducation();
            //DropdownStatus();
            //DropdownDesignation();
            

           if (!IsPostBack)
            {
                DropdownDepartment(); DropdownProject(); DropdownLocation();
                DropdownEducation();
                DropdownStatus();
                DropdownDesignation();
                DropdownContract();
                typeload();
                Gradeload();
               btnsave.Visible = false;
               btnUpdate.Visible = false; 
            }

        }
        public void DropdownDepartment()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct Department from UDT_MAS_TrainingDepartment(nolock) where  status=1  order by Department ";
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
        public void Gradeload()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct Grade from UDT_MAS_TrainingDesGraType (nolock) where  status=1 order by Grade";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpGrade.DataSource = ds;
                drpGrade.DataTextField = "Grade";
                drpGrade.DataValueField = "Grade";
                drpGrade.DataBind();
                drpGrade.Items.Insert(0, ListItem.FromString("---Select---"));
                drpGrade.SelectedIndex = 0;


            }
        }
        public void typeload()
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
        public void DropdownProject()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct project from UDT_MAS_TrainingProject(nolock) where  status=1  order by project ";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpProj.DataSource = ds;
                drpProj.DataTextField = "project";
                drpProj.DataValueField = "project";
                drpProj.DataBind();
                drpProj.Items.Insert(0, ListItem.FromString("---Select---"));
                drpProj.SelectedIndex = 0;
               

            }
        }
        public void DropdownLocation()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct Location from UDT_MAS_TrainingLocation(nolock) where  status=1  order by Location";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpLoc.DataSource = ds;
                drpLoc.DataTextField = "Location";
                drpLoc.DataValueField = "Location";
                drpLoc.DataBind();
                drpLoc.Items.Insert(0, ListItem.FromString("---Select---"));
                drpLoc.SelectedIndex = 0;
       

            }
        }
        public void DropdownDesignation()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select Distinct  Designation from  UDT_MAS_TrainingDesGraType(nolock) where  status=1 ";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpDes.DataSource = ds;
                drpDes.DataTextField = "Designation";
                drpDes.DataValueField = "Designation";
                drpDes.DataBind();
                drpDes.Items.Insert(0, ListItem.FromString("---Select---"));
                drpDes.SelectedIndex = 0;
              
              
            }
        }
        public void DropdownEmpType()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct  Type from UDT_MAS_TrainingDesGraType(nolock) where  status=1 and Designation='" + drpDes.SelectedItem+ "'  order by Type";
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
        public void DropdownGrade()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct Grade from UDT_MAS_TrainingDesGraType (nolock) where  status=1 and Designation='" + drpDes.SelectedItem + "'  order by Grade";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpGrade.DataSource = ds;
                drpGrade.DataTextField = "Grade";
                drpGrade.DataValueField = "Grade";
                drpGrade.DataBind();
                drpGrade.Items.Insert(0, ListItem.FromString("---Select---"));
                drpGrade.SelectedIndex = 0;
            

            }
        }
        public void DropdownEducation()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct education from UDT_MAS_TrainingEducation(nolock) where  status=1  order by education";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpEducation.DataSource = ds;
                drpEducation.DataTextField = "education";
                drpEducation.DataValueField = "education";
                drpEducation.DataBind();
                drpEducation.Items.Insert(0, ListItem.FromString("---Select---"));
                drpEducation.SelectedIndex = 0;
               

            }
        }
        public void DropdownContract()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct ContractName from UDT_MAS_TrainingContractName(nolock) where  status=1  order by ContractName";
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

        protected void btnsave_Click(object sender, EventArgs e)
        {
            Validation();

            if (ErrorFlag == "")
            {
        
                if (Common.msConn.State == ConnectionState.Open)
                {


                    string str = "";
                    if (radMale.Checked == true)
                    {
                        str = "Male";
                    }
                    else
                    {
                        str = "Female";
                    }
                    //if (txtphone.Text.Length < 10)
                    //{
                    //    Lblmessage.Attributes["style"] = "color:green; font-weight:bold;";

                    //    Lblmessage.Text = "Phone No should be 10 digits";
                    //}

                    string query1 = "insert into UDT_MAS_TrainingEmployeeMaster(Empcode,OldNo,Name,FatherName,Dep,Project,Location,Designation,EmpType,DOJ,DOR,Gender,Grade,Education,phone,UserName,UserEmail,RepName,RepEmail,WorkStatus,Status,Createdby,CreatedDate,Modifiedby,ModifiedDate,ContractName)values('" + txtEmpcode.Text + "','" + txtOldNo.Text + "','" + txtEmpName.Text + "','" + TxtFatherName.Text + "','" + drpDep.SelectedValue + "','" + drpProj.SelectedValue + "','" + drpLoc.SelectedValue + "','" + drpDes.SelectedValue + "','" + drpType.SelectedValue + "','" + txtDOJ.Text + "','" + txtDOR.Text + "','" + str.ToString() + "','" + drpGrade.SelectedValue + "','" + drpEducation.SelectedValue + "','" + txtphone.Text + "','" + txtUserName.Text + "','" + txtUserEmail.Text + "','" + txtRepName.Text + "','" + txtRepEamil.Text + "','" + drpStatus.SelectedValue + "','" + 1 + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','" + Session["UserID"].ToString() + "','" + DateTime.Now + "','"+drpContract.SelectedItem+"')";
                    SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                    cmd1.ExecuteNonQuery();
                    Lblmessage.Text = "Saved Successfully" + txtEmpcode.Text;
                    ClearEmp();



                }

            }
        }

        protected void txtEmpcode_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Empcode from UDT_MAS_TrainingEmployeeMaster where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Lblmessage.Attributes["style"] = "color:red; font-weight:bold;";

                    Lblmessage.Text = "Already Exists";
                    btnsave.Visible = false;
                    btnUpdate.Visible = true;
                   
                    ReadEmp();
                }
                else
                {
                    btnsave.Visible = true;
                    btnUpdate.Visible = false;
                    Lblmessage.Text = "";
                    ClearExceptEmp();
                }
            }
            
        }
        protected void ClearExceptEmp()
        {
            txtOldNo.Text = "";
            txtEmpName.Text = "";
            TxtFatherName.Text = "";
            txtDOJ.Text = "";
            txtDOR.Text = "";
            txtphone.Text = "";
            txtUserName.Text = "";
            txtUserEmail.Text = "";
            txtRepName.Text = "";
            txtRepEamil.Text = "";
            DropdownDepartment(); DropdownProject(); DropdownLocation(); DropdownDesignation();
            DropdownEmpType(); DropdownGrade(); DropdownEducation(); DropdownStatus();
        }
        protected void ClearEmp()
        {
            txtEmpcode.Text = "";
            txtOldNo.Text="";
            txtEmpName.Text = "";
            TxtFatherName.Text = "";
            txtDOJ.Text ="";
            txtDOR.Text = "";         
            txtphone.Text = "";
            txtUserName.Text = "";
            txtUserEmail.Text = "";
            txtRepName.Text = "";
            txtRepEamil.Text = "";
            DropdownDepartment(); DropdownProject(); DropdownLocation(); DropdownDesignation();
            DropdownEmpType(); DropdownGrade(); DropdownEducation(); DropdownStatus();
         
        }
        protected void ReadEmp()
        {
          
            if (Common.msConn.State == ConnectionState.Open)
            {
                typeload();
                Gradeload();

                SqlDataReader reader = null;
                string query = "select Empcode,OldNo,Name,FatherName,Dep,Project,Location,Designation,EmpType,DOJ,DOR,Gender,Grade,Education,phone,UserName,UserEmail,RepName,RepEmail,WorkStatus,Status,Createdby,CreatedDate,Modifiedby,ModifiedDate,ContractName from UDT_MAS_TrainingEmployeeMaster  where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    

                    txtOldNo.Text = reader["OldNo"].ToString();
                    txtEmpName.Text = reader["Name"].ToString();
                    TxtFatherName.Text = reader["FatherName"].ToString();
                    drpDep.SelectedValue = reader["Dep"].ToString();
                    drpProj.SelectedValue = reader["Project"].ToString();
                    drpLoc.SelectedValue = reader["Location"].ToString();
                    drpDes.SelectedValue = reader["Designation"].ToString();
                    drpType.SelectedValue = reader["EmpType"].ToString();
                    txtDOJ.Text = reader["DOJ"].ToString();
                    txtDOR.Text = reader["DOR"].ToString();
                    string str = reader["Gender"].ToString();

                    if (str == "Male")
                    {
                        radMale.Checked = true;
                        radFemale.Checked = false;
                    }
                    else
                    {
                        radFemale.Checked = true;
                        radMale.Checked = false;
                    }
                    drpGrade.SelectedValue = reader["Grade"].ToString();
                    drpEducation.SelectedValue = reader["Education"].ToString();
                    txtphone.Text = reader["phone"].ToString();

                    txtUserName.Text = reader["UserName"].ToString();
                    txtUserEmail.Text = reader["UserEmail"].ToString();
                    txtRepName.Text = reader["RepName"].ToString();
                    txtRepEamil.Text = reader["RepEmail"].ToString();
                    drpStatus.SelectedValue = reader["WorkStatus"].ToString();
                    drpContract.SelectedValue = reader["ContractName"].ToString();
                    
                    

                }

                reader.Close();
            }

        }


        public void Validation()
        {

            ErrorFlag = "";
            if (txtDOR.Text == "1/1/1900 12:00:00 AM")
            {
                txtDOR.Text = "";
            }
            if (txtDOR.Text == "")
            {
                if (drpStatus.SelectedValue == "Deactive")
                {
                    Lblmessage.Text = "Status Should be active when DOR is blank";
                    ErrorFlag = "X";
                    if (updateflag == "X")
                    {
                        btnUpdate.Visible = false;
                    }
                    else
                    {
                        btnsave.Visible = false;
                    }

                }
                else
                {
                    ErrorFlag = "";
                    if (updateflag == "X")
                    {

                        btnUpdate.Visible = true;
                    }
                    else
                    {

                        btnsave.Visible = true;
                    }
                }

            }
            if (drpStatus.SelectedValue == "Active")
            {
                if (txtDOR.Text == "1/1/1900 12:00:00 AM")
                {
                    txtDOR.Text = "";
                }
                if (txtDOR.Text != "" )
                {
                    Lblmessage.Text = "Status Should be Deactive when DOR is Entered";
                    ErrorFlag = "X";
                    if (updateflag == "X")
                    {
                        btnUpdate.Visible = false;
                    }
                    else
                    {
                        btnsave.Visible = false;
                    }

                }
                else
                {
                    ErrorFlag = "";
                    if (updateflag == "X")
                    {

                        btnUpdate.Visible = true;
                    }
                    else
                    {

                        btnsave.Visible = true;
                    }
                }

            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Validation();
            updateflag = "X";
            if(ErrorFlag == "")
            {
          
                 
            if (Common.msConn.State == ConnectionState.Open)
            { string str = "";
                if (radMale.Checked == true)
                {
                    str = "Male";
                }
                else
                {
                    str = "Female";
                }
                //if (txtphone.Text.Length < 10)
                //{
                //    Lblmessage.Attributes["style"] = "color:green; font-weight:bold;";

                //    Lblmessage.Text = "Phone No should be 10 digits";
                //}
                string query1 = "Update UDT_MAS_TrainingEmployeeMaster set OldNo='" + txtOldNo.Text + "',Name='" + txtEmpName.Text + "',FatherName='" + TxtFatherName.Text + "',Dep='" + drpDep.SelectedItem + "',Project='" + drpProj.SelectedItem + "',Location='" + drpLoc.SelectedItem + "',Designation='" + drpDes.SelectedItem + "',EmpType='" + drpType.SelectedItem + "', DOJ='" + txtDOJ.Text + "',DOR='" + txtDOR.Text + "',Gender='" + str + "',Grade='" + drpGrade.SelectedItem + "',Education='" + drpEducation.SelectedItem + "',phone='" + txtphone.Text + "',UserName='" + txtUserName.Text + "', UserEmail='" + txtUserEmail.Text + "',RepName='" + txtRepName.Text + "',RepEmail='" + txtUserEmail.Text + "',WorkStatus='" + drpStatus.SelectedItem + "',Modifiedby='" + Session["UserID"].ToString() + "',ModifiedDate='" + DateTime.Now + "',ContractName='"+drpContract.SelectedItem+"' where Empcode='" + txtEmpcode.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, Common.msConn);
                cmd1.ExecuteNonQuery();
                Lblmessage.Text = "Empcode Updated Successfully" + txtEmpcode.Text;
                ClearEmp();
            }
            }
        }

        protected void txtOldNo_TextChanged(object sender, EventArgs e)
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                DataTable dt = new DataTable();
                string query = "select Empcode from UDT_MAS_TrainingEmployeeMaster where Empcode='" + txtOldNo.Text + "'";
                SqlCommand cmd = new SqlCommand(query, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {

                    btnsave.Visible = true;
                    btnUpdate.Visible = false;
                    Lblmessage.Text = "";
                   
                }
                else
                {
                    Lblmessage.Attributes["style"] = "color:green; font-weight:bold;";

                    Lblmessage.Text = "Old No Does not Exists";
                   
                }
            }
            
        }

        protected void drpDes_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropdownEmpType(); DropdownGrade();
          
          
        }
    

             
       
    }
}