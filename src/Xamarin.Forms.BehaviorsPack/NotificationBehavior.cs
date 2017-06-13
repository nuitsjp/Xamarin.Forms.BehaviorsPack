using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Xamarin.Forms.BehaviorsPack
{
	public class NotificationBehavior : ReceiveNotificationBehavior<BindableObject, EventArgs>
	{
		public event EventHandler<EventArgs> Received;
		protected override void OnReceived(object sender, EventArgs eventArgs)
		{
			Received?.Invoke(sender, eventArgs);
		}
	}
}
