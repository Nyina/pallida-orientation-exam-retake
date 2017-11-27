using Microsoft.EntityFrameworkCore;
using Webshop.Models;

namespace Webshop.Entities
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
