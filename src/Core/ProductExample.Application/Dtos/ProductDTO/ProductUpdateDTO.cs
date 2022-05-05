using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Application.Dtos.ProductDTO
{
    public class ProductUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
