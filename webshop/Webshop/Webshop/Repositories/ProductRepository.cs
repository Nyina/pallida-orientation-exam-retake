using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webshop.Entities;
using Webshop.Models;

namespace Webshop.Repositories
{
    public class ProductRepository
    {
        private ProductContext productContext;

        public ProductRepository(ProductContext productContext)
        {
            this.productContext = productContext;
        }

        public List<Product> ListAll()
        {
            return productContext.Products.ToList();
        }
    }
}
