
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBTest.Models
{
    public class Customer : IdentityUser
    {
        public string StateOfResidence { get; set; }

        public string Lga { get; set; }

        public bool Onboarded { get; set; } = false;

        public string Otp { get; set; }

        public string OtpDate { get; set; }
    }
}
