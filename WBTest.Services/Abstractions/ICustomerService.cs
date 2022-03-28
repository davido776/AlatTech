using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBTest.Services.Entities;

namespace WBTest.Services.Abstractions
{
    public interface ICustomerService
    {
        Result<List<CustomerDto>> GetAllCustomers();
        Task<Result<string>> OnBoard(CreateCustomerDto createCustomerDto);

        Task<Result<string>> CompleteOnBoarding(string otp, string customerId);
    }
}
