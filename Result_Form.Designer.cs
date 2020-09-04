namespace Baigiamasis_Darbas
{
    partial class Result_Form
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
            this.Result_label = new System.Windows.Forms.Label();
            this.Result_dataGridView = new System.Windows.Forms.DataGridView();
            this.Close_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Result_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Result_label
            // 
            this.Result_label.AutoSize = true;
            this.Result_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result_label.Location = new System.Drawing.Point(311, 41);
            this.Result_label.Name = "Result_label";
            this.Result_label.Size = new System.Drawing.Size(148, 20);
            this.Result_label.TabIndex = 0;
            this.Result_label.Text = "Your result: x from y";
            // 
            // Result_dataGridView
            // 
            this.Result_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Result_dataGridView.Location = new System.Drawing.Point(237, 102);
            this.Result_dataGridView.Name = "Result_dataGridView";
            this.Result_dataGridView.Size = new System.Drawing.Size(319, 226);
            this.Result_dataGridView.TabIndex = 1;
            this.Result_dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Result_dataGridView_CellFormatting);
            // 
            // Close_button
            // 
            this.Close_button.Location = new System.Drawing.Point(596, 375);
            this.Close_button.Name = "Close_button";
            this.Close_button.Size = new System.Drawing.Size(75, 23);
            this.Close_button.TabIndex = 2;
            this.Close_button.Text = "Close";
            this.Close_button.UseVisualStyleBackColor = true;
            this.Close_button.Click += new System.EventHandler(this.Close_button_Click);
            // 
            // Result_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Close_button);
            this.Controls.Add(this.Result_dataGridView);
            this.Controls.Add(this.Result_label);
            this.Name = "Result_Form";
            this.Text = "Result_Form";
            ((System.ComponentModel.ISupportInitialize)(this.Result_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Result_label;
        private System.Windows.Forms.DataGridView Result_dataGridView;
        private System.Windows.Forms.Button Close_button;
    }
}