using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Xamarin.Forms.BehaviorsPack
{
	public class NotificationBehavior : InheritBindingBehavior<VisualElement>
	{
		public static readonly BindableProperty NotificationRequestProperty =
			BindableProperty.Create(nameof(NotificationRequest), typeof(INotificationRequest<EventArgs>), typeof(NotificationBehavior), propertyChanged: OnInterractionRequestChanged);

		public event EventHandler<EventArgs> Received;

		public INotificationRequest<EventArgs> NotificationRequest
		{
			get => (INotificationRequest<EventArgs>)GetValue(NotificationRequestProperty);
			set => SetValue(NotificationRequestProperty, value);
		}

		private static void OnInterractionRequestChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var behavior = (NotificationBehavior) bindable;
			var oldRequest = (INotificationRequest<EventArgs>) oldValue;
			if (oldRequest != null)
			{
				oldRequest.Requested -= behavior.OnReceived;
			}
			var newRequest = (INotificationRequest<EventArgs>) newValue;
			if (newRequest != null)
			{
				newRequest.Requested += behavior.OnReceived;
			}
		}

		protected void OnReceived(object sender, EventArgs eventArgs)
		{
			Received?.Invoke(sender, eventArgs);
		}
	}
}
