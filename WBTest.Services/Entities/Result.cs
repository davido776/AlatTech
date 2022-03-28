using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBTest.Services.Entities
{
    public class Result<T>
    {
        public bool Succeeded { get; set; }
        public T Value { get; set; }
        public string Error { get; set; }

        public static Result<T> Success(T value) => new Result<T> { Succeeded = true, Value = value };

        public static Result<T> Failure(string error) => new Result<T> { Succeeded = false, Error = error };
    }
}
