using DemoSignalR.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoSignalR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private DataContext _dc;

        public ChatController(DataContext dc)
        {
            _dc = dc;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_dc.Messages);
        }
    }
}
