namespace DependencyInversionPrinciple.NewFolder
{
    public class T_hub
    {
        private Ipower _power;
        public T_hub(Ipower power)
        {
            _power = power;
        }
        public void PerformGardening()
        {
            _power.Gardener();
        }
            
        public void PerformSweeping()
        {
            _power.Sweeper();
        }

        public void PerformWatchkeeping()
        {
            _power.Watchman();
        }
    }
}
