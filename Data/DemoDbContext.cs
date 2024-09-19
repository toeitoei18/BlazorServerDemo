using BlazorServerDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerDemo.Data
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options) 
        {
            //การกำหนดค่าฐานข้อมูลเพื่อส่งต่อข้อมูลไปDatabase
        }

        public DbSet<Customer> Customers { get; set;}
        public DbSet<Order> Orders { get; set;}
            //ประกาศคลาส2คลาสเพื่อส่งและรับค่าลงในDatabase
    }

}