namespace DependencyInversionPrinciple.NewFolder
{
    internal class Manpower : Ipower
    {
        public void Gardener()
        {
            Console.WriteLine("Gardener are 50 ");
        }

        public void Sweeper()
        {
            Console.WriteLine("Sweeper are 50");
        }

        public void Watchman()
        {
            Console.WriteLine("Watchman are 50");
        }
    }
}
