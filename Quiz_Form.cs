using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baigiamasis_Darbas
{
    public partial class Quiz_Form : Form
    {
        public int QuizName_id { get; set; }
        public int Index { get; set; }
        List<Result> results;
        Action  CloseFormAfterResultViewing;
        public Quiz_Form(int quizName_id)
        {
            InitializeComponent();
            CloseFormAfterResultViewing += this.Close;
            CloseFormAfterResultViewing += this.Dispose;
            Index = 1;
            QuizName_id = quizName_id;
            InitiateResultList();
            InitiateQuestion();
        }

        private void InitiateResultList()
        {
            List<Quiz_question> questions = DB_Connection.db.GetTable<Quiz_question>().Where(x => x.Quiz_id == QuizName_id).ToList();
            results = new List<Result>();
            foreach (var question in questions)
            {
                Result result = new Result();
                result.Question = question.Question;
                result.Answer = question.Answer;
                results.Add(result);
            }
        }

        private void InitiateQuestion()
        {
            QuestionCount_label.Text = Index + " from " + results.Count;
            Question_textBox.Text = results[Index - 1].Question;
            Answer_textBox.Text = results[Index - 1].Guess;
        }

        private void EnableDisablePreviousNextButtons()
        {
            if (Index == 1)
            {
                Previous_button.Enabled = false;
            }
            else
            {
                Previous_button.Enabled = true;
            }

            if (Index == results.Count)
            {
                Next_button.Enabled = false;
            }
            else
            {
                Next_button.Enabled = true;
            }
        }

        private void Cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Previous_button_Click(object sender, EventArgs e)
        {
            results[Index - 1].Guess = Answer_textBox.Text;
            Index--;
            EnableDisablePreviousNextButtons();
            InitiateQuestion();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            results[Index - 1].Guess = Answer_textBox.Text;
            Index++;
            EnableDisablePreviousNextButtons();
            InitiateQuestion();
        }

        private void Finish_button_Click(object sender, EventArgs e)
        {
            results[Index - 1].Guess = Answer_textBox.Text;
            new Result_Form(results, CloseFormAfterResultViewing).Show();
        }
    }
}
