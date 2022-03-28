using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBTest.Services.Entities
{
    public class CreateCustomerDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string PhoneNumber { get; set; }
        
        public string StateOfResidence { get; set; }

        public string Lga { get; set; }
    }
}
