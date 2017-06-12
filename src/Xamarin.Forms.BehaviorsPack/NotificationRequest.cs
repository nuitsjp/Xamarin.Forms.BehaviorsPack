using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class NotificationRequest : INotificationRequest
    {
        public event EventHandler<EventArgs> Requested;

        public void Request(object sender)
        {
            Requested?.Invoke(sender, EventArgs.Empty);
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
