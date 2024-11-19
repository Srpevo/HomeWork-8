using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Core.BankAccount.Base
{
    internal abstract class BankAccountBase
    {
        protected string? _name;
        protected string? _email;
        protected string? _id;
        protected decimal _cash;
    }
}
