using PEARApi.Models;
using PEARApi.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PEARApi.Services
{
    public class CustomerService
    {
        private PearDbContext _pearDbContext;

        public CustomerService(PearDbContext pearDbContext)
        {
            _pearDbContext = pearDbContext;
        }

        public async Task<Customer> GetCustomerByID(int customerID)
        {
            var customer = await _pearDbContext.Customer.FindAsync(customerID);
            return customer;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
           _pearDbContext.Add(customer);
            var result = await _pearDbContext.SaveChangesAsync();

            return customer;
        }
    }
}
