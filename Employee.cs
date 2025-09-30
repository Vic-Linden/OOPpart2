using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpart2
{
    internal class Employee : Person
    {
        public string JobTitle { get; set; }
        public string Department { get; set; }
        public ShiftPreference ShiftPreference { get; set; }
        public int VacationDays { get; set; }
        public decimal PerformanceRating { get; set; }


        public Employee(string name, string jobTitle):base(name)
        {
            Name= name;
            JobTitle= jobTitle;     
        }

        public Employee(string name, int age, string employeeId, decimal salary, DateTime startDate, string phoneNumber, string email, string adress, 
            string jobtitle, string department, ShiftPreference shiftPreference, int vacationDays, decimal performanceRating)
            : base(name, age, employeeId, salary, startDate, phoneNumber, email, adress)
        {
            JobTitle = jobtitle;
            Department = department;
            ShiftPreference = shiftPreference;
            VacationDays = vacationDays;
            PerformanceRating = performanceRating;
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} som {JobTitle} på {Department}");
         
        }

        public void RequestVacation(int days)
        {
            VacationDays -= days;
        }

        public void ChangeShift(ShiftPreference newShift)
        {
            ShiftPreference = newShift;
        }

       
    }
}
