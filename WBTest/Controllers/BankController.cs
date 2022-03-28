using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WBTest.Services.Abstractions;
using WBTest.Services.Implementations;

namespace WBTest.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class BankController : ControllerBase
    {
        private readonly IBankService bankService;
        public BankController(IBankService bankService)
        {
            this.bankService = bankService;
        }

        [HttpGet]
        [Route("get_all_banks")]
        public async Task<IActionResult> GetAllBanks()
        {
            var result = await bankService.GetBanks();

            if (result.HasError)
            {
                return BadRequest(result);
            }

            return Ok(result);
        }
    }
}
