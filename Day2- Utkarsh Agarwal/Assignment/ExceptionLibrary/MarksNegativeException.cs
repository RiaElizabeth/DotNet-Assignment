﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLibrary
{
    public class MarksNegativeException : Exception
    {
        public MarksNegativeException()
        {
        }
        public MarksNegativeException(string message) : base(message)
        {
        }

    }
}
    
