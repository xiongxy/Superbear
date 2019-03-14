using System;
using System.Collections.Generic;
using System.Text;

namespace Superbear.Common.Contract
{
    public class ResponseResult
    {
        public ResponseResult()
        {
            State = true;
            Message = "success";
        }
        public ResponseResult ResponseError(string message)
        {
            return new ResponseResult()
            {
                Message = message,
                State = false
            };
        }
        public string Message { get; set; }
        public bool State { get; set; }
    }
    public class ResponseResult<T> : ResponseResult
    {
        public ResponseResult(T result)
        {
            Result = result;
            State = true;
            Message = "success";
        }
        public T Result { get; set; }
    }
}
