using Microsoft.EntityFrameworkCore.Storage;
using ProductExample.Application.Interfaces.Repositories;
using ProductExample.Application.Interfaces.UnitOfWork;
using ProductExample.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ApplicationDbContext _applicationDbContext;
        public UnitOfWork(
            ApplicationDbContext applicationDbContext,
            IProductRepository productRepository,
            IOrderRepository orderRepository)
        {
            _applicationDbContext = applicationDbContext;
            ProductRepository = productRepository;
            OrderRepository = orderRepository;
        }

        public IProductRepository ProductRepository { get; }
        public IOrderRepository OrderRepository { get; }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _applicationDbContext.Database.BeginTransactionAsync();
        }
    }
}
