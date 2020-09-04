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
    public partial class Result_Form : Form
    {
        List<Result> Results;
        Action CloseQuizFormAfterResultViewing;
        public int CorrectAnswersCount { get; set; }
        public Result_Form(List<Result> results, Action action)
        {
            Results = results;
            CloseQuizFormAfterResultViewing = action;
            InitializeComponent();
            Result_dataGridView.DataSource = Results;
            foreach (Result result in Results)
            {
                if (result.Guess.ToUpper() == result.Answer.ToUpper())
                {
                    CorrectAnswersCount++;
                }
            }
            Result_label.Text = "Your result: " + CorrectAnswersCount + " from " + Results.Count;
        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            CloseQuizFormAfterResultViewing();
        }

        private void Result_dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            foreach (DataGridViewRow row in Result_dataGridView.Rows)
            {
                if (row.Cells[1].Value.ToString().ToUpper() == row.Cells[2].Value.ToString().ToUpper())
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
    }
}
