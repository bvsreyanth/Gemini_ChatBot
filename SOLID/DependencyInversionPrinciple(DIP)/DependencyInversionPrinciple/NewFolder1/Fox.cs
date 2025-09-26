using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple
{
    internal class Fox : IAnimal
    {
        public string Eat()
        {
            return "Fox is Eating";
        }

        public string Sound()
        {
            return "Fox makes howl sound";
        }
    }
}
