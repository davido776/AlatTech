using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBTest.Services.Abstractions;
using WBTest.Services.Entities;

namespace WBTest.Controllers
{

    [ApiController]
    [Route("api/[Controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }


        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerDto model)
        {
            if (model == null) return BadRequest("Invalid Credentials");

            return Ok(await customerService.OnBoard(model));
        }

        [HttpPut]
        public async Task<IActionResult> CompleteOnBoarding(CompleteOnboardingDto model)
        {
            if (model == null) return BadRequest("Invalid Credentials");

            return Ok(await customerService.CompleteOnBoarding(model));
        }
    }
}
