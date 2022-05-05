using ProductExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Application.Interfaces.Repositories
{
    public interface IProductRepository : IRepository<Product>
    {
    }
}
