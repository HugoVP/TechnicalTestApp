using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest
{
    public class Company
    {
        public string Name;
        public string BusinessSector;
        public string Address;
        public LinkedList<Person> Owners = new LinkedList<Person>();
        public LinkedList<Employee> Employees = new LinkedList<Employee>();

        public Company(string Name, string BusinessSector, string Address, LinkedList<Person> Owners)
        {
            this.Name = Name;
            this.BusinessSector = BusinessSector;
            this.Address = Address;
            this.Owners = Owners;
        }

        public void AddEmployee(Employee employee)
        {
            Employees.AddLast(employee);
        }

        public void RemoveEmployee(Employee employee)
        {
            Employees.Remove(employee);
        }

        public void ShowEmployees()
        {
            Console.WriteLine("Employees: ");

            foreach(Employee employee in Employees)
            {
                Console.WriteLine($"{employee.ToString()}");
            }            
        }

        public override string ToString()
        {
            return $"Name: {Name}, BusinessSector: {BusinessSector}, Address: {Address}";
        }
    }
}
