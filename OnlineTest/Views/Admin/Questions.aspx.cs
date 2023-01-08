using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Mvc;

namespace OnlineTest.Views.Admin
{
    public partial class Questions : System.Web.UI.Page
    {
        Models.Functions Con;
        protected void Page_Load(object sender, EventArgs e)
        {
            Con = new Models.Functions();
            if (!IsPostBack)
            {
                GetQuiz();
            }
            ShowQuestion();
        }
        private void ShowQuestion()
        {
            string Query = "select * from QuestionTbl";
            QuestionList.DataSource = Con.GetData(Query);
            QuestionList.DataBind();
        }
        private void GetQuiz()
        {
            string Query = "select * from QuizTbl";
            QNameTb.DataTextField = Con.GetData(Query).Columns["QName"].ToString();
            QNameTb.DataValueField = Con.GetData(Query).Columns["QId"].ToString();
            QNameTb.DataSource = Con.GetData(Query);
            QNameTb.DataBind();
        }

        protected void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Quiz = QNameTb.SelectedItem.Value;
                string Question = QuestionTb.Value;
                string Ans1 = Ans1Tb.Value;
                string Ans2 = Ans2Tb.Value;
                string Ans3 = Ans3Tb.Value;
                string Ans4 = Ans4Tb.Value;
                int Cor = Convert.ToInt32(CorrectTb.Value);
                string Query = "insert into QuestionTbl values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6})";
                Query = string.Format(Query, Quiz, Question, Ans1, Ans2, Ans3, Ans4, Cor);
                Con.SetData(Query);
                ErrMsg.InnerText = "Başarılı bir şekilde soru eklendi!!!";
                ShowQuestion();
                QNameTb.SelectedItem.Value="";
                QuestionTb.Value="";
                Ans1Tb.Value="";
                Ans2Tb.Value="";
                Ans3Tb.Value="";
                Ans4Tb.Value="";
            }
            catch (Exception Ex)
            {

                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            QNameTb.SelectedItem.Value = QuestionList.SelectedRow.Cells[2].Text;
            QuestionTb.Value = QuestionList.SelectedRow.Cells[3].Text;
            Ans1Tb.Value = QuestionList.SelectedRow.Cells[4].Text;
            Ans2Tb.Value = QuestionList.SelectedRow.Cells[5].Text;
            Ans3Tb.Value = QuestionList.SelectedRow.Cells[6].Text;
            Ans4Tb.Value = QuestionList.SelectedRow.Cells[7].Text;
            CorrectTb.Value = QuestionList.SelectedRow.Cells[8].Text;
            
        }

        protected void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Quiz = QNameTb.SelectedItem.Value;
                string Question = QuestionTb.Value;
                string Ans1 = Ans1Tb.Value;
                string Ans2 = Ans2Tb.Value;
                string Ans3 = Ans3Tb.Value;
                string Ans4 = Ans4Tb.Value;
                int Cor = Convert.ToInt32(CorrectTb.Value);
                string Query = "update QuestionTbl set Quiz = '{0}', Question = '{1}', Ans1 = '{2}', Ans2 = '{3}', Ans3 = '{4}', Ans4 = '{5}', Correct = '{6}' where QuestId = {7}";
                Query = string.Format(Query, Quiz, Question, Ans1, Ans2, Ans3, Ans4, Cor, QuestionList.SelectedRow.Cells[1].Text);
                Con.SetData(Query);
                ErrMsg.InnerText = "Başarılı bir şekilde soru düzenlendi!!!";
                ShowQuestion();
                QNameTb.SelectedItem.Value = "";
                QuestionTb.Value = "";
                Ans1Tb.Value = "";
                Ans2Tb.Value = "";
                Ans3Tb.Value = "";
                Ans4Tb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

        protected void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string Query = "delete from QuestionTbl where QuestId = {0}";
                Query = string.Format(Query, QuestionList.SelectedRow.Cells[1].Text);
                Con.SetData(Query);
                ErrMsg.InnerText = "Başarılı bir şekilde soru!!!";
                ShowQuestion();
                QNameTb.SelectedItem.Value = "";
                QuestionTb.Value = "";
                Ans1Tb.Value = "";
                Ans2Tb.Value = "";
                Ans3Tb.Value = "";
                Ans4Tb.Value = "";
                CorrectTb.Value = "";
            }
            catch (Exception Ex)
            {
                ErrMsg.InnerText = Ex.Message;
            }
        }

    }
}