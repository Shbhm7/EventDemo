public class Publisher
{
    public event NotificationEventHandler NotificationEvent;
    public void SendNotification(string message)
    {
        Console.WriteLine($"Sending notification: {message}");
        if (NotificationEvent != null)
        {
            NotificationEvent(this, new NotificationEventArgs(message));
        }
    }
}