using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Utils.Result
{
    public class Result<T> : IResult<T>
    {
        public bool Successed { get; set; }
        public T Value { get; set; }
        public string Message { get; set; } = "There is no error";
        public Exception Exception { get; set; }
        public Result()
        {
            Successed = false;
        }
        public Result(T value)
        {
            Successed = true;
            Value = value;
        }
        public Result(bool successed, T value, string message, Exception exception)
        {
            Successed = successed;
            Value = value;
            Message = message;
            Exception = exception;
        }

        public Result(bool successed, string message)
        {
            Successed = successed;
            Value = default(T);
            Message = message;
            Exception = new Exception(message);
        }
        public Result(Exception exception)
        {
            Exception = exception;
            Successed = false;
            Message = exception.Message;
        }
    }
}
