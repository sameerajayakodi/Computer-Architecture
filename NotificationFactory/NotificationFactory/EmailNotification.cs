using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFactory
{
    public class EmailNotification:Notification
    {
        public void NotifyUser()
        {
            Console.WriteLine("Email Notification...");
        }
    }
}
