using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Domain.Common
{
    abstract public class BaseEntity
    {
        public Guid Id { get; set; }
    }
}
