using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public abstract class ReceiveNotificationBehavior<T> : InheritBindingBehavior<T> where T : BindableObject
    {
        public static readonly BindableProperty EventNameProperty =
            BindableProperty.Create(nameof(EventName), typeof(string), typeof(ReceiveNotificationBehavior<T>), propertyChanged:OnEventNameChanged);

	    public static readonly BindableProperty InteractionRequestProperty =
            BindableProperty.Create(nameof(NotificationRequest), typeof(INotificationRequest), typeof(ReceiveNotificationBehavior<T>), propertyChanged:OnInterractionRequestChanged);

	    private EventInfo _eventInfo;
	    private Delegate _eventHandler;

		public string EventName
        {
            get => (string)GetValue(EventNameProperty);
            set => SetValue(EventNameProperty, value);
        }
        public INotificationRequest NotificationRequest
        {
            get => (INotificationRequest)GetValue(InteractionRequestProperty);
            set => SetValue(InteractionRequestProperty, value);
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

	    protected abstract void OnReceived(object sender, EventArgs eventArgs);

		private static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
	    {
		    var behavior = (ReceiveNotificationBehavior<T>)bindable;
			behavior.StopListeningEvent();
			behavior.StartListeningEvent();
	    }

	    private static void OnInterractionRequestChanged(BindableObject bindable, object oldValue, object newValue)
	    {
		    var behavior = (ReceiveNotificationBehavior<T>)bindable;
			behavior.StopListeningRequest(oldValue as INotificationRequest);
			behavior.StartListeningRequest(newValue as INotificationRequest);
		}

		private void StartListeningEvent()
	    {
		    if (AssociatedObject!= null && !string.IsNullOrEmpty(EventName))
		    {
			    _eventInfo = AssociatedObject.GetType().GetRuntimeEvent(EventName);
			    if (_eventInfo == null)
				    throw new NotImplementedException($"{GetType().Name}: Can't implement the '{EventName}' event.");

			    var senderParameter = Expression.Parameter(typeof(object));
			    var eventParameter = Expression.Parameter(typeof(EventArgs));
			    ParameterExpression[] eventParameters = {senderParameter, eventParameter};


			    var actionInvoke = typeof(Action<object, EventArgs>).GetRuntimeMethods().First(m => m.Name == "Invoke");

			    _eventHandler =
				    Expression.Lambda(
					    _eventInfo.EventHandlerType,
					    Expression.Call(Expression.Constant((Action<object, EventArgs>) OnReceived), actionInvoke, senderParameter,
						    eventParameter),
					    eventParameters).Compile();

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

	    private void StartListeningRequest(INotificationRequest notificationRequest)
	    {
		    if (notificationRequest != null)
		    {
			    notificationRequest.Requested += OnReceived;
		    }
	    }

	    private void StopListeningRequest(INotificationRequest notificationRequest)
	    {
		    if (notificationRequest != null)
		    {
			    notificationRequest.Requested -= OnReceived;
		    }
	    }
    }
}
