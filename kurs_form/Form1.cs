using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kurs_form
{
	public partial class Form1 : Form
	{
		static LinkedList<Worker> workers = new LinkedList<Worker>();
		Worker Current_worker;
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
			workers.AddLast(new Fixed("surname","name","patronymic","post",100000,42));
			workers.AddLast(new Fixed("surname2","name2","patronymic2","post2",110000,41));
			//NameTextBox.Text = Current_worker.Name;
		}

		private void FirstButton_Click(object sender, EventArgs e)
		{
			Current_worker = workers.First();
			Show_new_worker();
		}

		private void LastButton_Click(object sender, EventArgs e)
		{
			Current_worker = workers.Last();
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
		}
	}
}
