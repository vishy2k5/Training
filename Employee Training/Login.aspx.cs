using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.DirectoryServices;
using System.Data.SqlClient;

namespace Employee_Training
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Common.OpenDBConnection();
  
        if (!IsPostBack)
        {
            
            Role();
        }
        }

        private bool IsValidUser(string UsrLogin, string UsrPass)
        {

            DirectoryEntry m_obDirEntry;

            try
            {

                string strLDAP = ConfigurationManager.AppSettings["LDAPAdd"].ToString();
                m_obDirEntry = new DirectoryEntry(strLDAP, UsrLogin, UsrPass);
                DirectorySearcher srch = new DirectorySearcher(m_obDirEntry);
                srch.Filter = "(SAMAccountName=" + UsrLogin + ")";
                SearchResultCollection results;
                results = srch.FindAll();
                ResultPropertyCollection propColl = null;

                foreach (SearchResult result in results)
                {

                    propColl = result.Properties;

                }
                if (propColl != null)
                {

                    foreach (string strKey in propColl.PropertyNames)

                        foreach (object obProp in propColl[strKey])
                        {

                            if (strKey.ToUpper() == "DISPLAYNAME")
                            {

                                Session["APPUser"] = obProp.ToString();

                                Session["UserID"] = UsrLogin;

                            }

                            if (strKey.ToUpper() == "MAIL")
                            {
                                //string temp = obProp.ToString();
                                //string replaced = temp.Replace("@", "@in.");

                                Session["APPUserMail"] = obProp.ToString();

                            }

                        }

                    return true;

                }

                else

                    return false;

            }


            catch (System.DirectoryServices.DirectoryServicesCOMException Ex)
            {

                lblerrormsg.Text = Ex.Message;
                return false;

            }

            catch (Exception exx)
            {

                //Login1.FailureText = exx.Message.ToString() + "  Please Contact Help Desk";

                lblerrormsg.Text = exx.Message;

                return false;

            }


        }

        public void Role()
        {
            if (Common.msConn.State == ConnectionState.Open)
            {
                string selectSQL = "select distinct RoleName from UDT_MAS_TrainingRole(nolock) order by RoleName";
                SqlCommand cmd = new SqlCommand(selectSQL, Common.msConn);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                drpRole.DataSource = ds;
                drpRole.DataTextField = "RoleName";
                drpRole.DataValueField = "RoleName";
                drpRole.DataBind();
                //drpDep.Items.Insert(0, ListItem.FromString("Select BusRouteNo"));
                drpRole.SelectedIndex = 0;
                drpRole.Text = "";

            }
        }
        protected void Login_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                Session["RoleId"] = "";

                if (Common.msConn.State == ConnectionState.Open)
                {
                    Common.Query = new SqlCommand("SELECT isnull(RoleId,'') FROM UDT_MAS_TrainingLogin(NOLOCK) WHERE username = '" + txtUserName.Text + "'", Common.msConn);

                    Session["RoleId"] = (string)Common.Query.ExecuteScalar();
                    if (Session["RoleId"] != "null")
                    {
                        if (IsValidUser(txtUserName.Text, txtPassword.Text))
                        {
                            Session["Login"] = txtUserName.Text;
                            Response.Redirect("Menu.aspx");
                        }
                        else
                        {
                            lblerrormsg.Text = "INVALID USER DETAILS";
                            txtUserName.Text = "";
                            txtPassword.Text = "";

                        }
                    }
                    else
                    {
                        lblerrormsg.Text = "YOU ARE NOT AN AUTHORIZED USER";
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                lblerrormsg.Text = "Please contact the IT team with this error screen shot" + ex.Message.ToString();
            }
        }
    }
}


