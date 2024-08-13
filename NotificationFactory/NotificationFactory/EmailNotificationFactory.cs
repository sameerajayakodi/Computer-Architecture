using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFactory
{
    public class EmailNotificationFactory:NotificationFactory
    {
        public override Notification CreateNotification()
        {
            return new EmailNotification();
        }
    }
}
