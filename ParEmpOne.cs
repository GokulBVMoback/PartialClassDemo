using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal partial class ParEmp
    {
        // Here the class file name is ParEmpOne.cs
        // But the class name is ParEmp and the class is marked with the partial keyword which makes it a partial class.
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Salary { get; set; }
    }
}
