﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        //voidler için
        bool Success { get; }
        string Message { get; }
    }
}
