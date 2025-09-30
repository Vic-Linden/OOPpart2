using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpart2
{
    internal class Manager : Person
    {
        public string Department{ get; set; }
        public int TeamSize {  get; set; }
        public decimal BonusPercentage {  get; set; }
        public ManagementLevel ManagementLevel { get; set; }

        public Manager(string name, int age, string employeeId, decimal salary, DateTime startDate, string phoneNumber, string email, string adress, string department, int teamSize, decimal bonusPercentage, ManagementLevel managementLevel) :
            base(name, age, employeeId, salary, startDate, phoneNumber, email, adress)
        {
            Department = department;
            TeamSize = teamSize; 
            BonusPercentage = bonusPercentage;
            ManagementLevel = managementLevel;
        }

        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} håller ett personalmöte på hotellet.");
        }

        public void PlanBudget()
        {
            Console.WriteLine($"{Name} planerar hotellets budget.");
        }

        public override void DoWork()
        {
            Console.WriteLine($"{Name}  som har {ManagementLevel} hanterar personal.");
        }


        public void AssignTeam(int size)
        {
            TeamSize= size;
        }

        public decimal CalculateBonus()
        {
            return BonusPercentage/100m;

        }

    }
}
    