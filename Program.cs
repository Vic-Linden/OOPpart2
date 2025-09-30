namespace OOPpart2
{
	internal class Program
	{
		static void Main(string[] args)
		{


			List<string> specialtyAreas = new List<string> { "Dammsuga, moppa och sopa golv",
	"Damma och rengöra ytor, möbler, hyllor och lampor",
	"Putsa fönster, speglar och glasytor",
	"Rengöra kök (diskbänk, spis, ugn, kylskåp, mikrovågsugn m.m.)",
	"Städning av badrum (toaletter, handfat, duschar, badkar)",
	"Borttagning av sopor och återvinning",
	"Rengöra mattor och textilier",
	"Tvätta, torka, stryka och vika kläder",
	"Sköta sängkläder, handdukar och gardiner",
	"Bädda sängar, byta lakan och täcken",
	"Hålla ordning i skåp, garderober och förvaringsutrymmen",
	"Lägga varor på plats efter inköp",
	"Se till att rengöringsmaterial och hushållsartiklar alltid finns på lager",
	"Disk och diskmaskin (fylla/tömma)",
	"Rengöra köksredskap och maskiner",
	"Matlagning eller enklare matförberedelser (vid behov)",
	"Rapportera skador, brister eller behov av reparationer",
	"Vattna blommor och ta hand om växter",
	"Sköta enklare trädgårdsarbete",
	"Ta emot leveranser eller hantverkare",
	"Hjälpa till vid evenemang i hemmet eller på arbetsplatsen",
	"Assistera med inköp eller ärenden",
	"Välkomna gäster och hålla ordning i gemensamma utrymmen"};

			Dictionary<string, int> supliesInventory = new Dictionary<string, int> { { "Dammsugarpåsar", 10 },
			{ "Rengöringsmedel", 5 },
			{ "Trasor", 20 },
			{ "Moppar", 3 },
			{ "Skräppåsar", 50 },
			{ "Handskar", 10 }};

			
			List<Person> hotelStaff = new List<Person>();

			Manager maria = new Manager("Maria Svensson", 45, "M002", 55000m, new DateTime(2018, 5, 1), "0731142323", "maria.svensson@oophotel.se", "Victoriavägen 75", "Operations", 3, 0.35m, ManagementLevel.Senior) ;
			Person johan = new Employee("Johan Andersson", 28, "E002", 32000m, new DateTime(2021, 9, 15), "070111222333", "johan.andersson@oophotel.se", "Hotellvägen 14", "Receptionist", "Front Desk", ShiftPreference.Morgon, 25, 7m);
			Person sara = new Consultant("Sara Lindberg", 38, "C002", 0m, new DateTime(2023, 3, 1), "070133222233", "sara.lindberg@oophotel.se", "Slavaroad 69", 1000m, "Hotell Konsulterna AB", "Project managment", new TimeSpan(1, 0, 0), "Projekt namn", 8) ;
			Person kalle = new Employee("Kalle Persson", 33, "E003", 35000m, new DateTime(2020, 11, 1), "0252933213", "kalle.persson@oophotelet.se", "Adress 44", "Kock", "Kök", ShiftPreference.Natt, 25, 8.5m);
			Person eva = new Manager("Eva Karlsson", 50, "M003", 58000m, new DateTime(2015, 2, 1), "555558545", "eva.karlsson@oophotel.se", "Hemmet 63", "Administration", 5, 0.55m, ManagementLevel.Junior);
			Person slava = new Housekeeper("Slava Karlsson", 23, "S007", 95000m, new DateTime(2010, 1, 15), "07001202303", "slava.cleaner@oophotel.se", "Slavaroad 78", "Cleaner", "Room Service", ShiftPreference.Natt, 25, 6m, CleaningSpeed.Average, specialtyAreas, supliesInventory);

			hotelStaff.Add(maria);
			hotelStaff.Add(johan);
            hotelStaff.Add(sara);
            hotelStaff.Add(kalle);
            hotelStaff.Add(eva);
            hotelStaff.Add(slava);

            /*
			Console.WriteLine("Hotellets personal: ");
			foreach (var person in hotelStaff)
			{
				person.PrintInfo();
				person.Introduce();
				person.DoWork();

				if (person is Manager manager)
				{
					manager.HoldMeeting();
				}


				else if (person is Consultant consultant)
				{
					consultant.GiveAdvice();
				}

				Console.WriteLine("");

			}


			double averageAge = hotelStaff.Average(p => p.Age);
			decimal totalSalary = hotelStaff.Sum(p => p.Salary);
			Console.WriteLine($"Genomsnittlig ålder på personalen: {averageAge:F1}");
			Console.WriteLine($"Total månadslön för anställda: {totalSalary} kr");
			Console.ReadKey();
			*/


            Department hotel = new Department("The OOP Hotel", new Employee("Victoria", "Manager"));
            Department frontDesk = new Department("Front Desk", new Employee("Theo", "Manager"));
			Department housekeeping = new Department("Housekeeping", new Employee("Slava", "Manager"));
           
            hotel.AddSubdepartment(frontDesk);
            hotel.AddSubdepartment(housekeeping);

			frontDesk.AddEmployee(new Employee("Alice", "Receptionist"));
			housekeeping.AddEmployee(new Employee("Bob", "Housekeeper"));

            hotel.PrintOrganizationChart();
			Console.ReadKey();
        }
	}
}