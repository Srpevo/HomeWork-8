using HomeWork_8.Interfaces.IMessageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Core.Services.MailService
{
    internal class MailService : IMessageService
    {
        public void SendMessage(string message)
        {
            Console.WriteLine("sent by mail: " + message);
        }
    }
}
