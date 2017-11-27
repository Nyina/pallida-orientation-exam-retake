using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Entities;

namespace Webshop.Repositories
{
    public class ProductRepository
    {
        private ProductContext productContext;

        public ProductRepository(ProductContext productContext)
        {
            this.productContext = productContext;
        }
    }
}
