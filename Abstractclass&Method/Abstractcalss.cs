using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractclass_Method
{

    class Program
    { 
         static void Main()
        {
            Employee e = new Employee(333,"Abhishek",50000);
            e.showEmployeeDetails();
            Console.ReadLine();
        }
    }
    class Employee
    {
        public int EmpID;
        public string EmpName;

        public double Grosspay;
        double Taxdeduction = 0.1;
        double netSalary;


        public Employee(int Eid, string EName, double Egrosspay) 
        { 

            this.EmpID = Eid;
            this.EmpName = EName;
            this.Grosspay = Egrosspay;
        }

        void CalculateSalary()
        {
            if (Grosspay >= 30000)
            {
                netSalary = Grosspay - (Taxdeduction * Grosspay);
                Console.WriteLine("your salary is: {0}",netSalary);
            }
            else
            {
                Console.WriteLine("Your salary is: {0}",Grosspay);
            }
        }
        public void showEmployeeDetails()
        {
            this.CalculateSalary();
        }

    }
}