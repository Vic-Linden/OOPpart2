using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpart2
{
    internal class Housekeeper : Employee
    {
        public CleaningSpeed CleaningSpeed { get; set; }
        public List<string> SpecialtyAreas { get; set; }
        public Dictionary<string, int> SuppliesInventory { get; set; } 
      

        public Housekeeper(string name, int age, string employeeId, decimal salary, 
            DateTime startDate, string phoneNumber, string email, string adress, 
            string jobtitle, string department, ShiftPreference shiftPreference, int vacationDays,
            decimal performanceRating, CleaningSpeed cleaningSpeed, List<string> specialAreas, Dictionary<string, int> suppliesInventory)
            : base(name, age, employeeId, salary, startDate, phoneNumber, email, adress, jobtitle, department, shiftPreference, vacationDays, performanceRating)
        {
            SpecialtyAreas = specialAreas;
            SuppliesInventory = suppliesInventory;
            CleaningSpeed = cleaningSpeed;  
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name} städar hotelrummet.");
        }

        public void AddSpecialtyArea(string area)
        {
            SpecialtyAreas.Add(area);
        }

        public void UpdateSuppliesInventory(string item, int quantity)
        {
            SuppliesInventory.Add(item, quantity);
        }
      
    }
}
