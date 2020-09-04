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
    public partial class QuestionsAdministration_Form : Form
    {
        public int ID { get; set; }
        public QuestionsAdministration_Form()
        {
            InitializeComponent();
        }
        

        private void QuestionsAdministration_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.Quiz_questions' table. You can move, or remove it, as needed.
            this.quiz_questionsTableAdapter.FillQuestionsBySelectedQuizName(this.quizDataSet.Quiz_questions, -1);
            // TODO: This line of code loads data into the 'quizDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.FillQuizNamesBySelectedTheme(this.quizDataSet.Quiz, -1);
            // TODO: This line of code loads data into the 'quizDataSet.Theme' table. You can move, or remove it, as needed.
            this.themeTableAdapter.Fill(this.quizDataSet.Theme);
        }

        private void Theme_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.quizTableAdapter.FillQuizNamesBySelectedTheme(this.quizDataSet.Quiz, int.Parse(Theme_comboBox.SelectedValue.ToString()));
            this.quiz_questionsTableAdapter.FillQuestionsBySelectedQuizName(this.quizDataSet.Quiz_questions, int.Parse(QuizName_comboBox.SelectedValue.ToString()));
        }

        private void QuizName_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.quiz_questionsTableAdapter.FillQuestionsBySelectedQuizName(this.quizDataSet.Quiz_questions, int.Parse(QuizName_comboBox.SelectedValue.ToString()));
            QuizNameChange_comboBox.SelectedValue = QuizName_comboBox.SelectedValue;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Questions_dataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(Questions_dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Question_textBox.Text = Questions_dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Answer_textBox.Text = Questions_dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(Question_textBox.Text) && !String.IsNullOrWhiteSpace(Answer_textBox.Text))
            {
                Quiz_question quiz_Question = new Quiz_question();
                quiz_Question.Quiz_id = int.Parse(QuizNameChange_comboBox.SelectedValue.ToString());
                quiz_Question.Question = Question_textBox.Text;
                quiz_Question.Answer = Answer_textBox.Text;
                DB_Connection.db.GetTable<Quiz_question>().InsertOnSubmit(quiz_Question);
                DB_Connection.db.SubmitChanges();
                this.quiz_questionsTableAdapter.FillQuestionsBySelectedQuizName(this.quizDataSet.Quiz_questions, int.Parse(QuizName_comboBox.SelectedValue.ToString()));
                QuizNameChange_comboBox.SelectedValue = QuizName_comboBox.SelectedValue;
                Question_textBox.Text = null;
                Answer_textBox.Text = null;

            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                Quiz_question quiz_Question = DB_Connection.db.GetTable<Quiz_question>().Where(x => x.Id == ID).Single();
                DB_Connection.db.GetTable<Quiz_question>().DeleteOnSubmit(quiz_Question);
                DB_Connection.db.SubmitChanges();
                this.quiz_questionsTableAdapter.FillQuestionsBySelectedQuizName(this.quizDataSet.Quiz_questions, int.Parse(QuizName_comboBox.SelectedValue.ToString()));
                Question_textBox.Text = null;
                Answer_textBox.Text = null;
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Quiz_question quiz_Question = DB_Connection.db.GetTable<Quiz_question>().Where(x => x.Id == ID).Single();
            quiz_Question.Quiz_id = int.Parse(QuizNameChange_comboBox.SelectedValue.ToString());
            quiz_Question.Question = Question_textBox.Text;
            quiz_Question.Answer = Answer_textBox.Text;
            DB_Connection.db.SubmitChanges();
            this.quiz_questionsTableAdapter.FillQuestionsBySelectedQuizName(this.quizDataSet.Quiz_questions, int.Parse(QuizName_comboBox.SelectedValue.ToString()));
            QuizNameChange_comboBox.SelectedValue = QuizName_comboBox.SelectedValue;
            Question_textBox.Text = null;
            Answer_textBox.Text = null;
        }
    }
}
