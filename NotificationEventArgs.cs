public delegate void NotificationEventHandler(object sender, NotificationEventArgs e);
public class NotificationEventArgs : EventArgs
{
    public string Message { get; }
    public NotificationEventArgs(string message)
    {
        Message = message;
    }
}