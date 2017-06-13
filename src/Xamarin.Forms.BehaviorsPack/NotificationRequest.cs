using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class NotificationRequest : INotificationRequest<EventArgs>
    {
        public event EventHandler<EventArgs> Requested;

        public void Request()
        {
	        Request(EventArgs.Empty);
        }

	    public void Request(EventArgs eventArgs)
	    {
		    Requested?.Invoke(this, eventArgs);
	    }
	}

	public class NotificationRequest<TEventArgs> : INotificationRequest<TEventArgs> where TEventArgs : EventArgs
	{
		public event EventHandler<TEventArgs> Requested;

		public void Request(TEventArgs eventArgs)
		{
			Requested?.Invoke(this, eventArgs);
		}
	}
}
