namespace DependencyInversionPrinciple
{
    internal class Dog : IAnimal
    {
        public string Eat()
        {
            return "Dog is Eating";
        }

        public string Sound()
        {
            return "Dog makes huff sound";
        }
    }
}
