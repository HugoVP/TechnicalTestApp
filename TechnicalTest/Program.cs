using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manager's first name ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Lastname");
            var lastName = Console.ReadLine();
            Person ceo = new Person()
            {
                FirstName = "Cesar",
                LastName = "Pérez",
                Gender = Person.GenderType.Male,
                Height = 170.0f,
                Weight = 80.0f,
                Birthdate = DateTime.Parse("01-01-1970"),
            };

            Person[] owners = { ceo };

            //Console.WriteLine(ceo.ToString());            

            Company company1 = new Company(
                "IT Services INC",
                "IT",
                "Mexico",
                new LinkedList<Person>(owners)
            );

            Console.WriteLine("The company is called: " + company1.Name);


            Console.WriteLine("The company has this owners: " + company1.Owners.Last.Value.LastName);

            Manager person2 = new Manager(
                firstName,
                lastName,
                85.5f,
                180.0f,
                Person.GenderType.Male,
                DateTime.Parse("10-10-1990"),
                10000.0f,
                "10:00-18:00",
                "Advertising Manager",
                company1
            );


            var elegantCoat = new TopGarment()
            {
                Color = "Black",
                GenderWear = Wear.GenderWearType.Men,
                Material = "Wool",
                NumberOfButtons = 4,
                NumberOfPockets = 1,
                Type = TopGarment.TopGarmentType.Coat,
                Trademark = "GUCCI",
                Size = TopGarment.SizeType.Medium,
            };

            var elegantPants = new BottomGarment()
            {
                Color = "Black",
                GenderWear = Wear.GenderWearType.Men,
                Material = "Wool",
                Trademark = "GUCCI",
                Size = 34,
                NumberOfPockets = 4,
            };

            var brogues = new Footwear()
            {
                Color = "Black",
                GenderWear = Wear.GenderWearType.Men,
                Material = "Leather",
                Trademark = "Flexi",
                Size = 28,
            };

            var outfit = new Outfit()
            {
                Top = elegantCoat,
                Bottom = elegantPants,
                Footwear = brogues,
            };

            person2.GetDressed(outfit);

            //Console.WriteLine(person2.GetOutfit().Value);

            var managerTopWear = person2.GetOutfit().Value.Top.Type;

            int buttonsqty = person2.GetOutfit().Value.Top.NumberOfButtons;
            Console.WriteLine(person2.FirstName + " is wearing a " + managerTopWear + " that has " + buttonsqty + " buttons" );

            Console.WriteLine();
            company1.ShowEmployees();
            Console.WriteLine();

            //person2.Activity = "Interviewing";

            person2.AssignActivity("Interviewing");

            person2.ReportActivity();

            var newEmployee = person2.HireCandidate(ceo, 1000, "8:00-18:00", "Human Resources");

            newEmployee.ReportActivity();

            Console.WriteLine();
            company1.ShowEmployees(); 

            Console.ReadKey();
        }
    }
}
