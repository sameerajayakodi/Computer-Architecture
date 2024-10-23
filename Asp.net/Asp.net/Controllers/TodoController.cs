using Asp.net.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Asp.net.Models;

namespace Asp.net.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        
        private TodoServicers _todoServicers; 

        public TodoController()
        {
            _todoServicers = new TodoServicers();
        }

        [HttpGet]
        public IActionResult GetAllTodos()
        {
            return Ok(_todoServicers.AllTodos());
        }

        [HttpPost]
        public IActionResult AddTodo([FromBody] Todo todo)
        {
            _todoServicers.AddTodos(todo);
            return Ok(_todoServicers.AddTodos);
        }
        
    }
}
