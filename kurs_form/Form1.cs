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
		private static LinkedList<Worker> workers = new LinkedList<Worker>();
		private static Worker Current_worker;
		private static int index;
		public Form1()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void InsertButton_Click(object sender, EventArgs e)
		{
			string surname_insert = SurnameTextBox.Text;
			string name_insert = NameTextBox.Text;
			string patronymic_insert = PatronymicTextBox.Text;
			string post_insert = PostComboBox.Text;
			int salary_insert = Convert.ToInt32(SalaryNumericUpDown.Value);
			int time_insert = Convert.ToInt32(SalaryNumericUpDown.Value);

			if (PerHourRadioButton.Checked)
				workers.AddLast(new PerHour(surname_insert, name_insert, patronymic_insert, post_insert, salary_insert, time_insert));
			else
				workers.AddLast(new Fixed(surname_insert, name_insert, patronymic_insert, post_insert, salary_insert, time_insert));

			using (StreamWriter sw = new StreamWriter("Base.txt", true, Encoding.UTF8))
			{
				sw.WriteLine(workers.Last().ToFile());
			}

			Current_worker = workers.Last();
			index = workers.Count();
			Show_new_worker();
		}

		private void FirstButton_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < workers.Count(); i++)
			{
				if (FilterCheck(workers.ElementAt(i)))
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			Show_new_worker();
		}

		private void LastButton_Click(object sender, EventArgs e)
		{
			for (int i = workers.Count - 1; i >= 0; i--)
			{
				if (FilterCheck(workers.ElementAt(i)))
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			Show_new_worker();
		}

		private void Show_new_worker()
		{
			SurnameTextBox.Text = Current_worker.Surname;
			NameTextBox.Text = Current_worker.Name;
			PatronymicTextBox.Text = Current_worker.Patronymic;
			PostComboBox.Text = Current_worker.Post;
			SalaryNumericUpDown.Value = Current_worker.Salary;
			TimeNumericUpDown.Value = Current_worker.Time;

			if (Current_worker.Salary_per_hour)
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
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			for (int i = index + 1; i < workers.Count(); i++)
			{
				if (FilterCheck(workers.ElementAt(i)))
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			Show_new_worker();
		}

		private void PrevButton_Click(object sender, EventArgs e)
		{
			for(int i = index - 1; i >= 0; i--)
			{
				if (FilterCheck(workers.ElementAt(i)))
				{
					Current_worker = workers.ElementAt(i);
					index = i;
					break;
				}
			}
			Show_new_worker();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
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
			FirstButton_Click(sender, e);
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			Change_delete(sender, e, false);
		}

		private void UpdateButton_Click(object sender, EventArgs e)
		{
			Change_delete(sender, e, true);
		}

		private void Change_delete(object sender, EventArgs e, bool change)
		{

			string[] File;
			using (StreamReader sr = new StreamReader("Base.txt", Encoding.UTF8)) // Полностью считываем файл и записываем содержимое в переменную
			{
				File = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
			}
			string modified = $"{SurnameTextBox.Text};{NameTextBox.Text};{PatronymicTextBox.Text};{PostComboBox.Text};{SalaryNumericUpDown.Value};{TimeNumericUpDown.Value};{PerHourRadioButton.Checked}";
			using (StreamWriter sw = new StreamWriter("Base.txt", false, Encoding.UTF8)) // Перезаписываем файл с изменениями
			{
				for (int i = 0; i < File.Length; i++)
				{
					if ((Current_worker.ToFile() == File[i]) && change) // Если изменяем и это та строка, которая надо
					{
						File[i] = modified;
						LinkedListNode<Worker> ph = workers.Find(Current_worker).Previous;
						workers.Remove(Current_worker);
						
						if (PerHourRadioButton.Checked)
							Current_worker = new PerHour(modified.Split(';'));
						else
							Current_worker = new Fixed(modified.Split(';'));

						if (ph != null)
							workers.AddAfter(ph, Current_worker);
						else
							workers.AddFirst(Current_worker);
						Show_new_worker();
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
			{
				NextButton_Click(sender, e);
				Show_new_worker();
			}
		}

		private void FilterCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (FilterCheckBox.Checked)
				FilterGroupBox.Enabled = true;
			else
				FilterGroupBox.Enabled = false;
			
			
		}

		private void FilterPostCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (FilterPostCheckBox.Checked)
				FilterPostComboBox.Enabled = true;
			else
				FilterPostComboBox.Enabled = false;
		}

		private void FilterSalaryCheckBox_CheckedChanged(object sender, EventArgs e)
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
		}

		private void FilterTimeCheckBox_CheckedChanged(object sender, EventArgs e)
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
		}

		private void FilterSalary_per_hourCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (FilterSalary_per_hourCheckBox.Checked)
				FilterSalary_per_hourComboBox.Enabled = true;
			else
				FilterSalary_per_hourComboBox.Enabled = false;
		}

		private bool FilterCheck(Worker w)
		{
			if (FilterCheckBox.Checked && FilterPostCheckBox.Checked && (w.Post.ToString() != FilterPostComboBox.SelectedItem.ToString()))
				return false;
			if (FilterCheckBox.Checked && FilterSalaryCheckBox.Checked)
			{
				switch (FilterTokenSalaryComboBox.SelectedIndex)
				{
					case 0:
					if (!(w.Payment() > FilterSalaryNumericUpDown.Value))
						return false;
					break;
					case 1:
					if (!(w.Payment() >= FilterSalaryNumericUpDown.Value))
						return false;
					break;
					case 2:
					if (!(w.Payment() < FilterSalaryNumericUpDown.Value))
						return false;
					break;
					case 3:
					if (!(w.Payment() <= FilterSalaryNumericUpDown.Value))
						return false;
					break;
					case 4:
					if (!(w.Payment() == FilterSalaryNumericUpDown.Value))
						return false;
					break;
					case 5:
					if (!(w.Payment() != FilterSalaryNumericUpDown.Value))
						return false;
					break;
					default:
					return false;
				}
			}

			if (FilterCheckBox.Checked && FilterTimeCheckBox.Checked)
			{
				switch (FilterTokenTimeComboBox.SelectedIndex)
				{
					case 0:
					if (!(w.Time > FilterTimeNumericUpDown.Value))
						return false;
					break;
					case 1:
					if (!(w.Time >= FilterTimeNumericUpDown.Value))
						return false;
					break;
					case 2:
					if (!(w.Time < FilterTimeNumericUpDown.Value))
						return false;
					break;
					case 3:
					if (!(w.Time <= FilterTimeNumericUpDown.Value))
						return false;
					break;
					case 4:
					if (!(w.Time == FilterTimeNumericUpDown.Value))
						return false;
					break;
					case 5:
					if (!(w.Time != FilterTimeNumericUpDown.Value))
						return false;
					break;
					default:
					return false;
				}
			}

			if (FilterCheckBox.Checked && FilterSalary_per_hourCheckBox.Checked)
			{
				switch (FilterSalary_per_hourComboBox.SelectedIndex)
				{
					case 0:
					if (!w.Salary_per_hour)
						return false;
					break;
					case 1:
					if (w.Salary_per_hour)
						return false;
					break;
					default:
					return false;
				}
			}
			return true;
		}
	}
}