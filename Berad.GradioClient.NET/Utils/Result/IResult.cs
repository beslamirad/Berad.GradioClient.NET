using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berad.GradioClient.NET.Utils.Result
{
    public interface IResult<T>
    {
        bool Successed { get; }
        T Value { get; set; }
        string Message { get; set; }
        Exception Exception { get; set; }

    }
}
