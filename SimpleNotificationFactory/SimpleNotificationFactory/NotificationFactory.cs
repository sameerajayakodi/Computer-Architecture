using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNotificationFactory
{
     class NotificationFactory
    {
        public Notification CreateNotification( string type)
        {
            if (type == null)
            {
                return null;
            }else if(type == "email")
            {
                return new EmailNotification();
            }else if (type == "sms")
            {
                return new SmsNotification();
            }

            return null;
        }
    }
}
