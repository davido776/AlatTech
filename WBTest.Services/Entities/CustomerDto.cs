using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBTest.Services.Entities
{
    public class CustomerDto
    {
        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string StateOfResidence { get; set; }

        public string Lga { get; set; }

        public bool OnBoarded { get; set; }
    }
}
