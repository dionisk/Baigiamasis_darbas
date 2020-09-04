namespace Baigiamasis_Darbas
{
    partial class QuizAdministration_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.QuizName_label = new System.Windows.Forms.Label();
            this.QuizName_textBox = new System.Windows.Forms.TextBox();
            this.AssociatedTheme_label = new System.Windows.Forms.Label();
            this.AssociatedTheme_comboBox = new System.Windows.Forms.ComboBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new Baigiamasis_Darbas.QuizDataSet();
            this.QuizDataGridView = new System.Windows.Forms.DataGridView();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Close_button = new System.Windows.Forms.Button();
            this.Insert_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.themeTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.ThemeTableAdapter();
            this.dataTable1TableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.DataTable1TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // QuizName_label
            // 
            this.QuizName_label.AutoSize = true;
            this.QuizName_label.Location = new System.Drawing.Point(12, 16);
            this.QuizName_label.Name = "QuizName_label";
            this.QuizName_label.Size = new System.Drawing.Size(60, 13);
            this.QuizName_label.TabIndex = 0;
            this.QuizName_label.Text = "Quiz name:";
            // 
            // QuizName_textBox
            // 
            this.QuizName_textBox.Location = new System.Drawing.Point(123, 13);
            this.QuizName_textBox.Name = "QuizName_textBox";
            this.QuizName_textBox.Size = new System.Drawing.Size(243, 20);
            this.QuizName_textBox.TabIndex = 1;
            // 
            // AssociatedTheme_label
            // 
            this.AssociatedTheme_label.AutoSize = true;
            this.AssociatedTheme_label.Location = new System.Drawing.Point(13, 57);
            this.AssociatedTheme_label.Name = "AssociatedTheme_label";
            this.AssociatedTheme_label.Size = new System.Drawing.Size(94, 13);
            this.AssociatedTheme_label.TabIndex = 2;
            this.AssociatedTheme_label.Text = "Associated theme:";
            // 
            // AssociatedTheme_comboBox
            // 
            this.AssociatedTheme_comboBox.DataSource = this.themeBindingSource;
            this.AssociatedTheme_comboBox.DisplayMember = "Title";
            this.AssociatedTheme_comboBox.FormattingEnabled = true;
            this.AssociatedTheme_comboBox.Location = new System.Drawing.Point(123, 57);
            this.AssociatedTheme_comboBox.Name = "AssociatedTheme_comboBox";
            this.AssociatedTheme_comboBox.Size = new System.Drawing.Size(243, 21);
            this.AssociatedTheme_comboBox.TabIndex = 3;
            this.AssociatedTheme_comboBox.ValueMember = "Id";
            // 
            // themeBindingSource
            // 
            this.themeBindingSource.DataMember = "Theme";
            this.themeBindingSource.DataSource = this.quizDataSet;
            // 
            // quizDataSet
            // 
            this.quizDataSet.DataSetName = "QuizDataSet";
            this.quizDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // QuizDataGridView
            // 
            this.QuizDataGridView.AutoGenerateColumns = false;
            this.QuizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuizDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.themeidDataGridViewTextBoxColumn,
            this.quizNameDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn,
            this.expr2DataGridViewTextBoxColumn});
            this.QuizDataGridView.DataSource = this.dataTable1BindingSource;
            this.QuizDataGridView.Location = new System.Drawing.Point(126, 97);
            this.QuizDataGridView.Name = "QuizDataGridView";
            this.QuizDataGridView.Size = new System.Drawing.Size(240, 213);
            this.QuizDataGridView.TabIndex = 4;
            this.QuizDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.QuizDataGridView_RowHeaderMouseClick);
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.quizDataSet;
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(288, 341);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 5;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Insert_button
            // 
            this.Insert_button.Location = new System.Drawing.Point(392, 136);
            this.Insert_button.Name = "Insert_button";
            this.Insert_button.Size = new System.Drawing.Size(75, 23);
            this.Insert_button.TabIndex = 6;
            this.Insert_button.Text = "Insert";
            this.Insert_button.UseVisualStyleBackColor = true;
            this.Insert_button.Click += new System.EventHandler(this.Insert_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(392, 176);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 7;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(392, 216);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 8;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // themeidDataGridViewTextBoxColumn
            // 
            this.themeidDataGridViewTextBoxColumn.DataPropertyName = "Theme_id";
            this.themeidDataGridViewTextBoxColumn.HeaderText = "Theme_id";
            this.themeidDataGridViewTextBoxColumn.Name = "themeidDataGridViewTextBoxColumn";
            this.themeidDataGridViewTextBoxColumn.Visible = false;
            // 
            // quizNameDataGridViewTextBoxColumn
            // 
            this.quizNameDataGridViewTextBoxColumn.DataPropertyName = "Quiz_Name";
            this.quizNameDataGridViewTextBoxColumn.HeaderText = "Quiz_Name";
            this.quizNameDataGridViewTextBoxColumn.Name = "quizNameDataGridViewTextBoxColumn";
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Theme_id2";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            // 
            // expr2DataGridViewTextBoxColumn
            // 
            this.expr2DataGridViewTextBoxColumn.DataPropertyName = "Expr2";
            this.expr2DataGridViewTextBoxColumn.HeaderText = "Theme_name";
            this.expr2DataGridViewTextBoxColumn.Name = "expr2DataGridViewTextBoxColumn";
            // 
            // QuizAdministration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 397);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Insert_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.QuizDataGridView);
            this.Controls.Add(this.AssociatedTheme_comboBox);
            this.Controls.Add(this.AssociatedTheme_label);
            this.Controls.Add(this.QuizName_textBox);
            this.Controls.Add(this.QuizName_label);
            this.Name = "QuizAdministration_Form";
            this.Text = "Quizes";
            this.Load += new System.EventHandler(this.QuizAdministration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuizDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuizName_label;
        private System.Windows.Forms.TextBox QuizName_textBox;
        private System.Windows.Forms.Label AssociatedTheme_label;
        private System.Windows.Forms.ComboBox AssociatedTheme_comboBox;
        private System.Windows.Forms.DataGridView QuizDataGridView;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Insert_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private QuizDataSetTableAdapters.ThemeTableAdapter themeTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private QuizDataSetTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn themeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr2DataGridViewTextBoxColumn;
    }
}