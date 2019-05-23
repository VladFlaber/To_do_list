namespace exam_task
{
    partial class New_task
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
            this.maskedTextBox_time = new System.Windows.Forms.MaskedTextBox();
            this.radioButton_priority_low = new System.Windows.Forms.RadioButton();
            this.radioButton_priority_medium = new System.Windows.Forms.RadioButton();
            this.radioButton_high = new System.Windows.Forms.RadioButton();
            this.label_priority = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label_add_comm = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.btn_attach = new System.Windows.Forms.Button();
            this.textBox_tag = new System.Windows.Forms.TextBox();
            this.label_tag = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.textBox_short_description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_attached_path = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // maskedTextBox_time
            // 
            this.maskedTextBox_time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_time.Location = new System.Drawing.Point(126, 107);
            this.maskedTextBox_time.Mask = "00:00";
            this.maskedTextBox_time.Name = "maskedTextBox_time";
            this.maskedTextBox_time.Size = new System.Drawing.Size(44, 26);
            this.maskedTextBox_time.TabIndex = 1;
            this.maskedTextBox_time.ValidatingType = typeof(System.DateTime);
            // 
            // radioButton_priority_low
            // 
            this.radioButton_priority_low.AutoSize = true;
            this.radioButton_priority_low.Location = new System.Drawing.Point(126, 156);
            this.radioButton_priority_low.Name = "radioButton_priority_low";
            this.radioButton_priority_low.Size = new System.Drawing.Size(63, 17);
            this.radioButton_priority_low.TabIndex = 2;
            this.radioButton_priority_low.TabStop = true;
            this.radioButton_priority_low.Text = "Низкий";
            this.radioButton_priority_low.UseVisualStyleBackColor = true;
            // 
            // radioButton_priority_medium
            // 
            this.radioButton_priority_medium.AutoSize = true;
            this.radioButton_priority_medium.Location = new System.Drawing.Point(195, 156);
            this.radioButton_priority_medium.Name = "radioButton_priority_medium";
            this.radioButton_priority_medium.Size = new System.Drawing.Size(68, 17);
            this.radioButton_priority_medium.TabIndex = 3;
            this.radioButton_priority_medium.TabStop = true;
            this.radioButton_priority_medium.Text = "Средний";
            this.radioButton_priority_medium.UseVisualStyleBackColor = true;
            // 
            // radioButton_high
            // 
            this.radioButton_high.AutoSize = true;
            this.radioButton_high.Location = new System.Drawing.Point(269, 156);
            this.radioButton_high.Name = "radioButton_high";
            this.radioButton_high.Size = new System.Drawing.Size(70, 17);
            this.radioButton_high.TabIndex = 4;
            this.radioButton_high.TabStop = true;
            this.radioButton_high.Text = "Высокий";
            this.radioButton_high.UseVisualStyleBackColor = true;
            // 
            // label_priority
            // 
            this.label_priority.AutoSize = true;
            this.label_priority.Location = new System.Drawing.Point(15, 160);
            this.label_priority.Name = "label_priority";
            this.label_priority.Size = new System.Drawing.Size(61, 13);
            this.label_priority.TabIndex = 5;
            this.label_priority.Text = "Приоритет";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(15, 120);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(105, 13);
            this.label_time.TabIndex = 6;
            this.label_time.Text = "Время выполнения";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(15, 66);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(98, 13);
            this.label_date.TabIndex = 7;
            this.label_date.Text = "Дата выполнения";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 266);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(408, 103);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // label_add_comm
            // 
            this.label_add_comm.AutoSize = true;
            this.label_add_comm.Location = new System.Drawing.Point(13, 250);
            this.label_add_comm.Name = "label_add_comm";
            this.label_add_comm.Size = new System.Drawing.Size(121, 13);
            this.label_add_comm.TabIndex = 9;
            this.label_add_comm.Text = "Добавить коментарий";
            // 
            // button_OK
            // 
            this.button_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OK.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_OK.Location = new System.Drawing.Point(12, 447);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(120, 23);
            this.button_OK.TabIndex = 10;
            this.button_OK.Text = "Добавить дело";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_cancel
            // 
            this.button_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cancel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancel.Location = new System.Drawing.Point(346, 447);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(75, 23);
            this.button_cancel.TabIndex = 11;
            this.button_cancel.Text = "Отмена";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.button_cancel_Click);
            // 
            // btn_attach
            // 
            this.btn_attach.Location = new System.Drawing.Point(13, 375);
            this.btn_attach.Name = "btn_attach";
            this.btn_attach.Size = new System.Drawing.Size(64, 66);
            this.btn_attach.TabIndex = 12;
            this.btn_attach.Text = "button1";
            this.btn_attach.UseVisualStyleBackColor = true;
            this.btn_attach.Click += new System.EventHandler(this.btn_attach_Click);
            // 
            // textBox_tag
            // 
            this.textBox_tag.Location = new System.Drawing.Point(126, 218);
            this.textBox_tag.Name = "textBox_tag";
            this.textBox_tag.Size = new System.Drawing.Size(100, 20);
            this.textBox_tag.TabIndex = 13;
            // 
            // label_tag
            // 
            this.label_tag.AutoSize = true;
            this.label_tag.Location = new System.Drawing.Point(15, 221);
            this.label_tag.Name = "label_tag";
            this.label_tag.Size = new System.Drawing.Size(78, 13);
            this.label_tag.TabIndex = 14;
            this.label_tag.Text = "Добавить Тэг";
            // 
            // button_refresh
            // 
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_refresh.Location = new System.Drawing.Point(264, 447);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(75, 23);
            this.button_refresh.TabIndex = 15;
            this.button_refresh.Text = "Сброс";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // textBox_short_description
            // 
            this.textBox_short_description.Location = new System.Drawing.Point(126, 12);
            this.textBox_short_description.Name = "textBox_short_description";
            this.textBox_short_description.Size = new System.Drawing.Size(100, 20);
            this.textBox_short_description.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Краткое описание";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(126, 60);
            this.dateTimePicker1.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label_attached_path
            // 
            this.label_attached_path.AutoSize = true;
            this.label_attached_path.Location = new System.Drawing.Point(99, 375);
            this.label_attached_path.Name = "label_attached_path";
            this.label_attached_path.Size = new System.Drawing.Size(0, 13);
            this.label_attached_path.TabIndex = 19;
            // 
            // New_task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 493);
            this.Controls.Add(this.label_attached_path);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_short_description);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label_tag);
            this.Controls.Add(this.textBox_tag);
            this.Controls.Add(this.btn_attach);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_add_comm);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.label_priority);
            this.Controls.Add(this.radioButton_high);
            this.Controls.Add(this.radioButton_priority_medium);
            this.Controls.Add(this.radioButton_priority_low);
            this.Controls.Add(this.maskedTextBox_time);
            this.Name = "New_task";
            this.Text = "New_task";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox maskedTextBox_time;
        private System.Windows.Forms.RadioButton radioButton_priority_low;
        private System.Windows.Forms.RadioButton radioButton_priority_medium;
        private System.Windows.Forms.RadioButton radioButton_high;
        private System.Windows.Forms.Label label_priority;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.Label label_date;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label_add_comm;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
        private System.Windows.Forms.Button btn_attach;
        private System.Windows.Forms.TextBox textBox_tag;
        private System.Windows.Forms.Label label_tag;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.TextBox textBox_short_description;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_attached_path;
    }
}