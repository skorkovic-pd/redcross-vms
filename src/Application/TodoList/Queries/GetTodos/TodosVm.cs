using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TodoList.Queries.GetTodos;

public class TodosVm
{
    public IList<TodoListDto> Lists { get; set; } = new List<TodoListDto>();
}

