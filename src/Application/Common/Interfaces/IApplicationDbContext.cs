using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces;

public  interface IApplicationDbContext
{
    DbSet<Domain.Entities.TodoList> TodoLists { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}

