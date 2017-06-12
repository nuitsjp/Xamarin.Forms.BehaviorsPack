using System;

namespace XamarinForms.Behaviors
{
    public interface INotificationRequest<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Requested;
    }

    public interface INotificationRequest : INotificationRequest<EventArgs>
    {
        
    }
}
