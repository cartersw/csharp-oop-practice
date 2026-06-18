using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    internal class MailNotificationChannel : INotificationChannel 
    {
        public void Send(Message message)
        {
            Console.WriteLine("Send fake mail");

        }
    }
}
