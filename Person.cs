using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpart2
{
	internal class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public string EmployeeId { get; set; }
		public decimal Salary { get; set; }
		public DateTime StartDate { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Adress { get; set; }


		public Person(string name) { }

		public Person(string name, int age, string employeeId, decimal salary, DateTime startDate, string phoneNumber, string email, string  adress)
		{
			Name = name;
			Age = age; ;
			EmployeeId = employeeId;
			Salary = salary;
			StartDate = startDate;
			PhoneNumber = phoneNumber;
			Email = email;
			Adress = adress;
		}

		public void PrintInfo()
		{
			Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
		}

		public void Introduce()
		{
			Console.WriteLine($"Hej, jag heter {Name} och är {Age} år gammal.");
		}
		
		public virtual void DoWork()
		{
			
		}

		public void UpdateSalary(decimal newSalary)
		{
			Salary = newSalary; 
		}

		public void CalculateYearsOfService()
		{
			Console.WriteLine($"{Name} has been working since {StartDate}.");
		}

		public void ChangeEmployeeId(string newId)
		{

			EmployeeId = newId; 

        }

		public void UpdateContactInfo(string phone, string email, string adress)
		{
			PhoneNumber = phone;
			Email = email;
			Adress = adress;
			
		}


    }
}
