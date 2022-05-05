using FluentValidation.Results;
using MediatR;
using ProductExample.Application.Interfaces.Repositories;
using ProductExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductExample.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
    {
        readonly IProductRepository _productRepository;
        public CreateProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
        {
            Product product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                Quantity = request.Quantity,
                Stock = request.Stock
            };

            Product p = await _productRepository.AddAsync(product);

            return new CreateProductCommandResponse
            {
                Succeed = p == null ? false : true,
                Message = "Başarıyla eklenmiştir."
            };
        }
    }
}
