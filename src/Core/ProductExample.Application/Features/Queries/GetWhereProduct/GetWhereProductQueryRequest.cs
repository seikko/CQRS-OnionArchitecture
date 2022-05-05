using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Application.Features.Queries.GetWhereProduct
{
    public class GetWhereProductQueryRequest : IRequest<List<GetWhereProductQueryResponse>>
    {
        public string Name { get; set; }
    }
}
