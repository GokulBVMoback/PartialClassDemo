using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal partial class ParEmp
    {
        // Here the class file name is ParEmpTwo.cs
        // But the class name is ParEmp and we also marked this class as partial by using the partial keyword.
        // Even though the ParEmp class definition is split into multiple class files, after compilation,
        //they will be grouped together and will become a single class only.


        public void DisplayFullName()
        {
            Console.WriteLine($"Full Name is : {FirstName} {LastName}");
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEmployee Details : ");
            Console.WriteLine($"Employee ID : {EmpId}");
            Console.WriteLine($"First Name : {FirstName}");
            Console.WriteLine($"Last Name : {LastName}");
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
