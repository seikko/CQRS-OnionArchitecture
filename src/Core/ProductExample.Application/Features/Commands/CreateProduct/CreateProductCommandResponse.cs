using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Application.Features.Commands.CreateProduct
{
    public class CreateProductCommandResponse
    {
        public bool Succeed { get; set; }
        public string Message { get; set; }
    }
}
