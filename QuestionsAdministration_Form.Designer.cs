namespace Baigiamasis_Darbas
{
    partial class QuestionsAdministration_Form
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
            this.Theme_label = new System.Windows.Forms.Label();
            this.QuizName_label = new System.Windows.Forms.Label();
            this.Theme_comboBox = new System.Windows.Forms.ComboBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new Baigiamasis_Darbas.QuizDataSet();
            this.QuizName_comboBox = new System.Windows.Forms.ComboBox();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Question_label = new System.Windows.Forms.Label();
            this.Question_textBox = new System.Windows.Forms.TextBox();
            this.Answer_label = new System.Windows.Forms.Label();
            this.Answer_textBox = new System.Windows.Forms.TextBox();
            this.Questions_dataGridView = new System.Windows.Forms.DataGridView();
            this.quizquestionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.ThemeTableAdapter();
            this.quizTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.QuizTableAdapter();
            this.quiz_questionsTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.Quiz_questionsTableAdapter();
            this.Close_button = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Delete_button = new System.Windows.Forms.Button();
            this.QuiznameChange_label = new System.Windows.Forms.Label();
            this.QuizNameChange_comboBox = new System.Windows.Forms.ComboBox();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quizidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.answerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Questions_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizquestionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Theme_label
            // 
            this.Theme_label.AutoSize = true;
            this.Theme_label.Location = new System.Drawing.Point(23, 24);
            this.Theme_label.Name = "Theme_label";
            this.Theme_label.Size = new System.Drawing.Size(78, 13);
            this.Theme_label.TabIndex = 0;
            this.Theme_label.Text = "Choose theme:";
            // 
            // QuizName_label
            // 
            this.QuizName_label.AutoSize = true;
            this.QuizName_label.Location = new System.Drawing.Point(23, 62);
            this.QuizName_label.Name = "QuizName_label";
            this.QuizName_label.Size = new System.Drawing.Size(97, 13);
            this.QuizName_label.TabIndex = 1;
            this.QuizName_label.Text = "Choose quiz name:";
            // 
            // Theme_comboBox
            // 
            this.Theme_comboBox.DataSource = this.themeBindingSource;
            this.Theme_comboBox.DisplayMember = "Title";
            this.Theme_comboBox.FormattingEnabled = true;
            this.Theme_comboBox.Location = new System.Drawing.Point(135, 24);
            this.Theme_comboBox.Name = "Theme_comboBox";
            this.Theme_comboBox.Size = new System.Drawing.Size(220, 21);
            this.Theme_comboBox.TabIndex = 2;
            this.Theme_comboBox.ValueMember = "Id";
            this.Theme_comboBox.SelectionChangeCommitted += new System.EventHandler(this.Theme_comboBox_SelectionChangeCommitted);
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
            // QuizName_comboBox
            // 
            this.QuizName_comboBox.DataSource = this.quizBindingSource;
            this.QuizName_comboBox.DisplayMember = "Quiz_Name";
            this.QuizName_comboBox.FormattingEnabled = true;
            this.QuizName_comboBox.Location = new System.Drawing.Point(135, 62);
            this.QuizName_comboBox.Name = "QuizName_comboBox";
            this.QuizName_comboBox.Size = new System.Drawing.Size(220, 21);
            this.QuizName_comboBox.TabIndex = 3;
            this.QuizName_comboBox.ValueMember = "Id";
            this.QuizName_comboBox.SelectionChangeCommitted += new System.EventHandler(this.QuizName_comboBox_SelectionChangeCommitted);
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "Quiz";
            this.quizBindingSource.DataSource = this.quizDataSet;
            // 
            // Question_label
            // 
            this.Question_label.AutoSize = true;
            this.Question_label.Location = new System.Drawing.Point(23, 127);
            this.Question_label.Name = "Question_label";
            this.Question_label.Size = new System.Drawing.Size(52, 13);
            this.Question_label.TabIndex = 4;
            this.Question_label.Text = "Question:";
            // 
            // Question_textBox
            // 
            this.Question_textBox.Location = new System.Drawing.Point(94, 124);
            this.Question_textBox.Multiline = true;
            this.Question_textBox.Name = "Question_textBox";
            this.Question_textBox.Size = new System.Drawing.Size(261, 162);
            this.Question_textBox.TabIndex = 5;
            // 
            // Answer_label
            // 
            this.Answer_label.AutoSize = true;
            this.Answer_label.Location = new System.Drawing.Point(418, 127);
            this.Answer_label.Name = "Answer_label";
            this.Answer_label.Size = new System.Drawing.Size(45, 13);
            this.Answer_label.TabIndex = 6;
            this.Answer_label.Text = "Answer:";
            // 
            // Answer_textBox
            // 
            this.Answer_textBox.Location = new System.Drawing.Point(494, 124);
            this.Answer_textBox.Multiline = true;
            this.Answer_textBox.Name = "Answer_textBox";
            this.Answer_textBox.Size = new System.Drawing.Size(271, 162);
            this.Answer_textBox.TabIndex = 7;
            // 
            // Questions_dataGridView
            // 
            this.Questions_dataGridView.AutoGenerateColumns = false;
            this.Questions_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Questions_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.quizidDataGridViewTextBoxColumn,
            this.questionDataGridViewTextBoxColumn,
            this.answerDataGridViewTextBoxColumn});
            this.Questions_dataGridView.DataSource = this.quizquestionsBindingSource;
            this.Questions_dataGridView.Location = new System.Drawing.Point(26, 347);
            this.Questions_dataGridView.Name = "Questions_dataGridView";
            this.Questions_dataGridView.Size = new System.Drawing.Size(646, 261);
            this.Questions_dataGridView.TabIndex = 8;
            this.Questions_dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Questions_dataGridView_RowHeaderMouseClick);
            // 
            // quizquestionsBindingSource
            // 
            this.quizquestionsBindingSource.DataMember = "Quiz_questions";
            this.quizquestionsBindingSource.DataSource = this.quizDataSet;
            // 
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // quiz_questionsTableAdapter
            // 
            this.quiz_questionsTableAdapter.ClearBeforeFill = true;
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(597, 630);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 9;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(690, 466);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(75, 23);
            this.Add_button.TabIndex = 10;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(690, 506);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(75, 23);
            this.Edit_button.TabIndex = 11;
            this.Edit_button.Text = "Edit";
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(690, 545);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(75, 23);
            this.Delete_button.TabIndex = 12;
            this.Delete_button.Text = "Delete";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // QuiznameChange_label
            // 
            this.QuiznameChange_label.AutoSize = true;
            this.QuiznameChange_label.Location = new System.Drawing.Point(26, 312);
            this.QuiznameChange_label.Name = "QuiznameChange_label";
            this.QuiznameChange_label.Size = new System.Drawing.Size(141, 13);
            this.QuiznameChange_label.TabIndex = 13;
            this.QuiznameChange_label.Text = "Change question quiz name:";
            // 
            // QuizNameChange_comboBox
            // 
            this.QuizNameChange_comboBox.DataSource = this.quizBindingSource;
            this.QuizNameChange_comboBox.DisplayMember = "Quiz_Name";
            this.QuizNameChange_comboBox.FormattingEnabled = true;
            this.QuizNameChange_comboBox.Location = new System.Drawing.Point(174, 312);
            this.QuizNameChange_comboBox.Name = "QuizNameChange_comboBox";
            this.QuizNameChange_comboBox.Size = new System.Drawing.Size(158, 21);
            this.QuizNameChange_comboBox.TabIndex = 14;
            this.QuizNameChange_comboBox.ValueMember = "Id";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // quizidDataGridViewTextBoxColumn
            // 
            this.quizidDataGridViewTextBoxColumn.DataPropertyName = "Quiz_id";
            this.quizidDataGridViewTextBoxColumn.HeaderText = "Quiz_id";
            this.quizidDataGridViewTextBoxColumn.Name = "quizidDataGridViewTextBoxColumn";
            this.quizidDataGridViewTextBoxColumn.Visible = false;
            // 
            // questionDataGridViewTextBoxColumn
            // 
            this.questionDataGridViewTextBoxColumn.DataPropertyName = "Question";
            this.questionDataGridViewTextBoxColumn.HeaderText = "Question";
            this.questionDataGridViewTextBoxColumn.Name = "questionDataGridViewTextBoxColumn";
            // 
            // answerDataGridViewTextBoxColumn
            // 
            this.answerDataGridViewTextBoxColumn.DataPropertyName = "Answer";
            this.answerDataGridViewTextBoxColumn.HeaderText = "Answer";
            this.answerDataGridViewTextBoxColumn.Name = "answerDataGridViewTextBoxColumn";
            // 
            // QuestionsAdministration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.QuizNameChange_comboBox);
            this.Controls.Add(this.QuiznameChange_label);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.Edit_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Questions_dataGridView);
            this.Controls.Add(this.Answer_textBox);
            this.Controls.Add(this.Answer_label);
            this.Controls.Add(this.Question_textBox);
            this.Controls.Add(this.Question_label);
            this.Controls.Add(this.QuizName_comboBox);
            this.Controls.Add(this.Theme_comboBox);
            this.Controls.Add(this.QuizName_label);
            this.Controls.Add(this.Theme_label);
            this.Name = "QuestionsAdministration_Form";
            this.Text = "Questions";
            this.Load += new System.EventHandler(this.QuestionsAdministration_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Questions_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizquestionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Theme_label;
        private System.Windows.Forms.Label QuizName_label;
        private System.Windows.Forms.ComboBox Theme_comboBox;
        private System.Windows.Forms.ComboBox QuizName_comboBox;
        private System.Windows.Forms.Label Question_label;
        private System.Windows.Forms.TextBox Question_textBox;
        private System.Windows.Forms.Label Answer_label;
        private System.Windows.Forms.TextBox Answer_textBox;
        private System.Windows.Forms.DataGridView Questions_dataGridView;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private QuizDataSetTableAdapters.ThemeTableAdapter themeTableAdapter;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private QuizDataSetTableAdapters.QuizTableAdapter quizTableAdapter;
        private System.Windows.Forms.BindingSource quizquestionsBindingSource;
        private QuizDataSetTableAdapters.Quiz_questionsTableAdapter quiz_questionsTableAdapter;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Label QuiznameChange_label;
        private System.Windows.Forms.ComboBox QuizNameChange_comboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quizidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn answerDataGridViewTextBoxColumn;
    }
}