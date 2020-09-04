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
    public partial class ThemeAdministration_Form : Form
    {
        Action CallBackThemes;

        public int ID { get; set; }
        public ThemeAdministration_Form(Action callBackThemes)
        {
            InitializeComponent();
            CallBackThemes = callBackThemes;
        }

        private void themeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.themeBindingSource.EndEdit();
        }

        
        private void Theme_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.Theme' table. You can move, or remove it, as needed.
            this.themeTableAdapter.Fill(this.quizDataSet.Theme);

        }

        private void Close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            CallBackThemes();
        }       
       

        private void AddTheme_button_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(Theme_textBox.Text))
            {
                try
                {
                    Theme theme = new Theme();
                    theme.Title = Theme_textBox.Text;
                    DB_Connection.db.GetTable<Theme>().InsertOnSubmit(theme);
                    DB_Connection.db.SubmitChanges();
                    this.themeTableAdapter.Fill(this.quizDataSet.Theme);
                    Theme_textBox.Text = null;
                }
                catch (Exception) { MessageBox.Show("Theme name must be unique"); }
                finally { Theme_textBox.Text = null; }
            }
            else
            {
                MessageBox.Show("Please specify theme name");
            }
        }

        private void DeleteTheme_button_Click(object sender, EventArgs e)
        {
            if (ID != -1)
            {
                Theme theme = DB_Connection.db.GetTable<Theme>().Where(x => x.Id == ID).Single();
                DB_Connection.db.GetTable<Theme>().DeleteOnSubmit(theme);
                DB_Connection.db.SubmitChanges();
                this.themeTableAdapter.Fill(this.quizDataSet.Theme);
                Theme_textBox.Text = null;
            }
        }

        private void ThemesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID = Convert.ToInt32(ThemesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            Theme_textBox.Text = ThemesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            
        }

        private void EditTheme_button_Click(object sender, EventArgs e)
        {
            Theme theme = DB_Connection.db.GetTable<Theme>().Where(x => x.Id == ID).Single();
            theme.Title = Theme_textBox.Text;
            DB_Connection.db.SubmitChanges();
            this.themeTableAdapter.Fill(this.quizDataSet.Theme);
            Theme_textBox.Text = null;
        }
    }
}
