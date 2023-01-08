using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace OnlineTest.Views.Ogrenci
{
    public partial class Test : System.Web.UI.Page
    {
        Models.Functions Con;
        static int i = 0;
        int Quiz = Home.QId;

        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                GetQuestions();
                i = 0;
            }
        }
        /*private void InsertTest()
        {
            try
            {
                int Ogrenci = Login.OgrenciId;
                int Quiz = Home.QId;

                string Query = "insert into TestTbl values({0}, {1}, '{2}', '{3}')";
                Query = string.Format(Query, Ogrenci, Quiz, System.DateTime.Today.Date, Score);
                Con.SetData(Query);

            }
            catch (Exception Ex)
            {
                 ErrMsg.InnerText = Ex.Message;
            }
        }*/
        private void NextQuestion()
        {
            
            string Query = "select * from QuestionTbl where Quiz = {0}";
            Query = string.Format(Query, Quiz);
            DataTable Questions = Con.GetData(Query);
            int QuestNum = Questions.Rows.Count;
            if (i < QuestNum)
            {
                if (Ans1Rb.Checked || Ans2Rb.Checked || Ans3Rb.Checked || Ans4Rb.Checked)
                {
                    QuesTb.InnerText = Questions.Rows[i][2].ToString();
                    Ans1Lbl.InnerText = Questions.Rows[i][3].ToString();
                    Ans2Lbl.InnerText = Questions.Rows[i][4].ToString();
                    Ans3Lbl.InnerText = Questions.Rows[i][5].ToString();
                    Ans4Lbl.InnerText = Questions.Rows[i][6].ToString();
                    Correct();
                    if (c == Convert.ToInt32(Questions.Rows[i][7].ToString()))
                    {
                        Score = Score + 1;
                        i++;
                        //  InfoMsg.InnerText = Score + "";
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Lütfen bir şıkkı seçiniz')", true);
                }
            }
            else
            {
                InfoMsg.InnerText = QuestNum + " soruda " + Score + " doğru";
                //InsertTest();
                QuestNum = 0;
                Score = 0;
                
            }

        }
        private void GetQuestions()
        {
            string Query = "select * from QuestionTbl";
            DataTable Questions = Con.GetData(Query);
            int QuestNum = Questions.Rows.Count;
            if (i < QuestNum)
            {
                QuesTb.InnerText = Questions.Rows[i][2].ToString();
                Ans1Lbl.InnerText = Questions.Rows[i][3].ToString();
                Ans2Lbl.InnerText = Questions.Rows[i][4].ToString();
                Ans3Lbl.InnerText = Questions.Rows[i][5].ToString();
                Ans4Lbl.InnerText = Questions.Rows[i][6].ToString();
                i++;
            } 
        }
        

        
        int c;
        static int Score = 0;
        private void Correct()
        {
            if (Ans1Rb.Checked)
            {
                c = 1;
            }else if (Ans2Rb.Checked)
            {
                c = 2;
            }else if (Ans3Rb.Checked)
            {
                c = 3;
            }else if (Ans4Rb.Checked)
            {
                c = 4;
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }
    }
}