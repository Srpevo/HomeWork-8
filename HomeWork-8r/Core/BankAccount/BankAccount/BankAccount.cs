
using HomeWork_8.Core.BankAccount.Base;
using HomeWork_8.Utils.Validators.DataValidators.EmailValidator;
using HomeWork_8.Utils.Validators.DataValidators.UserNameValidator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Core.BankAccount.BankAccount
{
    internal class BankAccount : BankAccountBase
    {
        public event Action<string> DataChanged;
        //Name

        public string Name
        {
            get => _name!;

            set
            {
                if (NameValidator.CheckUserName(value))
                {
                    _name = value;
                    DataChanged?.Invoke(value);
                }
            }
        }

        //Email

        public string Email
        {
            get => _email!;

            set
            {
                if (EmailValidator.CheckUserEmail(value))
                {
                    _email = value;
                    DataChanged?.Invoke(value);
                }
            }
        }

        //Id

         public string Id
         {
             get => _id!;
        
             set
             {
                 if (IdValidator.CheckUserId(value))
                 {
                     _id = value;
                     DataChanged?.Invoke(value);
                 }
             }
         }

         public decimal Cash
         {
             get => _cash!;
        
             set
             {
                 if (CashValidator.CheckCash(value))
                 {
                     _cash = value;
                     DataChanged?.Invoke(value.ToString());
                 }
             }
         }
    }
}
