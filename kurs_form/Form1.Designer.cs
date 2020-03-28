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
			this.Close = new System.Windows.Forms.Button();
			this.LastButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.NextButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.InsertButton = new System.Windows.Forms.Button();
			this.PrevButton = new System.Windows.Forms.Button();
			this.FirstButton = new System.Windows.Forms.Button();
			this.PostComboBox = new System.Windows.Forms.ComboBox();
			this.PatronymicTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.SurnameTextBox = new System.Windows.Forms.TextBox();
			this.TimeLabel = new System.Windows.Forms.Label();
			this.SalaryLabel = new System.Windows.Forms.Label();
			this.PostLabel = new System.Windows.Forms.Label();
			this.PatronymicLabel = new System.Windows.Forms.Label();
			this.NameLabel = new System.Windows.Forms.Label();
			this.SurnameLabel = new System.Windows.Forms.Label();
			this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.TimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.FilterGroupBox = new System.Windows.Forms.GroupBox();
			this.FilterSalary_per_hourCheckBox = new System.Windows.Forms.CheckBox();
			this.FilterTimeCheckBox = new System.Windows.Forms.CheckBox();
			this.FilterSalaryCheckBox = new System.Windows.Forms.CheckBox();
			this.FilterPostCheckBox = new System.Windows.Forms.CheckBox();
			this.FilterTokenTimeComboBox = new System.Windows.Forms.ComboBox();
			this.FilterTokenSalaryComboBox = new System.Windows.Forms.ComboBox();
			this.FilterSalary_per_hourLabel = new System.Windows.Forms.Label();
			this.FilterSalary_per_hourComboBox = new System.Windows.Forms.ComboBox();
			this.FilterTimeNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.FilterSalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.FilterPostComboBox = new System.Windows.Forms.ComboBox();
			this.FilterTimeLabel = new System.Windows.Forms.Label();
			this.FilterSalaryLabel = new System.Windows.Forms.Label();
			this.FilterPostLabel = new System.Windows.Forms.Label();
			this.PerHourRadioButton = new System.Windows.Forms.RadioButton();
			this.FixedRadioButton = new System.Windows.Forms.RadioButton();
			this.PaymentLabel = new System.Windows.Forms.Label();
			this.PaymentTextBox = new System.Windows.Forms.TextBox();
			this.FilterCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).BeginInit();
			this.FilterGroupBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.FilterTimeNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.FilterSalaryNumericUpDown)).BeginInit();
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
			// DeleteButton
			// 
			this.DeleteButton.Location = new System.Drawing.Point(265, 338);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(75, 23);
			this.DeleteButton.TabIndex = 47;
			this.DeleteButton.Text = "Delete";
			this.DeleteButton.UseVisualStyleBackColor = true;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// NextButton
			// 
			this.NextButton.Location = new System.Drawing.Point(265, 283);
			this.NextButton.Name = "NextButton";
			this.NextButton.Size = new System.Drawing.Size(75, 23);
			this.NextButton.TabIndex = 46;
			this.NextButton.Text = "Next";
			this.NextButton.UseVisualStyleBackColor = true;
			this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(146, 338);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(75, 23);
			this.UpdateButton.TabIndex = 45;
			this.UpdateButton.Text = "Update";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
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
			this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
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
			this.PostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.PostComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.PostComboBox.FormattingEnabled = true;
			this.PostComboBox.Items.AddRange(new object[] {
            "Викладач",
            "Доцент",
            "Професор",
            "Методист",
            "Електрик",
            "Ректор"});
			this.PostComboBox.Location = new System.Drawing.Point(121, 106);
			this.PostComboBox.Name = "PostComboBox";
			this.PostComboBox.Size = new System.Drawing.Size(100, 21);
			this.PostComboBox.TabIndex = 41;
			// 
			// PatronymicTextBox
			// 
			this.PatronymicTextBox.Location = new System.Drawing.Point(121, 81);
			this.PatronymicTextBox.Name = "PatronymicTextBox";
			this.PatronymicTextBox.Size = new System.Drawing.Size(100, 20);
			this.PatronymicTextBox.TabIndex = 36;
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(121, 52);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(100, 20);
			this.NameTextBox.TabIndex = 35;
			// 
			// SurnameTextBox
			// 
			this.SurnameTextBox.Location = new System.Drawing.Point(121, 26);
			this.SurnameTextBox.Name = "SurnameTextBox";
			this.SurnameTextBox.Size = new System.Drawing.Size(100, 20);
			this.SurnameTextBox.TabIndex = 34;
			// 
			// TimeLabel
			// 
			this.TimeLabel.Location = new System.Drawing.Point(30, 161);
			this.TimeLabel.Name = "TimeLabel";
			this.TimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.TimeLabel.Size = new System.Drawing.Size(85, 13);
			this.TimeLabel.TabIndex = 33;
			this.TimeLabel.Text = "Кількість годин";
			this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SalaryLabel
			// 
			this.SalaryLabel.Location = new System.Drawing.Point(48, 135);
			this.SalaryLabel.Name = "SalaryLabel";
			this.SalaryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SalaryLabel.Size = new System.Drawing.Size(67, 13);
			this.SalaryLabel.TabIndex = 32;
			this.SalaryLabel.Text = "Ціна 1 год.";
			this.SalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PostLabel
			// 
			this.PostLabel.Location = new System.Drawing.Point(70, 109);
			this.PostLabel.Name = "PostLabel";
			this.PostLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.PostLabel.Size = new System.Drawing.Size(45, 13);
			this.PostLabel.TabIndex = 31;
			this.PostLabel.Text = "Посада";
			this.PostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PatronymicLabel
			// 
			this.PatronymicLabel.Location = new System.Drawing.Point(48, 84);
			this.PatronymicLabel.Name = "PatronymicLabel";
			this.PatronymicLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.PatronymicLabel.Size = new System.Drawing.Size(67, 13);
			this.PatronymicLabel.TabIndex = 30;
			this.PatronymicLabel.Text = "По-батькові";
			this.PatronymicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NameLabel
			// 
			this.NameLabel.Location = new System.Drawing.Point(89, 55);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NameLabel.Size = new System.Drawing.Size(26, 13);
			this.NameLabel.TabIndex = 29;
			this.NameLabel.Text = "Ім\'я";
			this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SurnameLabel
			// 
			this.SurnameLabel.Location = new System.Drawing.Point(59, 29);
			this.SurnameLabel.Name = "SurnameLabel";
			this.SurnameLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.SurnameLabel.Size = new System.Drawing.Size(56, 13);
			this.SurnameLabel.TabIndex = 28;
			this.SurnameLabel.Text = "Прізвище";
			this.SurnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// SalaryNumericUpDown
			// 
			this.SalaryNumericUpDown.Location = new System.Drawing.Point(121, 133);
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
			this.TimeNumericUpDown.Location = new System.Drawing.Point(121, 159);
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
			// FilterGroupBox
			// 
			this.FilterGroupBox.Controls.Add(this.FilterSalary_per_hourCheckBox);
			this.FilterGroupBox.Controls.Add(this.FilterTimeCheckBox);
			this.FilterGroupBox.Controls.Add(this.FilterSalaryCheckBox);
			this.FilterGroupBox.Controls.Add(this.FilterPostCheckBox);
			this.FilterGroupBox.Controls.Add(this.FilterTokenTimeComboBox);
			this.FilterGroupBox.Controls.Add(this.FilterTokenSalaryComboBox);
			this.FilterGroupBox.Controls.Add(this.FilterSalary_per_hourLabel);
			this.FilterGroupBox.Controls.Add(this.FilterSalary_per_hourComboBox);
			this.FilterGroupBox.Controls.Add(this.FilterTimeNumericUpDown);
			this.FilterGroupBox.Controls.Add(this.FilterSalaryNumericUpDown);
			this.FilterGroupBox.Controls.Add(this.FilterPostComboBox);
			this.FilterGroupBox.Controls.Add(this.FilterTimeLabel);
			this.FilterGroupBox.Controls.Add(this.FilterSalaryLabel);
			this.FilterGroupBox.Controls.Add(this.FilterPostLabel);
			this.FilterGroupBox.Enabled = false;
			this.FilterGroupBox.Location = new System.Drawing.Point(434, 34);
			this.FilterGroupBox.Name = "FilterGroupBox";
			this.FilterGroupBox.Size = new System.Drawing.Size(335, 131);
			this.FilterGroupBox.TabIndex = 56;
			this.FilterGroupBox.TabStop = false;
			// 
			// FilterSalary_per_hourCheckBox
			// 
			this.FilterSalary_per_hourCheckBox.AutoSize = true;
			this.FilterSalary_per_hourCheckBox.Location = new System.Drawing.Point(246, 99);
			this.FilterSalary_per_hourCheckBox.Name = "FilterSalary_per_hourCheckBox";
			this.FilterSalary_per_hourCheckBox.Size = new System.Drawing.Size(59, 17);
			this.FilterSalary_per_hourCheckBox.TabIndex = 69;
			this.FilterSalary_per_hourCheckBox.Text = "Увімк.";
			this.FilterSalary_per_hourCheckBox.UseVisualStyleBackColor = true;
			this.FilterSalary_per_hourCheckBox.CheckedChanged += new System.EventHandler(this.FilterSalary_per_hourCheckBox_CheckedChanged);
			// 
			// FilterTimeCheckBox
			// 
			this.FilterTimeCheckBox.AutoSize = true;
			this.FilterTimeCheckBox.Location = new System.Drawing.Point(246, 73);
			this.FilterTimeCheckBox.Name = "FilterTimeCheckBox";
			this.FilterTimeCheckBox.Size = new System.Drawing.Size(59, 17);
			this.FilterTimeCheckBox.TabIndex = 68;
			this.FilterTimeCheckBox.Text = "Увімк.";
			this.FilterTimeCheckBox.UseVisualStyleBackColor = true;
			this.FilterTimeCheckBox.CheckedChanged += new System.EventHandler(this.FilterTimeCheckBox_CheckedChanged);
			// 
			// FilterSalaryCheckBox
			// 
			this.FilterSalaryCheckBox.AutoSize = true;
			this.FilterSalaryCheckBox.Location = new System.Drawing.Point(246, 47);
			this.FilterSalaryCheckBox.Name = "FilterSalaryCheckBox";
			this.FilterSalaryCheckBox.Size = new System.Drawing.Size(59, 17);
			this.FilterSalaryCheckBox.TabIndex = 67;
			this.FilterSalaryCheckBox.Text = "Увімк.";
			this.FilterSalaryCheckBox.UseVisualStyleBackColor = true;
			this.FilterSalaryCheckBox.CheckedChanged += new System.EventHandler(this.FilterSalaryCheckBox_CheckedChanged);
			// 
			// FilterPostCheckBox
			// 
			this.FilterPostCheckBox.AutoSize = true;
			this.FilterPostCheckBox.Location = new System.Drawing.Point(246, 19);
			this.FilterPostCheckBox.Name = "FilterPostCheckBox";
			this.FilterPostCheckBox.Size = new System.Drawing.Size(59, 17);
			this.FilterPostCheckBox.TabIndex = 66;
			this.FilterPostCheckBox.Text = "Увімк.";
			this.FilterPostCheckBox.UseVisualStyleBackColor = true;
			this.FilterPostCheckBox.CheckedChanged += new System.EventHandler(this.FilterPostCheckBox_CheckedChanged);
			// 
			// FilterTokenTimeComboBox
			// 
			this.FilterTokenTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FilterTokenTimeComboBox.Enabled = false;
			this.FilterTokenTimeComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FilterTokenTimeComboBox.FormattingEnabled = true;
			this.FilterTokenTimeComboBox.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "=",
            "!="});
			this.FilterTokenTimeComboBox.Location = new System.Drawing.Point(100, 72);
			this.FilterTokenTimeComboBox.Name = "FilterTokenTimeComboBox";
			this.FilterTokenTimeComboBox.Size = new System.Drawing.Size(34, 21);
			this.FilterTokenTimeComboBox.TabIndex = 65;
			// 
			// FilterTokenSalaryComboBox
			// 
			this.FilterTokenSalaryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FilterTokenSalaryComboBox.Enabled = false;
			this.FilterTokenSalaryComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FilterTokenSalaryComboBox.FormattingEnabled = true;
			this.FilterTokenSalaryComboBox.Items.AddRange(new object[] {
            ">",
            ">=",
            "<",
            "<=",
            "=",
            "!="});
			this.FilterTokenSalaryComboBox.Location = new System.Drawing.Point(100, 45);
			this.FilterTokenSalaryComboBox.Name = "FilterTokenSalaryComboBox";
			this.FilterTokenSalaryComboBox.Size = new System.Drawing.Size(34, 21);
			this.FilterTokenSalaryComboBox.TabIndex = 64;
			// 
			// FilterSalary_per_hourLabel
			// 
			this.FilterSalary_per_hourLabel.AutoSize = true;
			this.FilterSalary_per_hourLabel.Location = new System.Drawing.Point(25, 100);
			this.FilterSalary_per_hourLabel.Name = "FilterSalary_per_hourLabel";
			this.FilterSalary_per_hourLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.FilterSalary_per_hourLabel.Size = new System.Drawing.Size(72, 13);
			this.FilterSalary_per_hourLabel.TabIndex = 63;
			this.FilterSalary_per_hourLabel.Text = "Тип професії";
			this.FilterSalary_per_hourLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FilterSalary_per_hourComboBox
			// 
			this.FilterSalary_per_hourComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FilterSalary_per_hourComboBox.Enabled = false;
			this.FilterSalary_per_hourComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FilterSalary_per_hourComboBox.FormattingEnabled = true;
			this.FilterSalary_per_hourComboBox.Items.AddRange(new object[] {
            "Викладач",
            "Службовець"});
			this.FilterSalary_per_hourComboBox.Location = new System.Drawing.Point(100, 97);
			this.FilterSalary_per_hourComboBox.Name = "FilterSalary_per_hourComboBox";
			this.FilterSalary_per_hourComboBox.Size = new System.Drawing.Size(140, 21);
			this.FilterSalary_per_hourComboBox.TabIndex = 62;
			// 
			// FilterTimeNumericUpDown
			// 
			this.FilterTimeNumericUpDown.Enabled = false;
			this.FilterTimeNumericUpDown.Location = new System.Drawing.Point(140, 72);
			this.FilterTimeNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.FilterTimeNumericUpDown.Name = "FilterTimeNumericUpDown";
			this.FilterTimeNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.FilterTimeNumericUpDown.TabIndex = 61;
			this.FilterTimeNumericUpDown.Tag = "";
			this.FilterTimeNumericUpDown.ThousandsSeparator = true;
			// 
			// FilterSalaryNumericUpDown
			// 
			this.FilterSalaryNumericUpDown.Enabled = false;
			this.FilterSalaryNumericUpDown.Location = new System.Drawing.Point(140, 46);
			this.FilterSalaryNumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
			this.FilterSalaryNumericUpDown.Name = "FilterSalaryNumericUpDown";
			this.FilterSalaryNumericUpDown.Size = new System.Drawing.Size(100, 20);
			this.FilterSalaryNumericUpDown.TabIndex = 60;
			this.FilterSalaryNumericUpDown.ThousandsSeparator = true;
			// 
			// FilterPostComboBox
			// 
			this.FilterPostComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FilterPostComboBox.Enabled = false;
			this.FilterPostComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
			this.FilterPostComboBox.FormattingEnabled = true;
			this.FilterPostComboBox.Items.AddRange(new object[] {
            "Викладач",
            "Доцент",
            "Професор",
            "Методист",
            "Електрик",
            "Ректор"});
			this.FilterPostComboBox.Location = new System.Drawing.Point(100, 18);
			this.FilterPostComboBox.Name = "FilterPostComboBox";
			this.FilterPostComboBox.Size = new System.Drawing.Size(140, 21);
			this.FilterPostComboBox.TabIndex = 59;
			// 
			// FilterTimeLabel
			// 
			this.FilterTimeLabel.AutoSize = true;
			this.FilterTimeLabel.Location = new System.Drawing.Point(12, 75);
			this.FilterTimeLabel.Name = "FilterTimeLabel";
			this.FilterTimeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.FilterTimeLabel.Size = new System.Drawing.Size(85, 13);
			this.FilterTimeLabel.TabIndex = 58;
			this.FilterTimeLabel.Text = "Кількість годин";
			this.FilterTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FilterSalaryLabel
			// 
			this.FilterSalaryLabel.Location = new System.Drawing.Point(27, 48);
			this.FilterSalaryLabel.Name = "FilterSalaryLabel";
			this.FilterSalaryLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.FilterSalaryLabel.Size = new System.Drawing.Size(67, 13);
			this.FilterSalaryLabel.TabIndex = 57;
			this.FilterSalaryLabel.Text = "Ціна 1 год.";
			this.FilterSalaryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FilterPostLabel
			// 
			this.FilterPostLabel.AutoSize = true;
			this.FilterPostLabel.Location = new System.Drawing.Point(52, 21);
			this.FilterPostLabel.Name = "FilterPostLabel";
			this.FilterPostLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.FilterPostLabel.Size = new System.Drawing.Size(45, 13);
			this.FilterPostLabel.TabIndex = 56;
			this.FilterPostLabel.Text = "Посада";
			this.FilterPostLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PerHourRadioButton
			// 
			this.PerHourRadioButton.AutoSize = true;
			this.PerHourRadioButton.Checked = true;
			this.PerHourRadioButton.Location = new System.Drawing.Point(121, 200);
			this.PerHourRadioButton.Name = "PerHourRadioButton";
			this.PerHourRadioButton.Size = new System.Drawing.Size(73, 17);
			this.PerHourRadioButton.TabIndex = 57;
			this.PerHourRadioButton.TabStop = true;
			this.PerHourRadioButton.Text = "Викладач";
			this.PerHourRadioButton.UseVisualStyleBackColor = true;
			// 
			// FixedRadioButton
			// 
			this.FixedRadioButton.AutoSize = true;
			this.FixedRadioButton.Location = new System.Drawing.Point(121, 224);
			this.FixedRadioButton.Name = "FixedRadioButton";
			this.FixedRadioButton.Size = new System.Drawing.Size(87, 17);
			this.FixedRadioButton.TabIndex = 58;
			this.FixedRadioButton.Text = "Службовець";
			this.FixedRadioButton.UseVisualStyleBackColor = true;
			// 
			// PaymentLabel
			// 
			this.PaymentLabel.AutoSize = true;
			this.PaymentLabel.Location = new System.Drawing.Point(227, 136);
			this.PaymentLabel.Name = "PaymentLabel";
			this.PaymentLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.PaymentLabel.Size = new System.Drawing.Size(55, 13);
			this.PaymentLabel.TabIndex = 59;
			this.PaymentLabel.Text = "Зарплата";
			this.PaymentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// PaymentTextBox
			// 
			this.PaymentTextBox.Location = new System.Drawing.Point(288, 133);
			this.PaymentTextBox.Name = "PaymentTextBox";
			this.PaymentTextBox.ReadOnly = true;
			this.PaymentTextBox.Size = new System.Drawing.Size(100, 20);
			this.PaymentTextBox.TabIndex = 60;
			// 
			// FilterCheckBox
			// 
			this.FilterCheckBox.AutoSize = true;
			this.FilterCheckBox.Location = new System.Drawing.Point(434, 12);
			this.FilterCheckBox.Name = "FilterCheckBox";
			this.FilterCheckBox.Size = new System.Drawing.Size(62, 17);
			this.FilterCheckBox.TabIndex = 61;
			this.FilterCheckBox.Text = "Фільтр";
			this.FilterCheckBox.UseVisualStyleBackColor = true;
			this.FilterCheckBox.CheckedChanged += new System.EventHandler(this.FilterCheckBox_CheckedChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.FilterCheckBox);
			this.Controls.Add(this.PaymentTextBox);
			this.Controls.Add(this.PaymentLabel);
			this.Controls.Add(this.PerHourRadioButton);
			this.Controls.Add(this.FixedRadioButton);
			this.Controls.Add(this.FilterGroupBox);
			this.Controls.Add(this.TimeNumericUpDown);
			this.Controls.Add(this.SalaryNumericUpDown);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.Close);
			this.Controls.Add(this.LastButton);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NextButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.InsertButton);
			this.Controls.Add(this.PrevButton);
			this.Controls.Add(this.FirstButton);
			this.Controls.Add(this.PostComboBox);
			this.Controls.Add(this.PatronymicTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SurnameTextBox);
			this.Controls.Add(this.TimeLabel);
			this.Controls.Add(this.SalaryLabel);
			this.Controls.Add(this.PostLabel);
			this.Controls.Add(this.PatronymicLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.SurnameLabel);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TimeNumericUpDown)).EndInit();
			this.FilterGroupBox.ResumeLayout(false);
			this.FilterGroupBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.FilterTimeNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.FilterSalaryNumericUpDown)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button Close;
		private System.Windows.Forms.Button LastButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.Button NextButton;
		private System.Windows.Forms.Button UpdateButton;
		private System.Windows.Forms.Button InsertButton;
		private System.Windows.Forms.Button PrevButton;
		private System.Windows.Forms.Button FirstButton;
		private System.Windows.Forms.ComboBox PostComboBox;
		private System.Windows.Forms.TextBox PatronymicTextBox;
		private System.Windows.Forms.TextBox NameTextBox;
		private System.Windows.Forms.TextBox SurnameTextBox;
		private System.Windows.Forms.Label TimeLabel;
		private System.Windows.Forms.Label SalaryLabel;
		private System.Windows.Forms.Label PostLabel;
		private System.Windows.Forms.Label PatronymicLabel;
		private System.Windows.Forms.Label NameLabel;
		private System.Windows.Forms.Label SurnameLabel;
		private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
		private System.Windows.Forms.NumericUpDown TimeNumericUpDown;
		private System.Windows.Forms.GroupBox FilterGroupBox;
		private System.Windows.Forms.RadioButton PerHourRadioButton;
		private System.Windows.Forms.RadioButton FixedRadioButton;
		private System.Windows.Forms.Label PaymentLabel;
		private System.Windows.Forms.TextBox PaymentTextBox;
		private System.Windows.Forms.CheckBox FilterCheckBox;
		private System.Windows.Forms.Label FilterSalary_per_hourLabel;
		private System.Windows.Forms.ComboBox FilterSalary_per_hourComboBox;
		private System.Windows.Forms.NumericUpDown FilterTimeNumericUpDown;
		private System.Windows.Forms.NumericUpDown FilterSalaryNumericUpDown;
		private System.Windows.Forms.ComboBox FilterPostComboBox;
		private System.Windows.Forms.Label FilterTimeLabel;
		private System.Windows.Forms.Label FilterSalaryLabel;
		private System.Windows.Forms.Label FilterPostLabel;
		private System.Windows.Forms.ComboBox FilterTokenSalaryComboBox;
		private System.Windows.Forms.ComboBox FilterTokenTimeComboBox;
		private System.Windows.Forms.CheckBox FilterSalary_per_hourCheckBox;
		private System.Windows.Forms.CheckBox FilterTimeCheckBox;
		private System.Windows.Forms.CheckBox FilterSalaryCheckBox;
		private System.Windows.Forms.CheckBox FilterPostCheckBox;
	}
}

