using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AddOrUpdateCustomerDto
    {
        public string Name { get; set; }
        public string NumberPhone { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
        public string IdentifyNumber { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
