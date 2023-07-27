using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Developer : Employee
    {
        string project;
        string domain;
        public Developer()
        {
            Console.WriteLine("Developer Constructor");
            project = "Not Assign";
            domain = "Not Given";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine($"Domain : {domain}\nProject : {project}");
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter Domain");
            domain = Console.ReadLine();
            Console.WriteLine("Enter Projects");
            project = Console.ReadLine();
        }
    }
}
