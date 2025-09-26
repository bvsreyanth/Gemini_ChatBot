using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregationPrinciple
{
    internal class Develop:IDeveloperTasks
    {
        public void WriteCode()
        {
            Console.WriteLine("Writing code");
        }

        public void DebugCode()
        {
            Console.WriteLine("Debuging Code");
        }
    }
}
