﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application app = new Application();
            //app.Register();
            app.Display();
            Developer dev = new Developer();
            dev.Display();
        }
    }
}
