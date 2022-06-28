using Application.TodoList.Queries.GetTodos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TodoListsController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<TodosVm>> Get()
        {
            return await Mediator.Send(new GetTodosQuery());
        }
    }
}
