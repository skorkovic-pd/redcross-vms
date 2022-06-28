using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.TodoList.Queries.GetTodos
{
    public record GetTodosQuery : IRequest<TodosVm>;

    public class GetTodosQueryHandler : IRequestHandler<GetTodosQuery, TodosVm>
    {
        private readonly IMapper _mapper;
        private TodosVm _vms;

        public GetTodosQueryHandler(IMapper mapper)
        {
            _mapper = mapper;
            _vms = new TodosVm
            {
                Lists = new List<TodoListDto>
                {
                    new TodoListDto()
                    {
                        Id = 1,
                        Title = "Hello World"
                    }
                }
            };
        }

        public async Task<TodosVm> Handle(GetTodosQuery request, CancellationToken cancellationToken)
        {
            return new TodosVm
            {
                Lists = _vms.Lists
            };
        }
    }
}
