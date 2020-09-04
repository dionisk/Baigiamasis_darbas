namespace Baigiamasis_Darbas
{
    partial class Main_Form
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
            this.Themes_button = new System.Windows.Forms.Button();
            this.Quizes_button = new System.Windows.Forms.Button();
            this.Questions_button = new System.Windows.Forms.Button();
            this.AdministrationModule_label = new System.Windows.Forms.Label();
            this.QuizStart_button = new System.Windows.Forms.Button();
            this.Choosing_label = new System.Windows.Forms.Label();
            this.Theme_label = new System.Windows.Forms.Label();
            this.Theme_comboBox = new System.Windows.Forms.ComboBox();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new Baigiamasis_Darbas.QuizDataSet();
            this.QuizName_label = new System.Windows.Forms.Label();
            this.QuizName_comboBox = new System.Windows.Forms.ComboBox();
            this.quizBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.themeTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.ThemeTableAdapter();
            this.quizTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.QuizTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Themes_button
            // 
            this.Themes_button.Location = new System.Drawing.Point(12, 45);
            this.Themes_button.Name = "Themes_button";
            this.Themes_button.Size = new System.Drawing.Size(103, 37);
            this.Themes_button.TabIndex = 0;
            this.Themes_button.Text = "Themes";
            this.Themes_button.UseVisualStyleBackColor = true;
            this.Themes_button.Click += new System.EventHandler(this.Themes_button_Click);
            // 
            // Quizes_button
            // 
            this.Quizes_button.Location = new System.Drawing.Point(12, 102);
            this.Quizes_button.Name = "Quizes_button";
            this.Quizes_button.Size = new System.Drawing.Size(103, 41);
            this.Quizes_button.TabIndex = 1;
            this.Quizes_button.Text = "Quiz names";
            this.Quizes_button.UseVisualStyleBackColor = true;
            this.Quizes_button.Click += new System.EventHandler(this.Quizes_button_Click);
            // 
            // Questions_button
            // 
            this.Questions_button.Location = new System.Drawing.Point(12, 166);
            this.Questions_button.Name = "Questions_button";
            this.Questions_button.Size = new System.Drawing.Size(103, 46);
            this.Questions_button.TabIndex = 2;
            this.Questions_button.Text = "Questions";
            this.Questions_button.UseVisualStyleBackColor = true;
            this.Questions_button.Click += new System.EventHandler(this.Questions_button_Click);
            // 
            // AdministrationModule_label
            // 
            this.AdministrationModule_label.AutoSize = true;
            this.AdministrationModule_label.Location = new System.Drawing.Point(13, 13);
            this.AdministrationModule_label.Name = "AdministrationModule_label";
            this.AdministrationModule_label.Size = new System.Drawing.Size(109, 13);
            this.AdministrationModule_label.TabIndex = 3;
            this.AdministrationModule_label.Text = "Administration module";
            // 
            // QuizStart_button
            // 
            this.QuizStart_button.Location = new System.Drawing.Point(399, 135);
            this.QuizStart_button.Name = "QuizStart_button";
            this.QuizStart_button.Size = new System.Drawing.Size(213, 137);
            this.QuizStart_button.TabIndex = 4;
            this.QuizStart_button.Text = "Let\'s start new quiz";
            this.QuizStart_button.UseVisualStyleBackColor = true;
            this.QuizStart_button.Click += new System.EventHandler(this.QuizStart_button_Click);
            // 
            // Choosing_label
            // 
            this.Choosing_label.AutoSize = true;
            this.Choosing_label.Location = new System.Drawing.Point(393, 13);
            this.Choosing_label.Name = "Choosing_label";
            this.Choosing_label.Size = new System.Drawing.Size(216, 13);
            this.Choosing_label.TabIndex = 5;
            this.Choosing_label.Text = "Choose theme and quiz name to start a quiz:";
            // 
            // Theme_label
            // 
            this.Theme_label.AutoSize = true;
            this.Theme_label.Location = new System.Drawing.Point(396, 45);
            this.Theme_label.Name = "Theme_label";
            this.Theme_label.Size = new System.Drawing.Size(43, 13);
            this.Theme_label.TabIndex = 6;
            this.Theme_label.Text = "Theme:";
            // 
            // Theme_comboBox
            // 
            this.Theme_comboBox.DataSource = this.themeBindingSource;
            this.Theme_comboBox.DisplayMember = "Title";
            this.Theme_comboBox.FormattingEnabled = true;
            this.Theme_comboBox.Location = new System.Drawing.Point(466, 42);
            this.Theme_comboBox.Name = "Theme_comboBox";
            this.Theme_comboBox.Size = new System.Drawing.Size(143, 21);
            this.Theme_comboBox.TabIndex = 7;
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
            // QuizName_label
            // 
            this.QuizName_label.AutoSize = true;
            this.QuizName_label.Location = new System.Drawing.Point(399, 87);
            this.QuizName_label.Name = "QuizName_label";
            this.QuizName_label.Size = new System.Drawing.Size(60, 13);
            this.QuizName_label.TabIndex = 8;
            this.QuizName_label.Text = "Quiz name:";
            // 
            // QuizName_comboBox
            // 
            this.QuizName_comboBox.DataSource = this.quizBindingSource;
            this.QuizName_comboBox.DisplayMember = "Quiz_Name";
            this.QuizName_comboBox.FormattingEnabled = true;
            this.QuizName_comboBox.Location = new System.Drawing.Point(466, 87);
            this.QuizName_comboBox.Name = "QuizName_comboBox";
            this.QuizName_comboBox.Size = new System.Drawing.Size(143, 21);
            this.QuizName_comboBox.TabIndex = 9;
            this.QuizName_comboBox.ValueMember = "Id";
            this.QuizName_comboBox.SelectionChangeCommitted += new System.EventHandler(this.QuizName_comboBox_SelectionChangeCommitted);
            // 
            // quizBindingSource
            // 
            this.quizBindingSource.DataMember = "Quiz";
            this.quizBindingSource.DataSource = this.quizDataSet;
            // 
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // quizTableAdapter
            // 
            this.quizTableAdapter.ClearBeforeFill = true;
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 307);
            this.Controls.Add(this.QuizName_comboBox);
            this.Controls.Add(this.QuizName_label);
            this.Controls.Add(this.Theme_comboBox);
            this.Controls.Add(this.Theme_label);
            this.Controls.Add(this.Choosing_label);
            this.Controls.Add(this.QuizStart_button);
            this.Controls.Add(this.AdministrationModule_label);
            this.Controls.Add(this.Questions_button);
            this.Controls.Add(this.Quizes_button);
            this.Controls.Add(this.Themes_button);
            this.Name = "Main_Form";
            this.Text = "Main page";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Themes_button;
        private System.Windows.Forms.Button Quizes_button;
        private System.Windows.Forms.Button Questions_button;
        private System.Windows.Forms.Label AdministrationModule_label;
        private System.Windows.Forms.Button QuizStart_button;
        private System.Windows.Forms.Label Choosing_label;
        private System.Windows.Forms.Label Theme_label;
        private System.Windows.Forms.ComboBox Theme_comboBox;
        private System.Windows.Forms.Label QuizName_label;
        private System.Windows.Forms.ComboBox QuizName_comboBox;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private QuizDataSetTableAdapters.ThemeTableAdapter themeTableAdapter;
        private System.Windows.Forms.BindingSource quizBindingSource;
        private QuizDataSetTableAdapters.QuizTableAdapter quizTableAdapter;
    }
}

