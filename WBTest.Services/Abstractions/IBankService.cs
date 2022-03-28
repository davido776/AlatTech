using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WBTest.Services.Entities;

namespace WBTest.Services.Abstractions
{
    public interface IBankService
    {
        Task<GetAllBankDto> GetBanks();
    }
}
