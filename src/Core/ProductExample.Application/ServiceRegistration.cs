using MediatR;
using Microsoft.Extensions.DependencyInjection;
using ProductExample.Application.Features.Commands.CreateProduct;
using ProductExample.Application.Features.Queries.GetAllProduct;
using ProductExample.Application.Features.Queries.GetByIdProduct;
using ProductExample.Application.Features.Queries.GetWhereProduct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace ProductExample.Application
{
    static public class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddMediatR(Assembly.GetExecutingAssembly());
            serviceCollection.AddAutoMapper(Assembly.GetExecutingAssembly());
        }
    }
}
