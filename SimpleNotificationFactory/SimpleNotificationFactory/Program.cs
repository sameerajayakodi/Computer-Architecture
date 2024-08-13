namespace SimpleNotificationFactory;

class Program
{
    public static void Main(string[] args)
    {
        NotificationFactory factory = new NotificationFactory();
        factory.CreateNotification("email").NotifyUser();

        factory.CreateNotification("sms").NotifyUser();
        
    }
}