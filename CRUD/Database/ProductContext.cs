using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Database
{
    public class ProductContext:DbContext
    {
        public ProductContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ProductModel> Product { get; set; } // products table

}

   
}
