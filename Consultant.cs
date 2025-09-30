using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPpart2
{
    internal class Consultant : Person
    {
        public decimal HourlyRate { get; set; }
        public string ConsultingFirm { get; set; }
        public string Expertise { get; set; }

        public TimeSpan ContractDuration { get; set; }

        public string ProjectName { get; set; }

        public int BillableHours { get; set; }

        public Consultant(string name, int age, string employeeId, decimal salary, DateTime startDate, string phoneNumber, string email,
            string adress,decimal hourlyRate, string consultingFirm, string expertise, TimeSpan contractDuration, string projectName, int billableHours)
            : base(name, age, employeeId, salary, startDate, phoneNumber, email, adress)
        {
            HourlyRate = hourlyRate;
            ConsultingFirm = consultingFirm;
            Expertise = expertise;
            ContractDuration = contractDuration;
            BillableHours = billableHours;
        }

        public void GiveAdvice()
        {
            Console.WriteLine($"{Name} hjälper hotellet att förbättra sina rutiner. Konsultens expertområde är {Expertise}.");
        }


		public override void DoWork()
		{
			Console.WriteLine($"{Name} konsulterar hotellet och hjälper de anställda med planeringen.");

		}

        public void ExtendContract(TimeSpan extension)
        {
            ContractDuration += extension;
        }

        public void LogBillableHours(int hours)
        {
            BillableHours += hours;
        }

    }
}
