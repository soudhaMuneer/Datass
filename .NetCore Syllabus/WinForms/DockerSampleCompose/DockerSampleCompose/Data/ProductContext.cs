using DockerSampleCompose.Model;
using Microsoft.EntityFrameworkCore;

namespace DockerSampleCompose.Data
{
    public class ProductContext :DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
    }
}
