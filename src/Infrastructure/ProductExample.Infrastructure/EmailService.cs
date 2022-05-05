using ProductExample.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductExample.Infrastructure
{
    public class EmailService : IEmailService
    {
        public void SendMessage()
        {
            Console.WriteLine("Mail gönderilmiştir.");
        }
    }
}
