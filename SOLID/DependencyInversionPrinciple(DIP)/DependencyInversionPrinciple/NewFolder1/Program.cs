using DependencyInversionPrinciple.NewFolder;
using System.Net.NetworkInformation;

namespace DependencyInversionPrinciple
{
    //High-level modules should not depend on low-level modules. Both should depend on abstraction
    internal class Program
    {
        static void Main(string[] args)
        {
            //Using Manpower
            Ipower manpower = new Manpower();
            T_hub tHubManpower = new T_hub(manpower);

            tHubManpower.PerformGardening();
            tHubManpower.PerformSweeping();
            tHubManpower.PerformWatchkeeping();
            Console.WriteLine("------------------------------------------------");
            //Using Xpower

            Ipower xpower = new Xpower();
            T_hub tHubXpower = new T_hub(xpower);

            tHubXpower.PerformGardening();
            tHubXpower.PerformSweeping();
            tHubXpower.PerformWatchkeeping();
           
            Console.ReadLine();


        }
    }
}

//Disadvantage:It can complecate the code and design due to abstraction and Increases Complexity