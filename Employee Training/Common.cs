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
//using System.DirectoryServices;
using System.Data.SqlClient;

namespace Employee_Training
{
    public class Common
    {
        public static SqlConnection msConn;
        public static SqlCommand Query;

        public static SqlDataReader Querydr;
        private static string ReadAppSettingsForConnStr()
        {

            string sConnectionString = null;
            sConnectionString = Convert.ToString(System.Configuration.ConfigurationSettings.AppSettings["Connection"]);
            //MessageBox.Show(sConnectionString)
            return sConnectionString;

        }

        protected static internal bool OpenDBConnection()
        {
            bool functionReturnValue = false;
            try
            {
                string sConnectionStr = ReadAppSettingsForConnStr();
                msConn = new SqlConnection(sConnectionStr);
                msConn.Open();
                if (msConn.State == ConnectionState.Open)
                {
                    functionReturnValue = true;
                }
                else
                {
                    functionReturnValue = false;
                }
            }
            catch (Exception ex)
            {
                functionReturnValue = false;
            }
            return functionReturnValue;

        }

    }
}