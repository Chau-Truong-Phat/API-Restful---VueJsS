using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int _customerId);
        IEnumerable<Customer> GetListCustomerByName(string name);
        Customer GetCustomerByNumberPhone(string numberPhone);
        int GetCustomerIdByNumberPhone(string numberPhone);
        string GetCustomerNameByNumberPhone(string numberPhone);
        Result AddOrUpdateCustomer(AddOrUpdateCustomerDto _customerDto);
    }
}
