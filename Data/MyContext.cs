using FirstWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstWebApp.Data
{
    public class MyContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

    }
}
