using BlazorServerDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerDemo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set;}
        public DbSet<Order> Orders { get; set;}
    }
}