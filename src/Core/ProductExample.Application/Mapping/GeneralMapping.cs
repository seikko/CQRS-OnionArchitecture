using AutoMapper;
using ProductExample.Application.Features.Queries.GetAllProduct;
using ProductExample.Application.Features.Queries.GetByIdProduct;
using ProductExample.Application.Features.Queries.GetWhereProduct;
using ProductExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Product, GetAllProductQueryResponse>()
                .ReverseMap();
            CreateMap<Product, GetByIdProductQueryResponse>()
                .ReverseMap();
            CreateMap<Product, GetWhereProductQueryResponse>()
                .ReverseMap();
        }
    }
}
