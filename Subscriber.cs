public class Subscriber
{
    public string Name { get; }
    public Subscriber(string name)
    {
        Name = name;
    }

    public void HandleNotification(object sender, NotificationEventArgs e)
    {
        Console.WriteLine($"{Name} received notification: {e.Message}");
    }
}