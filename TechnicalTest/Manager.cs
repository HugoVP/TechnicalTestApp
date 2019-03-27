using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Extensions;

namespace TechnicalTest
{
    public class Manager: Employee
    {
        public Person Candidate;
        public Manager(string FirstName, string LastName, float Weight, float Height, GenderType Gender, DateTime Birthdate, float Salary, string Schedule, string Job, Company Company) : base(FirstName, LastName, Weight, Height, Gender, Birthdate, Salary, Schedule, Job, Company)
        {
        }

        public Employee HireCandidate(Person person, float Salary, string Schedule, string Job)
        {
            return new Employee(person, Salary, Schedule, Job, Company);
        }
    }
}
