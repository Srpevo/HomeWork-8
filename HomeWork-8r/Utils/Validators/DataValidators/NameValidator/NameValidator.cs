using HomeWork_8.Exceptions.IncorrectNameEntryException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Utils.Validators.DataValidators.UserNameValidator
{
    internal static class NameValidator
    {
        public static bool CheckUserName(string name)
        {
            if (name.Length == 0)
                throw new IncorrectNameEntryException("name cannot be empty");

            else if (name.Length < 3)
                throw new IncorrectNameEntryException("the name cannot be short");

            else return true;
        }
    }
}
