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
	public partial class Ask_form : Form
	{
		public Ask_form()
		{
			InitializeComponent();
			this.Text = "???";
			maskedTextBox1.Mask = "00";
			maskedTextBox1.Text = "1";
			
		}
		
		public string Count { get; set; }
		private void button1_Click(object sender, EventArgs e)
		{
			Count = maskedTextBox1.Text;
			this.DialogResult=DialogResult.OK;
		}

		private void button_Cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult=DialogResult.Cancel;
			
		}
	}
}
