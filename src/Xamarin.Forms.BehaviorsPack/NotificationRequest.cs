using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class NotificationRequest : INotificationRequest<EventArgs>
    {
        public event EventHandler<EventArgs> Requested;

        public void Request(object sender)
        {
	        Request(sender, EventArgs.Empty);
        }

	    public void Request(object sender, EventArgs eventArgs)
	    {
		    Requested?.Invoke(sender, eventArgs);
	    }
	}

	public class NotificationRequest<TEventArgs> : INotificationRequest<TEventArgs> where TEventArgs : EventArgs
	{
		public event EventHandler<TEventArgs> Requested;

		public void Request(object sender, TEventArgs eventArgs)
		{
			Requested?.Invoke(sender, eventArgs);
		}
	}
}
