using HomeWork_8.Exceptions.IncorrectEmailEntryException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeWork_8.Utils.Validators.DataValidators.EmailValidator
{
    internal static class EmailValidator
    {
        public static bool CheckUserEmail(string email)
        {
            int at_counter = email.Count(x => x == '@');
            int dot_counter = email.Count(x => x == '.');

            if (string.IsNullOrWhiteSpace(email)) 
                throw new IncorrectEmailEntryException("email cannot be empty");

            var Regx = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"); //using regular expression for more realism ;)
            
            if (!Regx.IsMatch(email))
            {
                string[] WordsToRemove = { "mail", "com", "gmail", "@", "." };
                string CorrectEmail = email;
                
                foreach (string word in WordsToRemove)
                {
                    CorrectEmail = CorrectEmail.Replace(word, "");
                }
                throw new IncorrectEmailEntryException($"incorrect email, correct > {CorrectEmail}@gmail.com");
            }
              

            return true;
        }
    }
}
