using System;

namespace XamarinForms.Behaviors
{
    public class NotificationRequest : INotificationRequest
    {
        public event EventHandler<EventArgs> Requested;

        public void Request()
        {
            Request(this);
        }

        public void Request(object sender)
        {
            Requested?.Invoke(sender, EventArgs.Empty);
        }
    }
}
