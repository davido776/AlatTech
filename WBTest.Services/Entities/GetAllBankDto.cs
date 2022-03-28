using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WBTest.Services.Entities
{
    public class  GetAllBankDto
    {
        [JsonPropertyName("result")]
        public List<BankDto> Result { get; set; }


        [JsonPropertyName("errorMessage")]
        public string ErrorMessage { get; set; }

        [JsonPropertyName("errorMessages")]
        public List<string> ErrorMessages { get; set; }

        [JsonPropertyName("hasError")]
        public bool HasError { get; set; }

        [JsonPropertyName("timeGenerated")]
        public string TimeGenerated { get; set; }
    }
}
