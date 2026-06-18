using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending fake sms message ");

        }
     
    }
}
