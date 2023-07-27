using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Application : Developer
    {
        string osType;
        public Application()
        {
            Console.WriteLine("Application Constructor");
            osType = "Unknown";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("OS Type : "+osType);
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("Enter OS Type : ");
            osType = Console.ReadLine();
        }
    }
}
