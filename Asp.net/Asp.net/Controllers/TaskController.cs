using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Asp.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpPost]
        public string[] Tasks() { 
          return new string[] { "Task 1", "Task 2", "Task 3" };
        }


        [HttpGet]
        public IActionResult AddTasks()
        {
            var error = false;
            if (error) {                            
                return BadRequest();
            }
            return Ok();
        }
    }
}
