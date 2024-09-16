using BlazorServerDemo.Data;
using BlazorServerDemo.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerDemo.Services
{
    public class CustomerService
    {
        private IDbContextFactory<DemoDbContext> _dbContextFactroy;

        public CustomerService(IDbContextFactory<DemoDbContext> dbContextFactroy)
        {
            _dbContextFactroy = dbContextFactroy;
        }

        public void AddCustomer(Customer customer)
        {
            using(var context = _dbContextFactroy.CreateDbContext())
            {
                context.Customers.Add(customer);
            }
        }

    }

}