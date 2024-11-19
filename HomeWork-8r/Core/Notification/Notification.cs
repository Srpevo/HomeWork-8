using HomeWork_8.Interfaces.IMessageService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_8.Core.Notification
{
    internal class Notification
    {
        private IMessageService _service;

        public Notification(IMessageService service)
        {
            _service = service;
        }

        public void Send(string message)
        {
            _service.SendMessage(message);
        }
    }
}
