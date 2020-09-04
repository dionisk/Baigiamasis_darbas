namespace Baigiamasis_Darbas
{
    partial class Quiz_Form
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
            this.Previous_button = new System.Windows.Forms.Button();
            this.Next_button = new System.Windows.Forms.Button();
            this.Question_textBox = new System.Windows.Forms.TextBox();
            this.QuestionCount_label = new System.Windows.Forms.Label();
            this.Answer_label = new System.Windows.Forms.Label();
            this.Answer_textBox = new System.Windows.Forms.TextBox();
            this.Finish_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Previous_button
            // 
            this.Previous_button.Location = new System.Drawing.Point(33, 203);
            this.Previous_button.Name = "Previous_button";
            this.Previous_button.Size = new System.Drawing.Size(108, 45);
            this.Previous_button.TabIndex = 0;
            this.Previous_button.Text = "Previous";
            this.Previous_button.UseVisualStyleBackColor = true;
            this.Previous_button.Click += new System.EventHandler(this.Previous_button_Click);
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(599, 203);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(105, 45);
            this.Next_button.TabIndex = 1;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Question_textBox
            // 
            this.Question_textBox.Location = new System.Drawing.Point(243, 65);
            this.Question_textBox.Multiline = true;
            this.Question_textBox.Name = "Question_textBox";
            this.Question_textBox.Size = new System.Drawing.Size(297, 146);
            this.Question_textBox.TabIndex = 2;
            // 
            // QuestionCount_label
            // 
            this.QuestionCount_label.AutoSize = true;
            this.QuestionCount_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionCount_label.Location = new System.Drawing.Point(344, 25);
            this.QuestionCount_label.Name = "QuestionCount_label";
            this.QuestionCount_label.Size = new System.Drawing.Size(80, 25);
            this.QuestionCount_label.TabIndex = 3;
            this.QuestionCount_label.Text = "x from y";
            // 
            // Answer_label
            // 
            this.Answer_label.AutoSize = true;
            this.Answer_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer_label.Location = new System.Drawing.Point(239, 228);
            this.Answer_label.Name = "Answer_label";
            this.Answer_label.Size = new System.Drawing.Size(102, 20);
            this.Answer_label.TabIndex = 4;
            this.Answer_label.Text = "Your answer:";
            // 
            // Answer_textBox
            // 
            this.Answer_textBox.Location = new System.Drawing.Point(243, 266);
            this.Answer_textBox.Multiline = true;
            this.Answer_textBox.Name = "Answer_textBox";
            this.Answer_textBox.Size = new System.Drawing.Size(297, 126);
            this.Answer_textBox.TabIndex = 5;
            // 
            // Finish_button
            // 
            this.Finish_button.Location = new System.Drawing.Point(567, 404);
            this.Finish_button.Name = "Finish_button";
            this.Finish_button.Size = new System.Drawing.Size(94, 34);
            this.Finish_button.TabIndex = 6;
            this.Finish_button.Text = "Finish";
            this.Finish_button.UseVisualStyleBackColor = true;
            this.Finish_button.Click += new System.EventHandler(this.Finish_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(685, 404);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(90, 34);
            this.Cancel_button.TabIndex = 7;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Quiz_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Finish_button);
            this.Controls.Add(this.Answer_textBox);
            this.Controls.Add(this.Answer_label);
            this.Controls.Add(this.QuestionCount_label);
            this.Controls.Add(this.Question_textBox);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Previous_button);
            this.Name = "Quiz_Form";
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Previous_button;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.TextBox Question_textBox;
        private System.Windows.Forms.Label QuestionCount_label;
        private System.Windows.Forms.Label Answer_label;
        private System.Windows.Forms.TextBox Answer_textBox;
        private System.Windows.Forms.Button Finish_button;
        private System.Windows.Forms.Button Cancel_button;
    }
}