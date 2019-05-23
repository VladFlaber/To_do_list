using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace exam_task
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        Color def = DefaultBackColor;
		TaskData class1 = new TaskData();
		public Task task
		{ set {

				class1.tasks_to_add.Add(new Task(value.Short_describe, value.Priority,value.Tag, value.Date, value.Time, value.Comment,value.Attached_file));
				listView_last_added_task.Items.Clear();
				listView_last_added_task.Items.Add(value.Short_describe);
				listView_last_added_task.Items[0].SubItems.Add(value.Priority);
				listView_last_added_task.Items[0].SubItems.Add(value.Date);
				listView_last_added_task.Items[0].SubItems.Add(value.Time);
				listView_last_added_task.Items[0].SubItems.Add(value.Tag);			
			  }	
		}	
        public Form1()
        {
            InitializeComponent();
            
            //class1.tasks_to_add = new List<Task>();
            Load += Form1_Load;            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             this.BackColor = Color.Lavender;
            this.Name = "Список дел";
            lbl_time_hours.BackColor = Color.Lavender;
            lbl_time_hours.ForeColor = Color.OliveDrab;
            lbl_time_hours.MinimumSize = new Size(150, 30);
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
            Directory.CreateDirectory("Attached files");
            monthCalendar1.TitleBackColor = Color.Black;
            monthCalendar1.ForeColor = Color.Black;
            set_listview();
        }
        public void set_listview()
        {
            listView_last_added_task.View = View.Details;
            listView_last_added_task.Columns.Add("Описание", 100);
            listView_last_added_task.Columns.Add("Приоритет", 100);
            listView_last_added_task.Columns.Add("Дата выполнения", 110);
            listView_last_added_task.Columns.Add("Время выполнения", 110);
            listView_last_added_task.Columns.Add("Тэг", 75);
            listView_last_added_task.MultiSelect = false;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            lbl_time_hours.Text = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            lbl_time_hours.TextAlign = ContentAlignment.MiddleCenter;
            Invalidate();

        }

        private void btn_add_task_Click(object sender, EventArgs e)
        {
            New_task add_task = new New_task(this);
			add_task.Show();
           
		}

		private void button_show_tasks_Click(object sender, EventArgs e)
        {
            Show_form show = new Show_form(class1.tasks_to_add);
            show.Show();
			
        }

		private void btnSerialize_Click(object sender, EventArgs e)
		{
			class1.SerializeData();
		}

		private void button_add_project_Click(object sender, EventArgs e)
		{
			Ask_form ask =new Ask_form();
			int count=0;
			if (ask.ShowDialog() == DialogResult.OK)
			{
				 count = int.Parse(ask.Count);
			}
			New_task new_project =new New_task(this, count);
			new_project.Show();

			
			
			
		}
	}
}
