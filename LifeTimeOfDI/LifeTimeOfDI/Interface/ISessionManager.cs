namespace LifeTimeOfDI.Interface
{
    public interface ISessionManager
    {
        public Guid StartSession();
        public List<string> GetList();
    }
}
