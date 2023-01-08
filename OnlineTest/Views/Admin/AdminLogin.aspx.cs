using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTest.Views.Admin
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmailTb.Value == "admin@gmail.com" && PasswordTb.Value=="admin")
                {
                    Response.Redirect("ViewStudents.aspx");     
                }
                else
                {
                    ErrMsg.InnerText = "Yanlış email veya şifre girdiniz";
                }
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}