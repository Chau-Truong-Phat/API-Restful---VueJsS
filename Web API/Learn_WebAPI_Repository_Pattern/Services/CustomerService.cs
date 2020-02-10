using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService()
        {
            _customerRepository = new CustomerRepository();
        }

        public Result AddOrUpdateCustomer(AddOrUpdateCustomerDto _customerDto)
        {
            return _customerRepository.AddOrUpdateCustomer(_customerDto);
        }
        public Customer GetCustomerById(int _customerId)
        {
            return _customerRepository.GetCustomerById(_customerId);
        }
        public Customer GetCustomerByNumberPhone(string _numberPhone)
        {
            return _customerRepository.GetCustomerByNumberPhone(_numberPhone);
        }
        public int GetCustomerIdByNumberPhone(string _numberPhone)
        {
            return _customerRepository.GetCustomerIdByNumberPhone(_numberPhone);
        }
        public string GetCustomerNameByNumberPhone(string _numberPhone)
        {
            return _customerRepository.GetCustomerNameByNumberPhone(_numberPhone);
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return _customerRepository.GetCustomers();
        }
        public IEnumerable<Customer> GetListCustomerByName(string _name)
        {
            return _customerRepository.GetListCustomerByName(_name);
        }
    }
}
