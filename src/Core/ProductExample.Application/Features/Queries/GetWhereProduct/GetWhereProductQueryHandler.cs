using AutoMapper;
using MediatR;
using ProductExample.Application.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductExample.Application.Features.Queries.GetWhereProduct
{
    public class GetWhereProductQueryHandler : IRequestHandler<GetWhereProductQueryRequest, List<GetWhereProductQueryResponse>>
    {
        readonly IProductRepository _productRepository;
        readonly IMapper _mapper;
        public GetWhereProductQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        //public async Task<List<GetWhereProductQueryResponse>> GetWhereProduct(GetWhereProductQueryRequest request)
        //{
        //    var products = await _productRepository.GetWhereAsync(p => p.Name.Contains(request.Name));
        //    return products.Select(p => new GetWhereProductQueryResponse
        //    {
        //        Id = p.Id,
        //        Name = p.Name,
        //        Quantity = p.Quantity
        //    }).ToList();
        //}
        public async Task<List<GetWhereProductQueryResponse>> Handle(GetWhereProductQueryRequest request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetWhereAsync(p => p.Name.Contains(request.Name));
            return _mapper.Map<List<GetWhereProductQueryResponse>>(products);
            //return products.Select(p => new GetWhereProductQueryResponse
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Quantity = p.Quantity
            //}).ToList();
        }
    }
}
