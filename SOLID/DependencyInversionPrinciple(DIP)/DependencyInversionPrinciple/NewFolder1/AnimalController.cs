using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.NewFolder1
{
    internal class AnimalController
    {
        private IAnimal _Ianimal;
        public AnimalController(IAnimal Ianimal)
        {
            _Ianimal = Ianimal;
        }
        public void DisplayEat()
        {
            Console.WriteLine(_Ianimal.Eat());
        }
        public void DisplaySound()
        {
            Console.WriteLine(_Ianimal.Sound());
        }
    }
}
