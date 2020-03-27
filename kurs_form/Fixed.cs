using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_form
{
	class Fixed : Worker
	{
		public Fixed() : base()
		{
			Salary_per_hour = false;
		}

		public Fixed(string Surname, string Name, string Patronymic, string Post, int Salary, int Time) : base(Surname, Name, Patronymic, Post, Salary, Time)
		{
			Salary_per_hour = false;
		}
		public Fixed(string[] Date) : base(Date[0], Date[1], Date[2], Date[3], int.Parse(Date[4]), int.Parse(Date[5]))
		{
			Salary_per_hour = false;
		}
		public override int Payment()
		{
			return Salary;
		}

		public override string ToString()
		{
			return "Прізвище: " + Surname + " \nІм'я: " + Name + " \nПо-батькові: " + Patronymic + " \nПосада: " + Post + " \nЗарплата: " + Salary + " \nГодини роботи: " + Time + "\n";
		}
	}
}