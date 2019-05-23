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

namespace exam_task
{
    public partial class New_task : Form
    {
        Task new_note = null;
		Form1 parent = null;
        public Task Task
        {
            get
            {
                return new_note;
            }
       }
        public New_task(Form1 form1)
        {
            InitializeComponent();
			parent = form1;
            this.Name = "Добавление дела";
            Load += New_task_Load;
        }
		public int Count { get; set; }
		public New_task(Form1 form1,int count)
		{
			InitializeComponent();
			parent = form1;
			this.Name = "Добавление дела";
			Load += New_task_Load;
			this.Count = count;
		}
		private void New_task_Load(object sender, EventArgs e)
        {
            btn_attach.Text = "";
            Image image= Image.FromFile("2.png");
            btn_attach.Image = Image.FromFile("2.png");
			this.ActiveControl = textBox_short_description;
			textBox_short_description.MaxLength = 20;
            textBox_short_description.TextChanged += TextBox_short_description_TextChanged;
            textBox_short_description.Focus();
            add_tooltips();
            dateTimePicker1.MinDate = DateTime.Now;
            btn_attach.Enabled = false;
            radioButton_priority_low.Checked = true;
        }

        private void TextBox_short_description_TextChanged(object sender, EventArgs e)
        {
            if (textBox_short_description.Text!="")
            {
                btn_attach.Enabled = true;
            }            
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
        // сброс записей
        public void refresh()
        {
            maskedTextBox_time.Text = "";
           
            richTextBox1.Text = "";
            label_attached_path.Text = "";
            radioButton_high.Checked = false;
            radioButton_priority_low.Checked = true;
            radioButton_priority_medium.Checked = false;
        }
        // добавляем подсказки к основным полям
        public void add_tooltips()
        {
            ToolTip tt1 = new ToolTip();
            ToolTip tt3 = new ToolTip();
            ToolTip tt4 = new ToolTip();
            ToolTip tt5 = new ToolTip();
            ToolTip tt6 = new ToolTip();
            tt1.InitialDelay = 0;
            tt3.InitialDelay = 0;
            tt4.InitialDelay = 0;
            tt5.InitialDelay = 0;
            tt6.InitialDelay = 0;
            tt1.ToolTipIcon = ToolTipIcon.Info;
            tt1.ToolTipTitle = "Подсказка";
            tt1.SetToolTip(textBox_short_description,"Не больше 20 символов");
           
            tt3.ToolTipIcon = ToolTipIcon.Info;
            tt3.ToolTipTitle = "Формат времени";
            tt3.SetToolTip(maskedTextBox_time, "ЧЧ/ММ");
            tt4.ToolTipIcon = ToolTipIcon.Info;
            tt4.ToolTipTitle = "Подсказка";
            tt4.SetToolTip(textBox_tag, "Добавив тэг , Вы присваете это дело к группе , если дела с таким же тэгом уже существуют.\n Не обязательно к заполнению");
            tt5.ToolTipIcon = ToolTipIcon.Info;
            tt5.ToolTipTitle = "Подсказка";
            tt5.SetToolTip(btn_attach, "Поле 'Краткое описание' должно быть заполнено!");
            tt6.ToolTipIcon = ToolTipIcon.Info;
            tt6.ToolTipTitle = "Подсказка";
            tt6.SetToolTip(button_refresh, "Сбросить заполненую форму");
        }
        private void button_refresh_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            new_note = new Task();
            new_note.Short_describe = textBox_short_description.Text;
            new_note.Date = dateTimePicker1.Text;
            new_note.Time = maskedTextBox_time.Text;
           
           
            if (textBox_tag.Text=="")
            {
                new_note.Tag = "Нет";
            }
            else
            {
                new_note.Tag = textBox_tag.Text;
            }
            new_note.Comment = richTextBox1.Text;
            
            if (radioButton_high.Checked == true)
            {
               
                new_note.Priority = "Высокий";
            }
            else if (radioButton_priority_medium.Checked == true)
            {
                new_note.Priority = "Средний";

            }
            else if (radioButton_priority_low.Checked == true)
            {
                new_note.Priority = "Низкий";
            }
            new_note.Attached_file = "";
            //attach file
            if (label_attached_path.Text!=""&&textBox_short_description.Text!="")
            {
                Directory.CreateDirectory("Attached files\\" + textBox_short_description.Text);
                string new_file = Path.GetFileName(label_attached_path.Text);
                // full path to atached files
                string full_path = "Attached files\\" + textBox_short_description.Text + "\\" + new_file;
                File.Copy(label_attached_path.Text, full_path);
                new_note.Attached_file = full_path;
            }
            parent.task = new_note;

            MessageBox.Show(new_note.ToString(),"Дело добавлено ",MessageBoxButtons.OK,MessageBoxIcon.Information);
			
			textBox_tag.Text = new_note.Tag;
			textBox_tag.ReadOnly = true;
			
			refresh();
			Count--;
			if (Count==0)
			{
				this.Close();
			}
			//this.Close();       
		}
       
        private void btn_attach_Click(object sender, EventArgs e)
        {
            if (textBox_short_description.Text!="")
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    label_attached_path.Text = dialog.FileName;

                }
            }
        }
    }
}
