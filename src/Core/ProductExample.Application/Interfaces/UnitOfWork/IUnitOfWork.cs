using Microsoft.EntityFrameworkCore.Storage;
using ProductExample.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Application.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync();
        IProductRepository ProductRepository { get; }
        IOrderRepository OrderRepository { get; }
    }
}
