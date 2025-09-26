using LifeTimeOfDI.Interface;
using Microsoft.AspNetCore.Mvc;

namespace LifeTimeOfDI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LifeTimeController:ControllerBase
    {
        ISessionManager _sessionManager1;
        ISessionManager _sessionManager2;
        public LifeTimeController(ISessionManager sessionManager1,ISessionManager sessionManager2)
        {
            _sessionManager1 = sessionManager1;
            _sessionManager2 = sessionManager2;
        }

        [HttpGet]
        public IActionResult Get()
        {
        
          Guid session1 = _sessionManager1.StartSession();

            Guid session2 = _sessionManager2.StartSession();

            List<string> list = _sessionManager1.GetList();
            return Ok(list);
          

        }
    }
}

