using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineTest.Views.Admin
{
    public partial class Quiz : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            ShowQuiz();
        }
        private void ShowQuiz()
        {
            string Query = "select QId as ID, QName as QuizAdı, QNo as SoruSayısı, QAns as CevapSayısı from QuizTbl";
            QuizList.DataSource = Con.GetData(Query);
            QuizList.DataBind();
        }
        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string QuizName = QuizNameTb.Value;
                string Quest = QuestionsTb.Value;
                string Ans = AnsByQuestTb.Value;

                string Query = "insert into QuizTbl values('{0}', '{1}', '{2}')";
                Query = string.Format(Query, QuizName, Quest, Ans);
                Con.SetData(Query);
                ErrMsg.InnerText = "Quiz Eklendi!!!";
                ShowQuiz();
                QuizNameTb.Value="";
                QuestionsTb.Value="";
                AnsByQuestTb.Value="";
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
            
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string QuizName = QuizNameTb.Value;
                string Quest = QuestionsTb.Value;
                string Ans = AnsByQuestTb.Value;

                string Query = "update QuizTbl set QName = '{0}', QNo = '{1}', QAns = '{2}' where QId = {3}";
                Query = string.Format(Query, QuizName, Quest, Ans, QuizList.SelectedRow.Cells[1].Text);
                Con.SetData(Query);
                ErrMsg.InnerText = "Quiz Güncellendi!!!";
                ShowQuiz();
                QuizNameTb.Value = "";
                QuestionsTb.Value = "";
                AnsByQuestTb.Value = "";
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void QuizList_SelectedIndexChanged(object sender, EventArgs e)
        {
            QuizNameTb.Value = QuizList.SelectedRow.Cells[2].Text;
            QuestionsTb.Value = QuizList.SelectedRow.Cells[3].Text;
            AnsByQuestTb.Value = QuizList.SelectedRow.Cells[4].Text;
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string QuizName = QuizNameTb.Value;
                string Quest = QuestionsTb.Value;
                string Ans = AnsByQuestTb.Value;

                string Query = "delete from QuizTbl where QId = {0}";
                Query = string.Format(Query, QuizList.SelectedRow.Cells[1].Text);
                Con.SetData(Query);
                ErrMsg.InnerText = "Quiz Silindi!!!";
                ShowQuiz();
                QuizNameTb.Value = "";
                QuestionsTb.Value = "";
                AnsByQuestTb.Value = "";
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }
    }
}