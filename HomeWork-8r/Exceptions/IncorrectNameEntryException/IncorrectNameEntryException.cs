using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Exceptions.IncorrectNameEntryException
{
    internal class IncorrectNameEntryException : Exception
    {
       public IncorrectNameEntryException(string message) : base(message) { }

       public IncorrectNameEntryException() { }
    }
}
