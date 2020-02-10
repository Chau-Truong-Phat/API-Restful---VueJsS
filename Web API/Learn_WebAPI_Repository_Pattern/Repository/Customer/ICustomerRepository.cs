using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomerById(int id);
        IEnumerable<Customer> GetListCustomerByName(string name);
        Customer GetCustomerByNumberPhone(string numberPhone);
        int GetCustomerIdByNumberPhone(string numberPhone);
        string GetCustomerNameByNumberPhone(string numberPhone);
        Result AddOrUpdateCustomer(AddOrUpdateCustomerDto _customerDto);
    }
}
