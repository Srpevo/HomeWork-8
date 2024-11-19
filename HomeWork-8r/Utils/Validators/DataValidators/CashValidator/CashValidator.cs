using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8r.Utils.Validators.DataValidators.CashValidator
{
    internal static class CashValidator
    {
        public static bool CheckCash(decimal cash)
        {
            if (cash < 0) throw new ArgumentException("money can't be negative");
            return true;
        }
    }
}
