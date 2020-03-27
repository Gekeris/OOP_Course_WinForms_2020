namespace kurs_form
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.Close = new System.Windows.Forms.Button();
			this.LastButton = new System.Windows.Forms.Button();
			this.PayButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.NextButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.InsertButton = new System.Windows.Forms.Button();
			this.PrevButton = new System.Windows.Forms.Button();
			this.FirstButton = new System.Windows.Forms.Button();
			this.PostComboBox = new System.Windows.Forms.ComboBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.TimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).BeginInit();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Location = new System.Drawing.Point(493, 279);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(276, 115);
			this.richTextBox1.TabIndex = 53;
			this.richTextBox1.Text = "";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(583, 250);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(99, 23);
			this.button10.TabIndex = 52;
			this.button10.Text = "Запит доцентів";
			this.button10.UseVisualStyleBackColor = true;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(448, 193);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(100, 20);
			this.textBox4.TabIndex = 51;
			// 
			// Close
			// 
			this.Close.Location = new System.Drawing.Point(380, 338);
			this.Close.Name = "Close";
			this.Close.Size = new System.Drawing.Size(75, 23);
			this.Close.TabIndex = 50;
			this.Close.Text = "Close";
			this.Close.UseVisualStyleBackColor = true;
			this.Close.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// LastButton
			// 
			this.LastButton.Location = new System.Drawing.Point(380, 283);
			this.LastButton.Name = "LastButton";
			this.LastButton.Size = new System.Drawing.Size(75, 23);
			this.LastButton.TabIndex = 49;
			this.LastButton.Text = "Last";
			this.LastButton.UseVisualStyleBackColor = true;
			this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
			// 
			// PayButton
			// 
			this.PayButton.Location = new System.Drawing.Point(356, 193);
			this.PayButton.Name = "PayButton";
			this.PayButton.Size = new System.Drawing.Size(75, 23);
			this.PayButton.TabIndex = 48;
			this.PayButton.Text = "Зарплата за місяць";
			this.PayButton.UseVisualStyleBackColor = true;
			// 
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(265, 338);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 47;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			// 
			// NextButton
			// 
			this.NextButton.Location = new System.Drawing.Point(265, 283);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(75, 23);
			this.NextButton.TabIndex = 46;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(146, 338);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(75, 23);
			this.UpdateButton.TabIndex = 45;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			// 
			// InsertButton
			// 
			this.InsertButton.Location = new System.Drawing.Point(31, 338);
			this.InsertButton.Name = "InsertButton";
			this.InsertButton.Size = new System.Drawing.Size(75, 23);
			this.InsertButton.TabIndex = 44;
			this.InsertButton.Text = "Insert";
			this.InsertButton.UseVisualStyleBackColor = true;
			this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
			// 
			// PrevButton
			// 
			this.PrevButton.Location = new System.Drawing.Point(146, 283);
			this.PrevButton.Name = "PrevButton";
			this.PrevButton.Size = new System.Drawing.Size(75, 23);
			this.PrevButton.TabIndex = 43;
			this.PrevButton.Text = "Prev";
			this.PrevButton.UseVisualStyleBackColor = true;
			// 
			// FirstButton
			// 
			this.FirstButton.Location = new System.Drawing.Point(31, 283);
			this.FirstButton.Name = "FirstButton";
			this.FirstButton.Size = new System.Drawing.Size(75, 23);
			this.FirstButton.TabIndex = 42;
			this.FirstButton.Text = "First";
			this.FirstButton.UseVisualStyleBackColor = true;
			this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
			// 
			// PostComboBox
			// 
			this.PostComboBox.FormattingEnabled = true;
			this.PostComboBox.Items.AddRange(new object[] {
            "Викладач",
            "Доцент",
            "Професор",
            "Методист",
            "Електрик",
            "Ректор"});
			this.PostComboBox.Location = new System.Drawing.Point(157, 136);
			this.PostComboBox.Name = "PostComboBox";
			this.PostComboBox.Size = new System.Drawing.Size(100, 21);
			this.PostComboBox.TabIndex = 41;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(583, 85);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(77, 17);
			this.radioButton2.TabIndex = 40;
			this.radioButton2.Text = "Службовці";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(583, 61);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(75, 17);
			this.radioButton1.TabIndex = 39;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Викладачі";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Location = new System.Drawing.Point(157, 111);
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.Size = new System.Drawing.Size(100, 20);
			this.PatronymicTextBox.TabIndex = 36;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(157, 82);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 35;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(157, 56);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
			this.SurnameTextBox.TabIndex = 34;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(66, 191);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(85, 13);
			this.label6.TabIndex = 33;
			this.label6.Text = "Кількість годин";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(90, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 32;
			this.label5.Text = "Ціна 1 год.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(106, 139);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 13);
			this.label4.TabIndex = 31;
			this.label4.Text = "Посада";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(84, 114);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "По-батькові";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(125, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "Ім\'я";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(95, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "Прізвище";
			// 
			// SalaryNumericUpDown
			// 
			this.SalaryNumericUpDown.Location = new System.Drawing.Point(157, 163);
			this.SalaryNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
			this.SalaryNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.SalaryNumericUpDown.TabIndex = 54;
			this.SalaryNumericUpDown.ThousandsSeparator = true;
			// 
			// TimeNumericUpDown
			// 
			this.TimeNumericUpDown.Location = new System.Drawing.Point(157, 189);
			this.TimeNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.TimeNumericUpDown.Name = "TimeNumericUpDown";
			this.TimeNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.TimeNumericUpDown.TabIndex = 55;
			this.TimeNumericUpDown.Tag = "";
			this.TimeNumericUpDown.ThousandsSeparator = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TimeNumericUpDown);
			this.Controls.Add(this.SalaryNumericUpDown);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.LastButton);
			this.Controls.Add(this.PayButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NextButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.InsertButton);
			this.Controls.Add(this.PrevButton);
			this.Controls.Add(this.FirstButton);
			this.Controls.Add(this.PostComboBox);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.PatronymicTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.Button LastButton;
		private System.Windows.Forms.Button PayButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button InsertButton;
		private System.Windows.Forms.Button PrevButton;
		private System.Windows.Forms.Button FirstButton;
		private System.Windows.Forms.ComboBox PostComboBox;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox PatronymicTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
		private System.Windows.Forms.NumericUpDown TimeNumericUpDown;
	}
}

