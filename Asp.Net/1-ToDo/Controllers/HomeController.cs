using _1_ToDo.Data;
using _1_ToDo.Models;
using Microsoft.AspNetCore.Mvc;

namespace _1_ToDo.Controllers
{
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet("/")]
        public IActionResult Get([FromServices] AppDbContext context) 
            => Ok(context.ToDos.ToList());
        
        [HttpGet("/{id:int}")]
        public IActionResult GetById(
            [FromRoute] int id,
            [FromServices] AppDbContext context
        )
        {
            var ToDos = context.ToDos.FirstOrDefault(x => x.Id == id);
            if (ToDos == null)
                return NotFound();
            
            return Ok(ToDos);
        }

        [HttpPost("/")]
        public IActionResult Post(
            [FromBody] ToDoModel toDoModel,
            [FromServices] AppDbContext context
        )
        {
            context.ToDos.Add(toDoModel);
            context.SaveChanges();
            
            return Created($"/{toDoModel.Id}",toDoModel);
        }

        [HttpPut("/{id:int}")]
        public IActionResult Put(
            [FromRoute] int id,
            [FromBody] ToDoModel toDoModel,
            [FromServices] AppDbContext context
        )
        {
            var todo = context.ToDos.FirstOrDefault(x => x.Id == id);
            if (todo == null)
                return NotFound(toDoModel);

            todo.Title = toDoModel.Title;
            todo.Done = toDoModel.Done;

            context.ToDos.Update(todo);
            context.SaveChanges();

            return Ok(todo);
        }

        [HttpDelete("/{id:int}")]
        public IActionResult Delete(
            [FromRoute] int id,
            [FromServices] AppDbContext context
        )
        {
            var todo = context.ToDos.FirstOrDefault(x => x.Id == id);
            if (todo == null)
                return NotFound(todo);

            context.ToDos.Remove(todo);
            context.SaveChanges();

            return Ok(todo);
        }

    }
}
