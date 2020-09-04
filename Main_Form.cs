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
    public partial class Main_Form : Form
    {
        Action callBackThemes;
        public int QuizName_Id { get; set; }
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Themes_button_Click(object sender, EventArgs e)
        {
            new ThemeAdministration_Form(callBackThemes).Show();
        }

        private void Quizes_button_Click(object sender, EventArgs e)
        {
            new QuizAdministration_Form().Show();
        }

        private void Questions_button_Click(object sender, EventArgs e)
        {
            new QuestionsAdministration_Form().Show();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.FillQuizNamesBySelectedTheme(this.quizDataSet.Quiz, -1);
            // TODO: This line of code loads data into the 'quizDataSet.Theme' table. You can move, or remove it, as needed.
            this.themeTableAdapter.Fill(this.quizDataSet.Theme);
            callBackThemes = FillThemes;

        }

        private void Theme_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.quizTableAdapter.FillQuizNamesBySelectedTheme(this.quizDataSet.Quiz, int.Parse(Theme_comboBox.SelectedValue.ToString()));
        }

        public void FillThemes()
        {
            this.themeTableAdapter.Fill(this.quizDataSet.Theme);
        }

        private void QuizStart_button_Click(object sender, EventArgs e)
        {
            new Quiz_Form(QuizName_Id).Show();
        }

        private void QuizName_comboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            QuizName_Id = int.Parse(QuizName_comboBox.SelectedValue.ToString());
        }
    }
}
