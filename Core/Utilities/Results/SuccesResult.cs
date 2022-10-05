using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccesResult:Result
    {
        public SuccesResult(string message) : base(true,message)//base üstteki resulta gönder demek
        {

        }
        public SuccesResult():base(true)
        {

        }
    }
}
