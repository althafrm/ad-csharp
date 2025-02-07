using BookManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Data.Repository
{
    public interface IcustomerRepository
    {
        List<CustomerModel> GetAllCustomers();
        void AddCustomer(CustomerModel customer);
    }
}
