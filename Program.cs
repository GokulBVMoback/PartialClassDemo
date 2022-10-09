using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Here, you can see that we are creating an instance of the ParEmp class,
            //setting the 4 property values, and then invoking the two public methods.
            ParEmp emp = new ParEmp()
            {
                EmpId = 1,
                FirstName = "Gokul",
                LastName = "B V",
                Salary = 15000,
            };
            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}
