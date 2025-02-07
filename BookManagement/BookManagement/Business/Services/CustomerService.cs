using BookManagement.Business.Interfaces;
using BookManagement.Data.Models;
using BookManagement.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Business.Services
{
    public class CustomerService : IcustomerService
    {
        private readonly IcustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public void AddCustomer(CustomerModel customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        public List<CustomerModel> GetAllCustomer()
        {
            var customers = _customerRepository.GetAllCustomers();
            return customers;
        }
    }
}
