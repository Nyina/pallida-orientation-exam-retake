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

        public Product Selected(string itemName, string size, int amount)
        {
            Product product = productContext.Products.Where(x => x.ItemName == itemName && x.Size == size).FirstOrDefault();
            product.Price *= amount;
            product.Size = amount.ToString();
            return product;
        }

        public List<Product> SelectWithCondition(int price, string status)
        {
            if (status == "lower")
            {
                return productContext.Products.Where(x => x.Price < price).ToList();
            }
            if (status == "higher")
            {
                return productContext.Products.Where(x => x.Price > price).ToList();
            }
            return productContext.Products.Where(x => x.Price == price).ToList();
        }
    }
}
