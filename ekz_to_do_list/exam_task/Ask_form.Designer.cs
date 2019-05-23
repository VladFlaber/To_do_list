namespace exam_task
{
	partial class Ask_form
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
			this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
			this.btn_ok = new System.Windows.Forms.Button();
			this.button_Cancel = new System.Windows.Forms.Button();
			this.label_question = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// maskedTextBox1
			// 
			this.maskedTextBox1.Location = new System.Drawing.Point(55, 29);
			this.maskedTextBox1.Name = "maskedTextBox1";
			this.maskedTextBox1.Size = new System.Drawing.Size(93, 20);
			this.maskedTextBox1.TabIndex = 0;
			// 
			// btn_ok
			// 
			this.btn_ok.Location = new System.Drawing.Point(31, 55);
			this.btn_ok.Name = "btn_ok";
			this.btn_ok.Size = new System.Drawing.Size(63, 23);
			this.btn_ok.TabIndex = 1;
			this.btn_ok.Text = "Ok";
			this.btn_ok.UseVisualStyleBackColor = true;
			this.btn_ok.Click += new System.EventHandler(this.button1_Click);
			// 
			// button_Cancel
			// 
			this.button_Cancel.Location = new System.Drawing.Point(121, 55);
			this.button_Cancel.Name = "button_Cancel";
			this.button_Cancel.Size = new System.Drawing.Size(58, 23);
			this.button_Cancel.TabIndex = 2;
			this.button_Cancel.Text = "Cancel";
			this.button_Cancel.UseVisualStyleBackColor = true;
			this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
			// 
			// label_question
			// 
			this.label_question.AutoSize = true;
			this.label_question.Location = new System.Drawing.Point(28, 9);
			this.label_question.Name = "label_question";
			this.label_question.Size = new System.Drawing.Size(180, 13);
			this.label_question.TabIndex = 3;
			this.label_question.Text = "Сколько дел вы хотите добавить?";
			// 
			// Ask_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(235, 90);
			this.Controls.Add(this.label_question);
			this.Controls.Add(this.button_Cancel);
			this.Controls.Add(this.btn_ok);
			this.Controls.Add(this.maskedTextBox1);
			this.Name = "Ask_form";
			this.Text = "Ask_form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MaskedTextBox maskedTextBox1;
		private System.Windows.Forms.Button btn_ok;
		private System.Windows.Forms.Button button_Cancel;
		private System.Windows.Forms.Label label_question;
	}
}