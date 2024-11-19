using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8r.Utils.Validators.DataValidators.IdValidator
{
    internal static class IdValidator
    {
        public static bool CheckUserId(string id)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentNullException("id cannot be empty");
            return true;
        }
    }
}
