using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    class Employee
    {
        public string name;
        public string address;
        public string jobTitle;
        public int employeeNumber;
        public double salary;

        //contruction
        public Employee()
        {
            name = "Employee";
            address = "123 Main Street";
            jobTitle = "Worker";
            employeeNumber = 00000;
            salary = 0.00;
        }

        public Employee(string nameP, string addressP, string jobTitleP, int employeeNumberP, double salaryP)
        {
            name = nameP;
            address = addressP;
            jobTitle = jobTitleP;
            employeeNumber = employeeNumberP;
            salary = salaryP;

        }

        public void ChangeName()
        {
            Console.WriteLine("Changing {0}'s name...", name);
            
            Console.WriteLine("What is this employee's new name?");
            string nameChange = Console.ReadLine();

            name = nameChange;
            Console.WriteLine("");

        }

        public void ChangeSalary()
        {
            Console.WriteLine("Changing {0}'s salary...", name);

            Console.WriteLine("What is the employee's new salary?");
            string salaryString = Console.ReadLine();
            double salaryChange = double.Parse(salaryString);

            salary = salaryChange;
            Console.WriteLine("");
        }

        //print
        public void Print()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Job Title: {0}", jobTitle);
            Console.WriteLine("Employee Number: {0}", employeeNumber);
            Console.WriteLine("Yearly salary: {0}", salary);
            Console.WriteLine("");

        }



    }

    
}
