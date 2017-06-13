using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Xamarin.Forms.BehaviorsPack
{
	public abstract class ReceiveNotificationBehavior<TBindableObject, TEventArgs>
		: InheritBindingBehavior<TBindableObject>
		where TBindableObject : BindableObject
		where TEventArgs : EventArgs
	{
	    private static readonly MethodInfo HandlerMethodInfo = typeof(ReceiveNotificationBehavior<TBindableObject, TEventArgs>).GetRuntimeMethods().Single(mi => mi.Name == "OnReceived" && mi.IsPublic == false);

        public static readonly BindableProperty EventNameProperty =
			BindableProperty.Create(nameof(EventName), typeof(string), typeof(ReceiveNotificationBehavior<TBindableObject, TEventArgs>), propertyChanged: OnEventNameChanged);

		public static readonly BindableProperty NotificationRequestProperty =
			BindableProperty.Create(nameof(NotificationRequest), typeof(INotificationRequest<TEventArgs>), typeof(ReceiveNotificationBehavior<TBindableObject, TEventArgs>), propertyChanged: OnInterractionRequestChanged);

		private EventInfo _eventInfo;
		private Delegate _eventHandler;

		public string EventName
		{
			get => (string)GetValue(EventNameProperty);
			set => SetValue(EventNameProperty, value);
		}

		public INotificationRequest<TEventArgs> NotificationRequest
		{
			get => (INotificationRequest<TEventArgs>)GetValue(NotificationRequestProperty);
			set => SetValue(NotificationRequestProperty, value);
		}

		protected override void OnAttachedTo(BindableObject bindable)
		{
			base.OnAttachedTo(bindable);
			StartListeningEvent();
		}

		protected override void OnDetachingFrom(BindableObject bindable)
		{
			StopListeningEvent();
			StopListeningRequest(NotificationRequest);
			base.OnDetachingFrom(bindable);
		}

		protected abstract void OnReceived(object sender, TEventArgs eventArgs);

		private static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var behavior = (ReceiveNotificationBehavior<TBindableObject, TEventArgs>)bindable;
			behavior.StopListeningEvent();
			behavior.StartListeningEvent();
		}

		private static void OnInterractionRequestChanged(BindableObject bindable, object oldValue, object newValue)
		{
			var behavior = (ReceiveNotificationBehavior<TBindableObject, TEventArgs>)bindable;
			behavior.StopListeningRequest(oldValue as INotificationRequest<TEventArgs>);
			behavior.StartListeningRequest(newValue as INotificationRequest<TEventArgs>);
		}

		private void StartListeningEvent()
		{
			if (AssociatedObject != null && !string.IsNullOrEmpty(EventName))
			{
				_eventInfo = AssociatedObject.GetType().GetRuntimeEvent(EventName);
				if (_eventInfo == null)
					throw new NotImplementedException($"{GetType().Name}: Can't implement the '{EventName}' event.");

			    _eventHandler = HandlerMethodInfo.CreateDelegate(_eventInfo.EventHandlerType, this);
				_eventInfo.AddEventHandler(AssociatedObject, _eventHandler);
			}
		}

		private void StopListeningEvent()
		{
			if (_eventHandler != null)
				_eventInfo.RemoveEventHandler(AssociatedObject, _eventHandler);

			_eventInfo = null;
			_eventHandler = null;
		}

		private void StartListeningRequest(INotificationRequest<TEventArgs> notificationRequest)
		{
			if (notificationRequest != null)
			{
				notificationRequest.Requested += OnReceived;
			}
		}

		private void StopListeningRequest(INotificationRequest<TEventArgs> notificationRequest)
		{
			if (notificationRequest != null)
			{
				notificationRequest.Requested -= OnReceived;
			}
		}
	}
}
