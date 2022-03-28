using AutoMapper;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBTest.Data;
using WBTest.Models;
using WBTest.Services.Abstractions;
using WBTest.Services.Entities;

namespace WBTest.Services.Implementations
{
    public class CustomerService : ICustomerService
    {
        private readonly UserManager<Customer> userManager;
        private readonly IMapper mapper;
        private readonly DBContext context;
        public CustomerService(UserManager<Customer> userManager,IMapper mapper,DBContext context)
        {
            this.userManager = userManager;
            this.mapper = mapper;
            this.context = context;
        }


        public Result<List<CustomerDto>> GetAllCustomers()
        {
            var customers =  context.Customers.Where(c => c.Onboarded == true).ToList();

            var customerDtos = mapper.Map<List<CustomerDto>>(customers);

            return Result<List<CustomerDto>>.Success(customerDtos);
        }
        public async Task<Result<string>> OnBoard(CreateCustomerDto createCustomerDto)
        {
            var customer = mapper.Map<Customer>(createCustomerDto);

            //var otp = GenerateOtp();

            customer.Otp = GenerateOtp();

            customer.OtpDate = DateTime.Now.ToString();

            //send Otp to email

            IdentityResult result = await userManager.CreateAsync(customer, createCustomerDto.Password);

            //send Otp

            if (!result.Succeeded) return Result<string>.Failure("Problem creating customer");

            return Result<string>.Success("Verify Otp sent to your PhoneNumber to complete onboarding");

            //throw new NotImplementedException();
        }

        public async Task<Result<string>> CompleteOnBoarding(string otp,string customerId)
        {
            var customer = await userManager.FindByIdAsync(customerId);

            if (otp != customer.Otp) return Result<string>.Failure("Incorrect code");

            var dateDifference = Convert.ToDateTime(customer.OtpDate) - DateTime.Now;

            if (dateDifference.Minutes > 15) return Result<string>.Failure("Code has expired");

            customer.Onboarded = true;

            await userManager.UpdateAsync(customer);

            return Result<string>.Success("Customer OnBoarding Complete...");
        }

        
        private string GenerateOtp()
        {
            char[] charArr = "0123456789".ToCharArray();
            string strrandom = string.Empty;
            Random objran = new Random();
            for (int i = 0; i < 6; i++)
            {
                //It will not allow Repetation of Characters
                int pos = objran.Next(1, charArr.Length);
                if (!strrandom.Contains(charArr.GetValue(pos).ToString())) strrandom += charArr.GetValue(pos);
                else i--;
            }
            return strrandom;
        }
    }
}
