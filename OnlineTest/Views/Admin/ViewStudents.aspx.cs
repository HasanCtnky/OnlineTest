using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTest.Views.Admin
{
    public partial class ViewStudents : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowStudents();
        }
        private void ShowStudents()
        {
            string Query = "select OgrId as ID, OgrName as Name, OgrEmail as Email, OgrPass as Password, OgrSchool as School from Ogrenciler";
            StudentsList.DataSource = Con.GetData(Query);
            StudentsList.DataBind();
        }
    }
}