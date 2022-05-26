using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpProject
{
    internal class Employee
    {
        public int empID;
        public String EmpName;
        public String EmpSalary;
        public static String CompName;

        public static void GetEmployeeDetail(Employee e)
        {

            Console.WriteLine(e.empID);
                Console.WriteLine(e.EmpName);
            Console.WriteLine(e.EmpSalary);
            Console.WriteLine(Employee.CompName);
            Console.WriteLine("*********************************");
        }
    }
}
