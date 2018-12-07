﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class ClaveInvalidaException : Exception
    {
        public ClaveInvalidaException(string mensaje) : base(mensaje)
        { }
        public ClaveInvalidaException(string mensaje, Exception innerException) : base(mensaje, innerException)
        { }
    }
}
