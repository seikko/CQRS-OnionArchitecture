using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductExample.Application.Dtos.ProductDTO;
using ProductExample.Application.Features.Commands.CreateProduct;
using ProductExample.Application.Features.Queries.GetAllProduct;
using ProductExample.Application.Features.Queries.GetByIdProduct;
using ProductExample.Application.Features.Queries.GetWhereProduct;
using ProductExample.Application.Interfaces.Repositories;
using ProductExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductExample.WebAPI.Controllers
{
    /// <summary>
    /// Product controller açıklaması
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //IProductRepository _productRepository;
        //public ProductsController(IProductRepository productRepository)
        //{
        //    _productRepository = productRepository;
        //}
        //GetAllProductQueryHandler _getAllProductQueryHandler;
        //GetByIdProductQueryHandler _getByIdProductQueryHandler;
        //GetWhereProductQueryHandler _getWhereProductQueryHandler;
        //CreateProductCommandHandler _createProductCommandHandler;

        //public ProductsController(
        //       GetAllProductQueryHandler getAllProductQueryHandler,
        //      GetByIdProductQueryHandler getByIdProductQueryHandler,
        //      GetWhereProductQueryHandler getWhereProductQueryHandler,
        //      CreateProductCommandHandler createProductCommandHandler)
        //{
        //    _getAllProductQueryHandler = getAllProductQueryHandler;
        //    _getByIdProductQueryHandler = getByIdProductQueryHandler;
        //    _getWhereProductQueryHandler = getWhereProductQueryHandler;
        //    _createProductCommandHandler = createProductCommandHandler;
        //}

        IMediator _mediator;
        public ProductsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllProductQueryResponse>> Get()
        {
            //return (await _productRepository.GetAsync()).Select(p => new ProductViewDTO
            //{
            //    Name = p.Name,
            //    Stock = p.Stock,
            //    Price = p.Price,
            //    Quantity = p.Quantity
            //}).ToList();

            //List<GetAllProductQueryResponse> products = await _getAllProductQueryHandler.GetAllProduct(new GetAllProductQueryRequest());
            //return products;

            return await _mediator.Send(new GetAllProductQueryRequest());
        }

        [HttpGet("{Id}")]
        //public async Task<GetByIdProductQueryResponse> Get(string Id)
        public async Task<GetByIdProductQueryResponse> Get([FromQuery] GetByIdProductQueryRequest request)
        {
            //return await _getByIdProductQueryHandler.GetByIdProduct(new GetByIdProductQueryRequest
            //{
            //    Id = new Guid(id)
            //});
            //return await _getByIdProductQueryHandler.GetByIdProduct(request);
            return await _mediator.Send(request);
        }

        [HttpGet("search/{Name}")]
        public async Task<List<GetWhereProductQueryResponse>> Get([FromQuery] GetWhereProductQueryRequest request)
        {
            //return await _getWhereProductQueryHandler.GetWhereProduct(request);
            return await _mediator.Send(request);
        }

        /// <summary>
        /// Ürün ekler
        /// </summary>
        /// <param name="model">Ürün...</param>
        /// <returns>Geri dönüş değer..</returns>
        [HttpPost]
        public async Task<CreateProductCommandResponse> Post([FromBody] CreateProductCommandRequest request)
        {
            //await _productRepository.AddAsync(new Product
            //{
            //    Name = model.Name,
            //    Price = model.Price,
            //    Quantity = model.Quantity,
            //    Stock = model.Stock
            //});
            //return await _createProductCommandHandler.CreateProduct(request);
            return await _mediator.Send(request);
        }
    }
}
