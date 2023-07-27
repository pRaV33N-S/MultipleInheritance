using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Employee
    {
        int id;
        string name;
        public Employee()
        {
            Console.WriteLine("Employee Class Constructor");
            id = -1;
            name = "not given";
        }
        public virtual void Display()
        {
            Console.WriteLine($"ID : {id}\nName : {name}");
        }
        public virtual void Register()
        {
            Console.WriteLine("Enter Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
        }
    }
}
