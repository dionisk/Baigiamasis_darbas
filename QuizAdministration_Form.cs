using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baigiamasis_Darbas
{
    public partial class QuizAdministration_Form : Form
    {
        public int ID { get; set; }
        public QuizAdministration_Form()
        {
            InitializeComponent();
        }

        private void QuizAdministration_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Fill(this.quizDataSet.DataTable1);

            // TODO: This line of code loads data into the 'quizDataSet.Theme' table. You can move, or remove it, as needed.
            this.themeTableAdapter.Fill(this.quizDataSet.Theme);
            // TODO: This line of code loads data into the 'quizDataSet.DataTable1' table. You can move, or remove it, as needed.

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void fillDataGridView()
        {
            var query = from q in DB_Connection.db.GetTable<Quiz>() 
                        join t in DB_Connection.db.GetTable<Theme>() 
                        on q.Theme_id equals t.Id select new { Quiz = q, Theme = t };
            //SqlDataAdapter dAdapter = new SqlDataAdapter(query);

        }

        private void QuizDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(QuizDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            QuizName_textBox.Text = QuizDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            AssociatedTheme_comboBox.SelectedValue = QuizDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void Insert_button_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(QuizName_textBox.Text))
            {
                Quiz quiz = new Quiz();
                quiz.Quiz_Name = QuizName_textBox.Text;
                quiz.Theme_id = Int32.Parse(AssociatedTheme_comboBox.SelectedValue.ToString());
                DB_Connection.db.GetTable<Quiz>().InsertOnSubmit(quiz);
                DB_Connection.db.SubmitChanges();
                this.dataTable1TableAdapter.Fill(this.quizDataSet.DataTable1);
                QuizName_textBox.Text = null;
            }
        }

        private void Delete_button_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                Quiz quiz = DB_Connection.db.GetTable<Quiz>().Where(x => x.Id == ID).Single();
                DB_Connection.db.GetTable<Quiz>().DeleteOnSubmit(quiz);
                DB_Connection.db.SubmitChanges();
                this.dataTable1TableAdapter.Fill(this.quizDataSet.DataTable1);
                QuizName_textBox.Text = null;
            }
        }

        private void Edit_button_Click(object sender, EventArgs e)
        {
            Quiz quiz = DB_Connection.db.GetTable<Quiz>().Where(x => x.Id == ID).Single();
            quiz.Quiz_Name = QuizName_textBox.Text;
            quiz.Theme_id = Int32.Parse(AssociatedTheme_comboBox.SelectedValue.ToString());
            DB_Connection.db.SubmitChanges();
            this.dataTable1TableAdapter.Fill(this.quizDataSet.DataTable1);
            QuizName_textBox.Text = null;
        }
    }
}
