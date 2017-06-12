using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public interface INotificationRequest<TEventArgs> where TEventArgs : EventArgs
    {
        event EventHandler<TEventArgs> Requested;
    }

    public interface INotificationRequest : INotificationRequest<EventArgs>
    {
        
    }
}
