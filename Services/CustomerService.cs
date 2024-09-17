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
                context.SaveChanges();
            }
        }

        public Customer GetCustomerByName(string name) 
        {
            using(var context = _dbContextFactroy.CreateDbContext())
            {
                var customer = context.Customers.SingleOrDefault(x => x.Name == name);
                return customer;
            }
        }

//สอนเอาไว้//
        public void UpdateCustomerByName(string name, int age)
        {
            var customer = GetCustomerByName(name);
            if(customer == null)
            {
                throw new Exception("Customer doess not exist. Cannot update");
            }
            customer.Age = age;
            using(var context = _dbContextFactroy.CreateDbContext())
            {
                context.Update(customer);
                 context.SaveChanges();
            }
        }

    }

}