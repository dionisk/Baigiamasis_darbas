namespace Baigiamasis_Darbas
{
    partial class ThemeAdministration_Form
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
            this.Themes_label = new System.Windows.Forms.Label();
            this.ThemesDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.themeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quizDataSet = new Baigiamasis_Darbas.QuizDataSet();
            this.themeTableAdapter = new Baigiamasis_Darbas.QuizDataSetTableAdapters.ThemeTableAdapter();
            this.Close_button = new System.Windows.Forms.Button();
            this.AddTheme_button = new System.Windows.Forms.Button();
            this.EditTheme_button = new System.Windows.Forms.Button();
            this.DeleteTheme_button = new System.Windows.Forms.Button();
            this.Theme_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ThemesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Themes_label
            // 
            this.Themes_label.AutoSize = true;
            this.Themes_label.Location = new System.Drawing.Point(13, 13);
            this.Themes_label.Name = "Themes_label";
            this.Themes_label.Size = new System.Drawing.Size(72, 13);
            this.Themes_label.TabIndex = 0;
            this.Themes_label.Text = "Theme name:";
            // 
            // ThemesDataGridView
            // 
            this.ThemesDataGridView.AutoGenerateColumns = false;
            this.ThemesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ThemesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn});
            this.ThemesDataGridView.DataSource = this.themeBindingSource;
            this.ThemesDataGridView.Location = new System.Drawing.Point(16, 91);
            this.ThemesDataGridView.Name = "ThemesDataGridView";
            this.ThemesDataGridView.Size = new System.Drawing.Size(185, 216);
            this.ThemesDataGridView.TabIndex = 1;
            this.ThemesDataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ThemesDataGridView_RowHeaderMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
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
            // themeTableAdapter
            // 
            this.themeTableAdapter.ClearBeforeFill = true;
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(235, 284);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 2;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // AddTheme_button
            // 
            this.AddTheme_button.Location = new System.Drawing.Point(16, 49);
            this.AddTheme_button.Name = "AddTheme_button";
            this.AddTheme_button.Size = new System.Drawing.Size(58, 23);
            this.AddTheme_button.TabIndex = 3;
            this.AddTheme_button.Text = "Add";
            this.AddTheme_button.UseVisualStyleBackColor = true;
            this.AddTheme_button.Click += new System.EventHandler(this.AddTheme_button_Click);
            // 
            // EditTheme_button
            // 
            this.EditTheme_button.Location = new System.Drawing.Point(80, 49);
            this.EditTheme_button.Name = "EditTheme_button";
            this.EditTheme_button.Size = new System.Drawing.Size(57, 23);
            this.EditTheme_button.TabIndex = 4;
            this.EditTheme_button.Text = "Edit";
            this.EditTheme_button.UseVisualStyleBackColor = true;
            this.EditTheme_button.Click += new System.EventHandler(this.EditTheme_button_Click);
            // 
            // DeleteTheme_button
            // 
            this.DeleteTheme_button.Location = new System.Drawing.Point(143, 49);
            this.DeleteTheme_button.Name = "DeleteTheme_button";
            this.DeleteTheme_button.Size = new System.Drawing.Size(58, 23);
            this.DeleteTheme_button.TabIndex = 5;
            this.DeleteTheme_button.Text = "Delete";
            this.DeleteTheme_button.UseVisualStyleBackColor = true;
            this.DeleteTheme_button.Click += new System.EventHandler(this.DeleteTheme_button_Click);
            // 
            // Theme_textBox
            // 
            this.Theme_textBox.Location = new System.Drawing.Point(92, 13);
            this.Theme_textBox.Name = "Theme_textBox";
            this.Theme_textBox.Size = new System.Drawing.Size(197, 20);
            this.Theme_textBox.TabIndex = 6;
            // 
            // Theme_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 338);
            this.Controls.Add(this.Theme_textBox);
            this.Controls.Add(this.DeleteTheme_button);
            this.Controls.Add(this.EditTheme_button);
            this.Controls.Add(this.AddTheme_button);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.ThemesDataGridView);
            this.Controls.Add(this.Themes_label);
            this.Name = "Theme_Form";
            this.Text = "Themes";
            this.Load += new System.EventHandler(this.Theme_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThemesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quizDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Themes_label;
        private System.Windows.Forms.DataGridView ThemesDataGridView;
        private QuizDataSet quizDataSet;
        private System.Windows.Forms.BindingSource themeBindingSource;
        private QuizDataSetTableAdapters.ThemeTableAdapter themeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button Close_button;
        private System.Windows.Forms.Button AddTheme_button;
        private System.Windows.Forms.Button EditTheme_button;
        private System.Windows.Forms.Button DeleteTheme_button;
        private System.Windows.Forms.TextBox Theme_textBox;
    }
}