using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_task
{
    public partial class Show_form : Form
    {

        List<Task> Tasks = null;
        List<string> comments = null;
        List<string> attached_files = null;


        public Show_form()
        {
            InitializeComponent();

        }
        public Show_form(List<Task> tasks)
        {
            InitializeComponent();
            comments = new List<string>();
            attached_files = new List<string>();
            //transfered list from parent form
            this.Tasks = tasks;
            this.Name = "Просмотр";
			Load += Show_form_Load1;

        }

        public void testpdf()
        {
            PdfPTable pdfTable = new PdfPTable(listView_task_list.Columns.Count);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            
                
            //Adding Header row
            foreach (ColumnHeader column in listView_task_list.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.Text));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (ListViewItem itemRow in listView_task_list.Items)
            {
                int i = 0;
                for (i = 0; i < itemRow.SubItems.Count ; i++)
                {
                    pdfTable.AddCell(itemRow.SubItems[i].Text);
                }
            }

            //Exporting to PDF
            string folderPath = @"PDF test\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + DateTime.Now.ToShortDateString()+".pdf", FileMode.Create))
            {
                
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
                // не записывает русский язык
                pdfDoc.AddLanguage("ru-RU");               
                PdfWriter writer= PdfWriter.GetInstance(pdfDoc, stream);               
                writer.SetLanguage("ru-RU");
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();

            }
        }
		
        private void Show_form_Load1(object sender, EventArgs e)
        {
            set_listview();
            set_search_controls();
            richTextBox_Commentary.ReadOnly = true;
            comboBox_search_criteria.SelectedIndexChanged += ComboBox_search_criteria_SelectedIndexChanged;
            maskedTextBox_search_criteria.GotFocus += MaskedTextBox_search_criteria_GotFocus;
            listView_task_list.SelectedIndexChanged += ListView_task_list_SelectedIndexChanged;          
            linkLabel_attached_file.LinkClicked += LinkLabel_attached_file_LinkClicked;
        }

        // open attached file
        private void LinkLabel_attached_file_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel_attached_file.Text != "")
            {
                Process.Start(linkLabel_attached_file.Text);
            }
        }
        //Filling textbox with a commentary from task
        private void ListView_task_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            richTextBox_Commentary.Text = "";
            linkLabel_attached_file.Text = "";
            int index = 0;
            if (listView_task_list.SelectedItems.Count > 0)
            {
                index = listView_task_list.SelectedItems[0].Index;
                richTextBox_Commentary.Text = comments[index];
                linkLabel_attached_file.Text = attached_files[index];
            }
        }

        private void MaskedTextBox_search_criteria_GotFocus(object sender, EventArgs e)
        {
            maskedTextBox_search_criteria.Text = "";
        }

        private void ComboBox_search_criteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_search_criteria.SelectedIndex == 0)
            {
                maskedTextBox_search_criteria.Text = "";
                maskedTextBox_search_criteria.Enabled = false;
            }
            else if (comboBox_search_criteria.SelectedIndex == 1)
            {
				maskedTextBox_search_criteria.Mask = "00.00.0000";

				maskedTextBox_search_criteria.Enabled = true;

            }
            else if (comboBox_search_criteria.SelectedIndex == 2)
            {
                maskedTextBox_search_criteria.Text = "Введите описание";
                maskedTextBox_search_criteria.Enabled = true;
				maskedTextBox_search_criteria.Mask = "";


			}
			else if (comboBox_search_criteria.SelectedIndex == 3)
            {
				maskedTextBox_search_criteria.Text = "Введите тэг";
				maskedTextBox_search_criteria.Mask = "";

				maskedTextBox_search_criteria.Enabled = true;
            }
			else if (comboBox_search_criteria.SelectedIndex == 4)
			{
				maskedTextBox_search_criteria.Text = "Уровень приоритета ";
				maskedTextBox_search_criteria.Mask = "";
				maskedTextBox_search_criteria.Enabled = true;
			}
			else
			{
				maskedTextBox_search_criteria.Enabled = false;
			}
		}
        //  listview design
        public void set_listview()
        {
            listView_task_list.View = View.Details;
            listView_task_list.GridLines = true;
            listView_task_list.FullRowSelect = true;
            listView_task_list.AllowDrop = true;
            listView_task_list.Columns.Add("Описание", 100);
            listView_task_list.Columns.Add("Приоритет", 100);
            listView_task_list.Columns.Add("Дата выполнения", 125);
            listView_task_list.Columns.Add("Время выполнения", 125);
            listView_task_list.Columns.Add("Тэг", 75);


        }
        //combobox design
        public void set_search_controls()
        {
            comboBox_search_criteria.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_search_criteria.Items.Add("Весь список");
            comboBox_search_criteria.Items.Add("Поиск по дате");
            comboBox_search_criteria.Items.Add("Поиск по описанию");
            comboBox_search_criteria.Items.Add("Поиск по тэгу");
            comboBox_search_criteria.Items.Add("Поиск по приоритету");
            comboBox_search_criteria.Items.Add("На этот день");
            comboBox_search_criteria.Items.Add("На 7 дней");
            comboBox_search_criteria.Items.Add("На 30 дней");
            comboBox_search_criteria.SelectedIndex = 0;
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //fill the listview with list items from event below
        public void fill_listview(int i, int j)
        {
            listView_task_list.Items.Add(Tasks[i].Short_describe);
            listView_task_list.Items[j].SubItems.Add(Tasks[i].Priority);
            listView_task_list.Items[j].SubItems.Add(Tasks[i].Date);
            listView_task_list.Items[j].SubItems.Add(Tasks[i].Time);
            listView_task_list.Items[j].SubItems.Add(Tasks[i].Tag);

            comments.Add(Tasks[i].Comment);
            attached_files.Add(Tasks[i].Attached_file);

        }
       
        //checks and fills listview with matches from search request
        private void button_start_search_Click(object sender, EventArgs e)
        {
            listView_task_list.Items.Clear();
            int j = 0;
            DateTime date1 = DateTime.Now;
            DateTime tmp_date = new DateTime();
            for (int i = 0; i < Tasks.Count; i++)
            {
                if (comboBox_search_criteria.SelectedIndex == 0)
                {
                    fill_listview(i, j);
                    j++;
                }
                else if (comboBox_search_criteria.SelectedIndex == 1)
                {
                    if (Tasks[i].Date == maskedTextBox_search_criteria.Text)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }
                else if (comboBox_search_criteria.SelectedIndex == 2)
                {
                    if (Tasks[i].Short_describe == maskedTextBox_search_criteria.Text)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }
                else if (comboBox_search_criteria.SelectedIndex == 3)
                {
                    if (Tasks[i].Tag == maskedTextBox_search_criteria.Text)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }
                else if (comboBox_search_criteria.SelectedIndex == 4)
                {
                    if (Tasks[i].Priority == maskedTextBox_search_criteria.Text)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }
                else if (comboBox_search_criteria.SelectedIndex == 5)
                {

                    tmp_date = DateTime.Parse(Tasks[i].Date);
                    if (tmp_date.Year == date1.Year && tmp_date.Month == date1.Month && tmp_date.Day == date1.Day)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }
                else if (comboBox_search_criteria.SelectedIndex == 6)
                {
                    tmp_date = DateTime.Parse(Tasks[i].Date);

                    if (date1.AddDays(7) > tmp_date)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }
                else if (comboBox_search_criteria.SelectedIndex == 7)
                {
                    tmp_date = DateTime.Parse(Tasks[i].Date);

                    if (date1.AddDays(30) > tmp_date)
                    {
                        fill_listview(i, j);
                        j++;

                    }
                }

           }
        }
        private void button_save_to_pdf_Click(object sender, EventArgs e)
        {
            testpdf();
            MessageBox.Show("PDF файл сохранен.");
        }

        
    }
}
