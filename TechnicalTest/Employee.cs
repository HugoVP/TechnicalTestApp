using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Employee: Person
    {
        public float Salary { get; set; }
        public string Schedule { get; set; }
        public string Job { get; set; }
        public string Activity { get; set; }
        public Company Company { get; set; }

        public Employee(string FirstName, string LastName, float Weight, float Height, GenderType Gender, DateTime Birthdate, float Salary, string Schedule, string Job, Company Company)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Weight = Weight;
            this.Height = Height;
            this.Gender = Gender;
            this.Birthdate = Birthdate;
            this.Salary = Salary;
            this.Schedule = Schedule;
            this.Job = Job;
            this.Company = Company;
            this.Company.AddEmployee(this);
        }

        public Employee(Person person, float Salary, string Schedule, string Job, Company Company): this(person.FirstName, person.LastName, person.Weight, person.Height, person.Gender, person.Birthdate, Salary, Schedule, Job, Company)
        {

            //Company.AddEmployee(this);
        }

        public void AssignActivity(string activity)
        {
            Console.WriteLine("Assigning activity");
            Activity = activity;
        }

        public void ReportActivity()
        {

            if (Activity == null)
            {
                Activity = "idle";
            }
            Console.WriteLine(FirstName + " is " + Activity);
        }

        override public string ToString()
        {
            return $"{base.ToString()},\n" +
                   $"Salary:    {Salary.ToString("0.00")},\n" +
                   $"Schedule:  {Schedule},\n" +
                   $"Job:       {Job},\n" +
                   $"Activity:  {Activity},\n" +
                   $"Company:   ({Company})";
        }
    }
}
