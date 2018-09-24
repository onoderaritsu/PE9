using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE9
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Stella", "Somewhere on the moon", "World best Archer", 666233, 999999);
            employee.Print();
            employee.ChangeName();
            employee.ChangeSalary();
            employee.Print();
        }
    }
}
