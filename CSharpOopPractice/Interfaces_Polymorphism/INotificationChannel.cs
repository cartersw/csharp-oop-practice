using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpIntermediate
{
    public interface INotificationChannel
    {
        void Send(Message message);
    }
}
