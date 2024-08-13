using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationFactory
{
    public abstract class NotificationFactory
    {
        public abstract Notification CreateNotification();
    }
}
