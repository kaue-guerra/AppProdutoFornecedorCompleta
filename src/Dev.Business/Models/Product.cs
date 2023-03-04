using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev.Business.Models
{
    public class Product : Entity
    {
        public Guid SupplierId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public DateTime Created_At { get; set; }
        public bool Active { get; set; }

        /* EF Relations */

        public Supplier Supplier { get; set; }

    }
}
