using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs_form
{
	abstract class Worker // Базовый клас, для работника
	{
		public string Surname { get; set; } // Фамилия
		public string Name { get; set; } // Имя
		public string Patronymic { get; set; } // Отчество
		public string Post { get; set; } // Должность
		public int Salary { get; set; } // Зарплата(Зарплата в час)
		public int Time { get; set; } // Кол. отработанных часов 
		public bool Salary_per_hour { get; set; } // Тип зарплаты (true = по часовая, false = фиксированная)
		public Worker()
		{
			Surname = "none";
			Name = "none";
			Patronymic = "none";
			Post = "none";
			Salary = -1;
			Time = -1;
		}

		public Worker(string surname, string name, string patronymic, string post, int salary, int time)
		{
			Surname = surname;
			Name = name;
			Patronymic = patronymic;
			Post = post;
			Salary = salary;
			Time = time;
		}

		public virtual int Payment() // Зарплата за месяц, переписываеться в производных классах
		{
			return -1;
		}

		public string ToFile() // Для сравнение записи в файле
		{
			return $"{Surname};{Name};{Patronymic};{Post};{Salary};{Time};{Salary_per_hour}";
		}

		public string ToListBox() // Для списка
		{
			return $"{Surname} {Name} {Patronymic}";
		}
	}
}