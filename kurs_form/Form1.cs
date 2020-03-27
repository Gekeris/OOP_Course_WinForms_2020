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
		static LinkedList<Worker> workers = new LinkedList<Worker>();
		Worker Current_worker;
		int index;
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
			
			workers.AddLast(new Fixed(surname_insert, name_insert, patronymic_insert, post_insert, salary_insert, time_insert));
			Current_worker = workers.Last();
		}

		private void FirstButton_Click(object sender, EventArgs e)
		{
			Current_worker = workers.First();
			index = 0;
			Show_new_worker();
		}

		private void LastButton_Click(object sender, EventArgs e)
		{
			Current_worker = workers.Last();
			index = workers.Count();
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
			}
			else
			{
				SalaryLabel.Text = "Зарплата";
				FixedRadioButton.Checked = true;
			}
		}

		private void NextButton_Click(object sender, EventArgs e)
		{
			if (index < workers.Count() - 1)
			{
				Current_worker = workers.ElementAt(++index);
				Show_new_worker();
			}
		}

		private void PrevButton_Click(object sender, EventArgs e)
		{
			if (index > 0)
			{
				Current_worker = workers.ElementAt(--index);
				Show_new_worker();
			}
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
			FirstButton_Click(sender,e);
		}


	}
}
