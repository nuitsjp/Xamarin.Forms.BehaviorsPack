using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class NotificationRequest : INotificationRequest<EventArgs>
    {
        public event EventHandler<EventArgs> Requested;

        public void Raise()
        {
	        Raise(EventArgs.Empty);
        }

	    public void Raise(EventArgs eventArgs)
	    {
		    Requested?.Invoke(this, eventArgs);
	    }
	}

	public class NotificationRequest<TEventArgs> : INotificationRequest<TEventArgs> where TEventArgs : EventArgs
	{
		public event EventHandler<TEventArgs> Requested;

		public void Raise(TEventArgs eventArgs)
		{
			Requested?.Invoke(this, eventArgs);
		}
	}
}
