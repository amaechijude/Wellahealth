using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoApiController : ControllerBase
    {
        public List<TodoModels> todos = new();
        public List<TodoRecord> tdr = new();
        [HttpGet (Name = "GetTodos")]
        public List<TodoModels> GetTodos()
        {
            return todos;
        }

        [HttpPost (Name = "TodoPost")]
        public void TodoPost(TodoRecord newTodo)
        {
            TodoModels newTodoAdd = new(newTodo.Id, newTodo.Title,
            newTodo.StartedOn, newTodo.IsCompleted);
            todos.Add(newTodoAdd);
            return ;
        }
    }
}
public record TodoRecord(int Id, string Title, DateOnly StartedOn, bool IsCompleted);
