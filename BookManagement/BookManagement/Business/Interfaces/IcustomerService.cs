using BookManagement.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagement.Business.Interfaces
{
    public interface IcustomerService
    {
        List<CustomerModel> GetAllCustomer();
        void AddCustomer(CustomerModel customer);
    }
}
