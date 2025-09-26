using LifeTimeOfDI.Interface;

namespace LifeTimeOfDI.Implementation
{
    public class SessionManager : ISessionManager
    {
   
        public Guid StartSession()
        {
            Guid sessionID = Guid.NewGuid();
            return sessionID;
        }
        public List<string> GetList()
        {
           List<string> list = new List<string>();
            list.Add("Ram");
            list.Add("Lakshman");
            list.Add("Hanuman");
            return list;
           
        }
    }
}
