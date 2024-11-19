using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Exceptions.IncorrectEmailEntryException
{
    internal class IncorrectEmailEntryException : Exception
    {
        public IncorrectEmailEntryException(string message) : base(message) { }

        public IncorrectEmailEntryException() { }
    }
}
