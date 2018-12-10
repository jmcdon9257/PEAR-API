using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PEARApi.Models;
using PEARApi.Models.ViewModels;
using PEARApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PEARApi.Controllers
{
    [Route("api/customer")]
    public class CustomerController : Controller
    {
        // private readonly PearDbContext _pearDbContext;
        private readonly IMapper _mapper;
        private readonly CustomerService _customerService;
      
        public CustomerController(CustomerService customerService,IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}",Name ="GetCustomer")]
      public async Task<ActionResult<CustomerViewModel>> GetCustomer(int id)

        {
            var customer = await _customerService.GetCustomerByID(id);
            if(customer == null)
            {
                
                return NotFound(string.Format("No customer with ID: {0} found",id));
            }
            return _mapper.Map<CustomerViewModel>(customer);
        }

        // POST api/<controller>
      
        [HttpPost]
        public async Task<ActionResult<CustomerViewModel>> AddCustomerAsync([FromBody]CustomerViewModel customerViewModel)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var customer = new Customer
            {
                FirstName = customerViewModel.FirstName,
                LastName = customerViewModel.LastName,
                PhoneNumber = customerViewModel.PhoneNumber,
                CustomerStatus = customerViewModel.CustomerStatus,
                CreatedDate = DateTime.Now
            };
            customer = await _customerService.AddCustomerAsync(customer);
            //return CreatedAtRoute("GetCustomer", new { id = customer.CustomerID });
           return _mapper.Map<CustomerViewModel>(customer);
        }
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
