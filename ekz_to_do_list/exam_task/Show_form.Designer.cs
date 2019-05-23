namespace exam_task
{
    partial class Show_form
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
            this.listView_task_list = new System.Windows.Forms.ListView();
            this.comboBox_search_criteria = new System.Windows.Forms.ComboBox();
            this.label_search_criteria = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.button_start_search = new System.Windows.Forms.Button();
            this.button_save_to_pdf = new System.Windows.Forms.Button();
            this.maskedTextBox_search_criteria = new System.Windows.Forms.MaskedTextBox();
            this.label_search_text = new System.Windows.Forms.Label();
            this.richTextBox_Commentary = new System.Windows.Forms.RichTextBox();
            this.label_comment = new System.Windows.Forms.Label();
            this.linkLabel_attached_file = new System.Windows.Forms.LinkLabel();
            this.label_att = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView_task_list
            // 
            this.listView_task_list.Location = new System.Drawing.Point(12, 94);
            this.listView_task_list.Name = "listView_task_list";
            this.listView_task_list.Size = new System.Drawing.Size(524, 253);
            this.listView_task_list.TabIndex = 0;
            this.listView_task_list.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_search_criteria
            // 
            this.comboBox_search_criteria.FormattingEnabled = true;
            this.comboBox_search_criteria.Location = new System.Drawing.Point(12, 47);
            this.comboBox_search_criteria.Name = "comboBox_search_criteria";
            this.comboBox_search_criteria.Size = new System.Drawing.Size(146, 21);
            this.comboBox_search_criteria.TabIndex = 1;
            // 
            // label_search_criteria
            // 
            this.label_search_criteria.AutoSize = true;
            this.label_search_criteria.Location = new System.Drawing.Point(12, 30);
            this.label_search_criteria.Name = "label_search_criteria";
            this.label_search_criteria.Size = new System.Drawing.Size(146, 13);
            this.label_search_criteria.TabIndex = 3;
            this.label_search_criteria.Text = "Выберите критерий поиска";
            // 
            // button_close
            // 
            this.button_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_close.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.Location = new System.Drawing.Point(350, 379);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(75, 38);
            this.button_close.TabIndex = 4;
            this.button_close.Text = "Close";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // button_start_search
            // 
            this.button_start_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_start_search.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start_search.Location = new System.Drawing.Point(339, 44);
            this.button_start_search.Name = "button_start_search";
            this.button_start_search.Size = new System.Drawing.Size(75, 23);
            this.button_start_search.TabIndex = 5;
            this.button_start_search.Text = "Поиск";
            this.button_start_search.UseVisualStyleBackColor = true;
            this.button_start_search.Click += new System.EventHandler(this.button_start_search_Click);
            // 
            // button_save_to_pdf
            // 
            this.button_save_to_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_to_pdf.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_save_to_pdf.Location = new System.Drawing.Point(12, 379);
            this.button_save_to_pdf.Name = "button_save_to_pdf";
            this.button_save_to_pdf.Size = new System.Drawing.Size(134, 38);
            this.button_save_to_pdf.TabIndex = 6;
            this.button_save_to_pdf.Text = "Save to PDF";
            this.button_save_to_pdf.UseVisualStyleBackColor = true;
            this.button_save_to_pdf.Click += new System.EventHandler(this.button_save_to_pdf_Click);
            // 
            // maskedTextBox_search_criteria
            // 
            this.maskedTextBox_search_criteria.Location = new System.Drawing.Point(177, 46);
            this.maskedTextBox_search_criteria.Name = "maskedTextBox_search_criteria";
            this.maskedTextBox_search_criteria.Size = new System.Drawing.Size(138, 20);
            this.maskedTextBox_search_criteria.TabIndex = 7;
            // 
            // label_search_text
            // 
            this.label_search_text.AutoSize = true;
            this.label_search_text.Location = new System.Drawing.Point(177, 30);
            this.label_search_text.Name = "label_search_text";
            this.label_search_text.Size = new System.Drawing.Size(138, 13);
            this.label_search_text.TabIndex = 8;
            this.label_search_text.Text = "Введите значение поиска";
            // 
            // richTextBox_Commentary
            // 
            this.richTextBox_Commentary.Location = new System.Drawing.Point(542, 94);
            this.richTextBox_Commentary.Name = "richTextBox_Commentary";
            this.richTextBox_Commentary.Size = new System.Drawing.Size(211, 84);
            this.richTextBox_Commentary.TabIndex = 9;
            this.richTextBox_Commentary.Text = "";
            // 
            // label_comment
            // 
            this.label_comment.AutoSize = true;
            this.label_comment.Location = new System.Drawing.Point(585, 75);
            this.label_comment.Name = "label_comment";
            this.label_comment.Size = new System.Drawing.Size(77, 13);
            this.label_comment.TabIndex = 10;
            this.label_comment.Text = "Комментарий";
            // 
            // linkLabel_attached_file
            // 
            this.linkLabel_attached_file.AutoSize = true;
            this.linkLabel_attached_file.LinkColor = System.Drawing.Color.Black;
            this.linkLabel_attached_file.Location = new System.Drawing.Point(545, 224);
            this.linkLabel_attached_file.Name = "linkLabel_attached_file";
            this.linkLabel_attached_file.Size = new System.Drawing.Size(0, 13);
            this.linkLabel_attached_file.TabIndex = 11;
            // 
            // label_att
            // 
            this.label_att.AutoSize = true;
            this.label_att.Location = new System.Drawing.Point(542, 181);
            this.label_att.Name = "label_att";
            this.label_att.Size = new System.Drawing.Size(118, 13);
            this.label_att.TabIndex = 12;
            this.label_att.Text = "Прикрепленный файл";
            // 
            // Show_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 450);
            this.Controls.Add(this.label_att);
            this.Controls.Add(this.linkLabel_attached_file);
            this.Controls.Add(this.label_comment);
            this.Controls.Add(this.richTextBox_Commentary);
            this.Controls.Add(this.label_search_text);
            this.Controls.Add(this.maskedTextBox_search_criteria);
            this.Controls.Add(this.button_save_to_pdf);
            this.Controls.Add(this.button_start_search);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_search_criteria);
            this.Controls.Add(this.comboBox_search_criteria);
            this.Controls.Add(this.listView_task_list);
            this.Name = "Show_form";
            this.Text = "Show_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_task_list;
        private System.Windows.Forms.ComboBox comboBox_search_criteria;
        private System.Windows.Forms.Label label_search_criteria;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Button button_start_search;
        private System.Windows.Forms.Button button_save_to_pdf;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_search_criteria;
		private System.Windows.Forms.Label label_search_text;
        private System.Windows.Forms.RichTextBox richTextBox_Commentary;
        private System.Windows.Forms.Label label_comment;
        private System.Windows.Forms.LinkLabel linkLabel_attached_file;
        private System.Windows.Forms.Label label_att;
    }
}