using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_form
{
	class PerHour : Worker
	{
		public PerHour() : base()
		{
			Salary_per_hour = true;
		}

		public PerHour(string Surname, string Name, string Patronymic, string Post, int Salary, int Time) : base(Surname, Name, Patronymic, Post, Salary, Time)
		{
			Salary_per_hour = true;
		}
		public PerHour(string[] Date) : base(Date[0], Date[1], Date[2], Date[3], int.Parse(Date[4]), int.Parse(Date[5]))
		{
			Salary_per_hour = true;
		}
		public override int Payment()
		{
			return Time * Salary;
		}

		public override string ToString()
		{
			return "Прізвище: " + Surname + " \nІм'я: " + Name + " \nПо-батькові: " + Patronymic + " \nПосада: " + Post + " \nЗарплата за годину: " + Salary + " \nЗарплата за місяць: " + Payment() + " \nГодини роботи: " + Time + "\n";
		}
	}
}