using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Entities db;
        public CustomerRepository()
        {
            db = new Entities();
            db.Configuration.ProxyCreationEnabled = false;
        }
        public Result AddOrUpdateCustomer(AddOrUpdateCustomerDto _customerDto)
        {
            var entityTemp = db.Customers.FirstOrDefault(x => x.Email.Equals(_customerDto.Email));
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AddOrUpdateCustomerDto, Customer>();
            });

            IMapper mapper = config.CreateMapper();
            var cus = mapper.Map<AddOrUpdateCustomerDto, Customer>(_customerDto);

            if (entityTemp == null)
            {
                db.Customers.Add(cus);
            }
            else
            {
                entityTemp.Name = _customerDto.Name;
                entityTemp.NumberPhone = _customerDto.NumberPhone;
                entityTemp.IdentifyNumber = _customerDto.IdentifyNumber;
                entityTemp.BirthDate = _customerDto.BirthDate;
                entityTemp.Email = _customerDto.Email;
            }

            try
            {
                db.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                return new Result
                {
                    ResultMessage = e
                        .EntityValidationErrors
                        .LastOrDefault()
                        .ValidationErrors
                        .LastOrDefault()
                        .ErrorMessage,
                    IsSuccess = false
                };
            }
            return new Result
            {
                ResultMessage = "Thao Tác thành công",
                IsSuccess = true
            };
        }
        public Customer GetCustomerById(int _customerId)
        {
            return db.Customers
                .FirstOrDefault(x => x.Id.Equals(_customerId));
        }
        public Customer GetCustomerByNumberPhone(string numberPhone)
        {
            return db.Customers
                .FirstOrDefault(x => x.NumberPhone.Equals(numberPhone));
        }
        public int GetCustomerIdByNumberPhone(string numberPhone)
        {
            return db.Customers
                .FirstOrDefault(x => x.NumberPhone.Equals(numberPhone))
                .Id;
        }
        public string GetCustomerNameByNumberPhone(string numberPhone)
        {
            return db.Customers
                .FirstOrDefault(x => x.NumberPhone.Equals(numberPhone))
                .Name;
        }
        public IEnumerable<Customer> GetCustomers()
        {
            return db.Customers;
        }
        public IEnumerable<Customer> GetListCustomerByName(string name)
        {
            return db.Customers
                .Where(x => x.Name.ToLower().Contains(name.ToLower()));
        }
    }
}
