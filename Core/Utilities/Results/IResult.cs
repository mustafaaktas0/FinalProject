using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //Temel voidler için
  public  interface IResult
    {
        bool Success { get; } // sadece okumak için 
        string Message { get; }

    }
}
