using Microsoft.EntityFrameworkCore;
using PartsPortal.Entites;


namespace PartsPortal.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }


        public DbSet<Client> clients { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Stock> Stocks { get; set; }

    }
}
