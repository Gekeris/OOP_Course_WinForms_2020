using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace kurs_form
{
	public partial class Form1 : Form
	{
		private static LinkedList<Worker> workers = new LinkedList<Worker>(); // Лист с рабочими
		private static Worker Current_worker; // Текущий рабочий, который отображается
		private static int index; // Индекс отображаемого рабочего
		public Form1()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e) // Выход
		{
			Application.Exit();
		}

		private void InsertButton_Click(object sender, EventArgs e) // Добавление сотрудников
		{
			string surname_insert = SurnameTextBox.Text; // Считываем с полей данные и записываем в переменные
			string name_insert = NameTextBox.Text;
			string patronymic_insert = PatronymicTextBox.Text;
			string post_insert = PostComboBox.Text;
			int salary_insert = Convert.ToInt32(SalaryNumericUpDown.Value);
			int time_insert = Convert.ToInt32(TimeNumericUpDown.Value);

			bool Duplicate = (surname_insert == "") || (name_insert == "") || (patronymic_insert == "");
			foreach (string s in WorkersListBox.Items) // Проверяем все элементы на то, есть ли дубликат
			{
				if ((s == $"{surname_insert} {name_insert} {patronymic_insert}") || Duplicate)
				{
					Duplicate = true;
					break;
				}
			}
			if (Duplicate)
			{
				using (ErrorForm error = new ErrorForm()) // вывод окна с ошибкой
				{
					error.ShowDialog();
				}
			}
			else
			{
				if (PerHourRadioButton.Checked) // В зависимости от выбора дабавляем элемент в лист
					workers.AddLast(new PerHour(surname_insert, name_insert, patronymic_insert, post_insert, salary_insert, time_insert));
				else
					workers.AddLast(new Fixed(surname_insert, name_insert, patronymic_insert, post_insert, salary_insert, time_insert));

				using (StreamWriter sw = new StreamWriter("Base.txt", true, Encoding.UTF8)) // Записываем в базу
				{
					sw.WriteLine(workers.Last().ToFile());
				}

				Current_worker = workers.Last(); // Устанавливаем добавленого рабочего как текущего и отображаем его
				index = workers.Count() - 1;
				ListBoxCheck(sender,e);
			}
		}

		private void FirstButton_Click(object sender, EventArgs e) // Ищем первого рабочего который подходит
		{
			for (int i = 0; i < workers.Count(); i++) // Проверяем все элементы
			{
				if (FilterCheck(workers.ElementAt(i))) // Проверяем подходит ли рабочий, если да, то делаем его текущим и прекращаем проверку
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			ShowCurrentWorker(); // Отображаем текущего рабочего
		}

		private void LastButton_Click(object sender, EventArgs e) // Ищем последнего рабочего который подходит
		{
			for (int i = workers.Count - 1; i >= 0; i--) // Проверяем все элементы с конца
			{
				if (FilterCheck(workers.ElementAt(i))) // Если подходит, делаем текущим и прекращаем проверку
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			ShowCurrentWorker(); // Отображаем текущего рабочего
		}

		private void ShowCurrentWorker() // Отображаем текущего рабочего
		{
			if (Current_worker != null)
			{
				SurnameTextBox.Text = Current_worker.Surname; // Считываем данные с текущего рабочего и выводим их 
				NameTextBox.Text = Current_worker.Name;
				PatronymicTextBox.Text = Current_worker.Patronymic;
				PostComboBox.Text = Current_worker.Post;
				SalaryNumericUpDown.Value = Current_worker.Salary;
				TimeNumericUpDown.Value = Current_worker.Time;

				if (Current_worker.Salary_per_hour) // Если почасовая оплата, то измененяем поля с выводом данных
				{
					SalaryLabel.Text = "Ціна 1 год.";
					PerHourRadioButton.Checked = true;
					PaymentLabel.Show();
					PaymentTextBox.Text = Current_worker.Payment().ToString();
					PaymentTextBox.Show();
				}
				else
				{
					SalaryLabel.Text = "Зарплата";
					FixedRadioButton.Checked = true;
					PaymentLabel.Hide();
					PaymentTextBox.Hide();
				}

				int i = 0;
				foreach (string s in WorkersListBox.Items) // Проверяем все элементы в листбоксе, пока не найдём текущий элемент
				{
					if (Current_worker.ToListBox() == s)
					{
						WorkersListBox.SelectedIndex = i; // Когда нашли, выделяем его
						break;
					}
					i++;
				}
			}
		}

		private void NextButton_Click(object sender, EventArgs e) // Следующий подходящий работник
		{
			if (index + 1 >= workers.Count()) // Для устранения бага, при удалении последнего элемента
				LastButton_Click(sender, e);
			for (int i = index + 1; i < workers.Count(); i++) // Проверяем всех рабочих, от текущего и до конца
			{
				if (FilterCheck(workers.ElementAt(i))) // Если подходит по фильтру делаем его текущим
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			ShowCurrentWorker();
		}

		private void PrevButton_Click(object sender, EventArgs e) // Предыдущий подходящий работник
		{
			for(int i = index - 1; i >= 0; i--) // Проверяем всех рабочих, от декущего и до первого
			{
				if (FilterCheck(workers.ElementAt(i))) // Если подходит по фильтру делаем его текущим
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			ShowCurrentWorker();
		}

		private void Form1_Load(object sender, EventArgs e) // Выполняеться при запуске программы
		{
			if (!File.Exists("Base.txt")) // Если нету файла базы, создать
				File.WriteAllText("Base.txt", "");

			using (StreamReader Sr = new StreamReader("Base.txt", Encoding.UTF8))
			{
				string[] Lines = Sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); // Делим файл по строкам и удаляем пустые
				foreach (string Line in Lines)
				{
					string[] Block = Line.Split(';'); // Делим строку по частям и отправляем в конструкторы, в зависимости от типа зарплаты
					if (bool.Parse(Block[6]))
						workers.AddLast(new PerHour(Block));
					else
						workers.AddLast(new Fixed(Block));
				}
			}
			FirstButton_Click(sender, e); // Отображаем первого рабочего в списке
			index = 0;
			FilterPostComboBox.SelectedIndex = 0; // Стандартные настройки фильтра, чтобы в фильтре не было ошибок с пустой строкой
			FilterTokenSalaryComboBox.SelectedIndex = 0;
			FilterTokenTimeComboBox.SelectedIndex = 0;
			FilterSalary_per_hourComboBox.SelectedIndex = 0;
			FilterPostComboBox.SelectedIndex = 0;
		}

		private void Change_delete(object sender, EventArgs e)
		{
			bool change = true;
			if (sender.ToString() == "System.Windows.Forms.Button, Text: Видалити") // Если вызывается кнопкой удаления
				change = false;

			string[] File;
			using (StreamReader sr = new StreamReader("Base.txt", Encoding.UTF8)) // Полностью считываем файл и записываем содержимое в переменную
			{
				File = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			}
			string modified = $"{SurnameTextBox.Text};{NameTextBox.Text};{PatronymicTextBox.Text};{PostComboBox.Text};{SalaryNumericUpDown.Value};{TimeNumericUpDown.Value};{PerHourRadioButton.Checked}"; // Изменённая версия рабочего
			using (StreamWriter sw = new StreamWriter("Base.txt", false, Encoding.UTF8)) // Перезаписываем файл с изменениями
			{
				for (int i = 0; i < File.Length; i++)
				{
					if ((Current_worker.ToFile() == File[i]) && change) // Если изменяем и это та строка, которая надо
					{
						File[i] = modified; // Изменяем строку, в которой был прошлый еелмент
						LinkedListNode<Worker> ph = workers.Find(Current_worker).Previous; // Узнаем предыдущего рабочего
						workers.Remove(Current_worker); // Удаляем текущего рабочего

						if (PerHourRadioButton.Checked) // Изменяем текущего рабочего 
							Current_worker = new PerHour(modified.Split(';'));
						else
							Current_worker = new Fixed(modified.Split(';'));

						if (ph != null) // Различные действия в зависимости от того, был ли это первый элемент или нет
							workers.AddAfter(ph, Current_worker);
						else
							workers.AddFirst(Current_worker);
						ShowCurrentWorker();
					}
					else if ((Current_worker.ToFile() == File[i]) && !change) // Если удаляем и это та строка, которая надо
					{
						workers.Remove(Current_worker);
						index--;
						continue;
					}
					sw.WriteLine(File[i]);
				}
			}
			if (!change)
				NextButton_Click(sender, e);
			ListBoxCheck(sender, e);
		}

		private void FilterCheckBox_CheckedChanged(object sender, EventArgs e) // Активация фильтра
		{
			if (FilterCheckBox.Checked)
				FilterGroupBox.Enabled = true;
			else
				FilterGroupBox.Enabled = false;
			ListBoxCheck(sender, e);
		}

		private void FilterPostCheckBox_CheckedChanged(object sender, EventArgs e) // Активация фильра по профессии
		{
			if (FilterPostCheckBox.Checked)
				FilterPostComboBox.Enabled = true;
			else
				FilterPostComboBox.Enabled = false;
			ListBoxCheck(sender,e);
		}

		private void FilterSalaryCheckBox_CheckedChanged(object sender, EventArgs e) // Активация фильра по зарплате
		{
			if (FilterSalaryCheckBox.Checked)
			{
				FilterTokenSalaryComboBox.Enabled = true;
				FilterSalaryNumericUpDown.Enabled = true;
			}
			else
			{
				FilterTokenSalaryComboBox.Enabled = false;
				FilterSalaryNumericUpDown.Enabled = false;
			}
			ListBoxCheck(sender,e);
		}

		private void FilterTimeCheckBox_CheckedChanged(object sender, EventArgs e)  // Активация фильра по времени работы
		{
			if (FilterTimeCheckBox.Checked)
			{
				FilterTokenTimeComboBox.Enabled = true;
				FilterTimeNumericUpDown.Enabled = true;
			}
			else
			{
				FilterTokenTimeComboBox.Enabled = false;
				FilterTimeNumericUpDown.Enabled = false;
			}
			ListBoxCheck(sender,e);
		}

		private void FilterSalary_per_hourCheckBox_CheckedChanged(object sender, EventArgs e)  // Активация фильра по типу зарплаты
		{
			if (FilterSalary_per_hourCheckBox.Checked)
				FilterSalary_per_hourComboBox.Enabled = true;
			else
				FilterSalary_per_hourComboBox.Enabled = false;
			ListBoxCheck(sender,e);
		}

		private bool FilterCheck(Worker w) // Проверка, проходит ли элемент фильтр
		{
			if (FilterCheckBox.Checked) // Включен ли фильтр
			{
				if (FilterPostCheckBox.Checked && (w.Post.ToString() != FilterPostComboBox.SelectedItem.ToString())) // Если фильтр по профессии включен и элемент не проходит проверку по профессии
					return false;

				if (FilterSalaryCheckBox.Checked && !Comparison(Convert.ToInt32(FilterSalaryNumericUpDown.Value), FilterTokenSalaryComboBox.SelectedIndex, w.Payment())) // Если фильтр по зарплате включён и элемент не проходит фильтр
					return false;

				if (FilterTimeCheckBox.Checked && !Comparison(Convert.ToInt32(FilterTimeNumericUpDown.Value), FilterTokenTimeComboBox.SelectedIndex, w.Time)) // Если фильтр по времени и элемент не проходит фильтр
					return false;

				if (FilterSalary_per_hourCheckBox.Checked) // Если фильтр по типу зарплаты включён
				{
					switch (FilterSalary_per_hourComboBox.SelectedIndex) // Узнаём выбор
					{
						case 0:
						if (!w.Salary_per_hour)
							return false;
						break;
						case 1:
						if (w.Salary_per_hour)
							return false;
						break;
					}
				}
			}
			return true;
		}

		private void ListBox_SelectedIndexChanged(object sender, EventArgs e) // Выбор элемента в списке
		{
			int i = 0;
			foreach (Worker w in workers)
			{
				if (w.ToListBox() == WorkersListBox.SelectedItem.ToString())
				{
					Current_worker = w;
					index = i;
					break;
				}
				i++;
			}
			ShowCurrentWorker();
		}

		private void ListBoxCheck(object sender, EventArgs e) // Отображение содержимого листбокса. Вызывается при изменении настроек фильтра.
		{
			if (!FilterCheck(Current_worker)) // Если текущий элемент не подходит, выбирает первый доступный элемент
				FirstButton_Click(sender, e);
			WorkersListBox.Items.Clear();
			foreach (Worker w in workers)
			{
				if (FilterCheck(w))
					WorkersListBox.Items.Add(w.ToListBox());
			}
			ShowCurrentWorker();
		}

		private void KeyPress_TextBox(object sender, KeyPressEventArgs e) // Запрет использовать что-либо, кроме букв и тире в TextBox
		{
			if (!char.IsLetter(e.KeyChar) && !((e.KeyChar == '\b') || (e.KeyChar == '-')))
				e.Handled = true;
		}

		private bool Comparison(int left, int condition, int right)
		{
			return (condition % 2 == 0) ^ (left.CompareTo(right) + 1 == condition / 2);
		}
	}
}
