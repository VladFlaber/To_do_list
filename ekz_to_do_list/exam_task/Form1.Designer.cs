namespace exam_task
{
    partial class Form1
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
			this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
			this.lbl_time_hours = new System.Windows.Forms.Label();
			this.btn_add_task = new System.Windows.Forms.Button();
			this.button_show_tasks = new System.Windows.Forms.Button();
			this.listView_last_added_task = new System.Windows.Forms.ListView();
			this.label_last_added = new System.Windows.Forms.Label();
			this.btnSerialize = new System.Windows.Forms.Button();
			this.button_add_project = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// monthCalendar1
			// 
			this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
			this.monthCalendar1.Location = new System.Drawing.Point(12, 7);
			this.monthCalendar1.Name = "monthCalendar1";
			this.monthCalendar1.TabIndex = 0;
			// 
			// lbl_time_hours
			// 
			this.lbl_time_hours.AutoSize = true;
			this.lbl_time_hours.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbl_time_hours.Location = new System.Drawing.Point(194, 178);
			this.lbl_time_hours.Name = "lbl_time_hours";
			this.lbl_time_hours.Size = new System.Drawing.Size(0, 27);
			this.lbl_time_hours.TabIndex = 1;
			// 
			// btn_add_task
			// 
			this.btn_add_task.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_add_task.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btn_add_task.Location = new System.Drawing.Point(187, 311);
			this.btn_add_task.Name = "btn_add_task";
			this.btn_add_task.Size = new System.Drawing.Size(164, 40);
			this.btn_add_task.TabIndex = 2;
			this.btn_add_task.Text = "Добавить дело";
			this.btn_add_task.UseVisualStyleBackColor = true;
			this.btn_add_task.Click += new System.EventHandler(this.btn_add_task_Click);
			// 
			// button_show_tasks
			// 
			this.button_show_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_show_tasks.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_show_tasks.Location = new System.Drawing.Point(187, 428);
			this.button_show_tasks.Name = "button_show_tasks";
			this.button_show_tasks.Size = new System.Drawing.Size(164, 40);
			this.button_show_tasks.TabIndex = 3;
			this.button_show_tasks.Text = "Просмотр дел";
			this.button_show_tasks.UseVisualStyleBackColor = true;
			this.button_show_tasks.Click += new System.EventHandler(this.button_show_tasks_Click);
			// 
			// listView_last_added_task
			// 
			this.listView_last_added_task.Location = new System.Drawing.Point(12, 239);
			this.listView_last_added_task.Name = "listView_last_added_task";
			this.listView_last_added_task.Size = new System.Drawing.Size(500, 66);
			this.listView_last_added_task.TabIndex = 4;
			this.listView_last_added_task.UseCompatibleStateImageBehavior = false;
			// 
			// label_last_added
			// 
			this.label_last_added.AutoSize = true;
			this.label_last_added.Location = new System.Drawing.Point(13, 220);
			this.label_last_added.Name = "label_last_added";
			this.label_last_added.Size = new System.Drawing.Size(153, 13);
			this.label_last_added.TabIndex = 5;
			this.label_last_added.Text = "Последнее добавленое дело";
			// 
			// btnSerialize
			// 
			this.btnSerialize.Location = new System.Drawing.Point(436, 312);
			this.btnSerialize.Name = "btnSerialize";
			this.btnSerialize.Size = new System.Drawing.Size(75, 96);
			this.btnSerialize.TabIndex = 6;
			this.btnSerialize.Text = "SaveData";
			this.btnSerialize.UseVisualStyleBackColor = true;
			this.btnSerialize.Click += new System.EventHandler(this.btnSerialize_Click);
			// 
			// button_add_project
			// 
			this.button_add_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_add_project.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button_add_project.Location = new System.Drawing.Point(187, 366);
			this.button_add_project.Name = "button_add_project";
			this.button_add_project.Size = new System.Drawing.Size(164, 42);
			this.button_add_project.TabIndex = 7;
			this.button_add_project.Text = "Добавить проект";
			this.button_add_project.UseVisualStyleBackColor = true;
			this.button_add_project.Click += new System.EventHandler(this.button_add_project_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(529, 480);
			this.Controls.Add(this.button_add_project);
			this.Controls.Add(this.btnSerialize);
			this.Controls.Add(this.label_last_added);
			this.Controls.Add(this.listView_last_added_task);
			this.Controls.Add(this.button_show_tasks);
			this.Controls.Add(this.btn_add_task);
			this.Controls.Add(this.lbl_time_hours);
			this.Controls.Add(this.monthCalendar1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbl_time_hours;
        private System.Windows.Forms.Button btn_add_task;
        private System.Windows.Forms.Button button_show_tasks;
        private System.Windows.Forms.ListView listView_last_added_task;
        private System.Windows.Forms.Label label_last_added;
		private System.Windows.Forms.Button btnSerialize;
		private System.Windows.Forms.Button button_add_project;
	}
}

