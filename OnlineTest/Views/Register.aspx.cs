using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTest.Views
{
    public partial class Register : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        protected void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Name = NameTb.Value;
                string Email = EmailTb.Value;
                string Pass = PasswordTb.Value;
                string School = SchoolTb.Value;
                string Query = "insert into Ogrenciler values('{0}', '{1}', '{2}', '{3}')";
                Query = string.Format(Query, Name, Email, Pass, School);
                Con.SetData(Query);
                ErrMsg.InnerText = "Başarılı bir şekilde eklendi... Giriş Yapılıyor...";

            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }

        /*protected void LoginBtn_Click(object sender, EventArgs e)
        {

        }*/
    }
}