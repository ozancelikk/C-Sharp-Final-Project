using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDto
    {
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
