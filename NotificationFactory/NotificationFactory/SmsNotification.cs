using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFactory
{
    public class SmsNotification:Notification
    {
        public void NotifyUser()
        {
            Console.WriteLine("SMS Notification...");
        }
    }
}
