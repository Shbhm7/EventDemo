class Program
{
    static void Main()
    {
       var publisher = new Publisher();
       var subscriber1 = new Subscriber("Subscriber 1");
       var subscriber2 = new Subscriber("Subscriber 2");
       publisher.NotificationEvent += subscriber1.HandleNotification;
       publisher.NotificationEvent += subscriber2.HandleNotification;
       publisher.SendNotification("Notification 1");
       publisher.SendNotification("Notification 2");
       publisher.NotificationEvent -= subscriber1.HandleNotification;
       publisher.SendNotification("Notification 3");
    }
}