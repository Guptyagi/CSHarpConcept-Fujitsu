using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpProject
{
    internal class DemoVariable
    {

        static void Main(String[] args)
        {
            Employee.CompName = "Fujitsu";
            Employee emp1 = new Employee();

            Employee emp2 = new Employee();

            Employee emp3 = new Employee();

            emp1.empID = 101;
            emp1.EmpName = "Pooja Tyagi";
            emp1.EmpSalary = "6000";

            emp2.empID = 102;
            emp2.EmpName = "Neru Jindal";
            emp2.EmpSalary = "8000";

            emp3.empID = 103;
            emp3.EmpName = "Priya Gupta";
            emp3.EmpSalary = "7000";

            Employee.GetEmployeeDetail(emp1);
            Employee.GetEmployeeDetail(emp2);
            Employee.GetEmployeeDetail(emp3);



            /*
                        Console.WriteLine(emp1.empID);
                        Console.WriteLine(emp1.EmpName);
                        Console.WriteLine(emp1.EmpSalary);
                        Console.WriteLine(Employee.CompName);

                        Console.WriteLine(emp2.empID);
                        Console.WriteLine(emp2.EmpName);
                        Console.WriteLine(emp2.EmpSalary);
                        Console.WriteLine(Employee.CompName);*/




        }
    }
}
