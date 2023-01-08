using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTest.Views
{
    public partial class Login : Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
        }

        public static int OgrenciId;

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "select OgrId,OgrName, OgrEmail, OgrSchool from Ogrenciler where OgrEmail= '{0}' and OgrPass= '{1}'";
                Query = string.Format(Query, EmailTb.Value, PasswordTb.Value);
                Con.SetData(Query);
                ErrMsg.InnerText = "Başarılı bir şekilde eklendi... Giriş Yapılıyor...";
                DataTable dt = Con.GetData(Query);
                if (dt.Rows.Count == 0)                  
                {
                    ErrMsg.InnerText = "Yanlış Email veya şifre girdiniz!!!";
                }
                else
                {
                    OgrenciId = Convert.ToInt32(dt.Rows[0][0].ToString());
                    Response.Redirect("Ogrenci/Home.aspx");
                    //ErrMsg.InnerText = "Online Sınav Sistemine hoşgeldiniz";
                }
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }

        /*protected void RegisterBtn_Click(object sender, EventArgs e)
        {
           
        }*/
    }
}