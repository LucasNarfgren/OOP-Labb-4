using System;
using System.Collections.Generic;

namespace Labb_4_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee E1 = new Employee() { ID = 101, Name = "Lucas", Gender = "Male", Salary = 35000 };
            Employee E2 = new Employee() { ID = 102, Name = "Johnny", Gender = "Male", Salary = 25000 };
            Employee E3 = new Employee() { ID = 103, Name = "Felicia", Gender = "FeMale", Salary = 45000 };
            Employee E4 = new Employee() { ID = 104, Name = "Liam", Gender = "Male", Salary = 20000 };
            Employee E5 = new Employee() { ID = 105, Name = "Samantha", Gender = "FeMale", Salary = 65000 };

            Stack<Employee> Employees = new Stack<Employee>();

            Employees.Push(E1);
            Employees.Push(E2);
            Employees.Push(E3);
            Employees.Push(E4);
            Employees.Push(E5);
            Console.WriteLine("---------------STACK-----------------");
            foreach (Employee item in Employees)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}",item.ID,item.Name,item.Gender,item.Salary);
                Console.WriteLine("Items left in the Stack = {0}",Employees.Count);
                
            }

            Console.WriteLine("-------------------------------------");

            Employee P1 = Employees.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3}",P1.ID,P1.Name,P1.Gender,P1.Salary);
            Console.WriteLine("Items left in the Stack = {0}",Employees.Count);
            Employee P2 = Employees.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3}", P2.ID, P2.Name, P2.Gender, P2.Salary);
            Console.WriteLine("Items left in the Stack = {0}", Employees.Count);
            Employee P3 = Employees.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3}", P3.ID, P3.Name, P3.Gender, P3.Salary);
            Console.WriteLine("Items left in the Stack = {0}", Employees.Count);
            Employee P4 = Employees.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3}", P4.ID, P4.Name, P4.Gender, P4.Salary);
            Console.WriteLine("Items left in the Stack = {0}", Employees.Count);
            Employee P5 = Employees.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3}", P5.ID, P5.Name, P5.Gender, P5.Salary);
            Console.WriteLine("Items left in the Stack = {0}", Employees.Count);

            Console.WriteLine("-------------------------------------");
            Employees.Push(E1);
            Employees.Push(E2);
            Employees.Push(E3);
            Employees.Push(E4);
            Employees.Push(E5);

            Employee S1 = Employees.Peek();
            Console.WriteLine("{0} - {1} - {2} - {3}", S1.ID, S1.Name, S1.Gender, S1.Salary);
            Console.WriteLine("Items left in the Stack = {0}", Employees.Count);
            Employee S2 = Employees.Peek();
            Console.WriteLine("{0} - {1} - {2} - {3}", S2.ID, S2.Name, S2.Gender, S2.Salary);
            Console.WriteLine("Items left in the Stack = {0}", Employees.Count);

            Console.WriteLine("-------------------------------------");

            if (Employees.Contains(E3))
            {
                Console.WriteLine("Emp3 is in the stack.");
            }
            else
            {
                Console.WriteLine("Item does not exist.");
            }

            Console.WriteLine("-----------------LIST----------------");

            List<Employee> EmpList = new List<Employee>();

            EmpList.Add(E1);
            EmpList.Add(E2);
            EmpList.Add(E3);
            EmpList.Add(E4);
            EmpList.Add(E5);

            if (EmpList.Contains(E2))
            {
                Console.WriteLine("Employee2 Object exists in the list.");
            }
            else
            {
                Console.WriteLine("Employee2 object does not exist in the list.");
            }
            Console.WriteLine("-------------------------------------");

            Employee FF = EmpList.Find(f => f.Gender == "Male");
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}",FF.ID,FF.Name,FF.Gender,FF.Salary);

            Console.WriteLine("-------------------------------------");

            List<Employee> FA = EmpList.FindAll(f => f.Gender == "Male");
            foreach (Employee item in FA)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", item.ID, item.Name, item.Gender, item.Salary);
            }

            Console.ReadKey();
        }
    }
}
