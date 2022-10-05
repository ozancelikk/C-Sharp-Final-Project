﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //Dont Repeat Yourself iki kere succes yazmak yerine üstteki çalışırsa alttaki de çalışsın dedik.
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)
        {
            
            Success = success;
        }   

        public bool Success { get; }

        public string Message { get; }
    }
}
