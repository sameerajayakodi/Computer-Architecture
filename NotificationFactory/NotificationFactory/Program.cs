namespace NotificationFactory;

class Program
{
    public static void Main(string[] args)
    {
        NotificationFactory notificationFactory = new EmailNotificationFactory();
        notificationFactory.CreateNotification().NotifyUser();

        NotificationFactory notificationFactory1 = new SmsNotificationFactory();
        notificationFactory1.CreateNotification().NotifyUser();
    }
}
