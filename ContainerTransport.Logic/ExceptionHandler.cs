using System;
using System.Collections.Generic;
using System.Text;

namespace ContainerTransport.Logic
{
    public class ExceptionHandler : Exception
    {
        public ExceptionHandler(string message)
            : base(message) { }

        public ExceptionHandler(string format, params object[] args)
            : base(string.Format(format, args)) { }
    }
}
