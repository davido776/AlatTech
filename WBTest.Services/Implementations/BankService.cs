using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WBTest.Services.Abstractions;
using WBTest.Services.Entities;

namespace WBTest.Services.Implementations
{
    public class BankService : IBankService
    {
        private readonly HttpClient httpClient;

        private readonly IConfiguration config;

        public BankService(HttpClient httpClient,IConfiguration config)
        {
            this.httpClient = httpClient;
            this.config = config;
        }

        public async Task<GetAllBankDto> GetBanks()
        {
            HttpResponseMessage httpresponse = await httpClient.GetAsync($"{config["BanksApi"]}/Shared/GetAllBanks");

            
            string jsonString = await httpresponse.Content.ReadAsStringAsync();
            GetAllBankDto getAllBankDto = JsonSerializer.Deserialize<GetAllBankDto>(jsonString);
            return getAllBankDto;
            
        }
    }
}
