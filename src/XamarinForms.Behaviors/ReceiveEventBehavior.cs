using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
    public abstract class ReceiveEventBehavior<T> : InheritBindingBehavior<T> where T : BindableObject
    {
        public static readonly BindableProperty EventNameProperty =
            BindableProperty.Create(nameof(EventName), typeof(string), typeof(ReceiveEventBehavior<T>), propertyChanged:OnEventNameChanged);

	    public static readonly BindableProperty InteractionRequestProperty =
            BindableProperty.Create(nameof(InteractionRequest), typeof(IInteractionRequest), typeof(ReceiveEventBehavior<T>), propertyChanged:OnInterractionRequestChanged);

	    /// <summary>
	    /// アタッチしているオブジェクトのEventNameと一致する名称のEventInfo
	    /// </summary>
	    private EventInfo _eventInfo;
	    /// <summary>
	    /// アタッチしているオブジェクトの対象のイベントを購読するイベントハンドラ
	    /// </summary>
	    private Delegate _eventHandler;

	    /// <summary>
		/// 監視対象のイベント名
		/// </summary>
		public string EventName
        {
            get => (string)GetValue(EventNameProperty);
            set => SetValue(EventNameProperty, value);
        }
        public IInteractionRequest InteractionRequest
        {
            get => (IInteractionRequest)GetValue(InteractionRequestProperty);
            set => SetValue(InteractionRequestProperty, value);
        }

	    /// <summary>
	    /// アタッチ時に、対象のイベントの購読設定を行う
	    /// </summary>
	    /// <param name="bindable"></param>
	    protected override void OnAttachedTo(BindableObject bindable)
	    {
		    base.OnAttachedTo(bindable);
		    StartListeningEvent();
	    }

	    /// <summary>
	    /// デタッチ時に、イベントの購読を解除する
	    /// </summary>
	    /// <param name="bindable"></param>
	    protected override void OnDetachingFrom(BindableObject bindable)
	    {
		    StopListeningEvent();
		    StopListeningRequest(InteractionRequest);
		    base.OnDetachingFrom(bindable);
	    }

	    /// <summary>
	    /// イベントを購読する
	    /// </summary>
	    /// <param name="sender"></param>
	    /// <param name="eventArgs"></param>
	    protected abstract void OnEventRaised(object sender, EventArgs eventArgs);

		private static void OnEventNameChanged(BindableObject bindable, object oldValue, object newValue)
	    {
		    var behavior = (ReceiveEventBehavior<T>)bindable;
			behavior.StopListeningEvent();
			behavior.StartListeningEvent();
	    }

	    private static void OnInterractionRequestChanged(BindableObject bindable, object oldValue, object newValue)
	    {
		    var behavior = (ReceiveEventBehavior<T>)bindable;
			behavior.StopListeningRequest(oldValue as IInteractionRequest);
			behavior.StartListeningRequest(newValue as IInteractionRequest);
		}

		private void StartListeningEvent()
	    {
		    if (AssociatedObject!= null && !string.IsNullOrEmpty(EventName))
		    {
			    _eventInfo = AssociatedObject.GetType().GetRuntimeEvent(EventName);
			    if (_eventInfo == null)
				    // 指定された名称のイベントが存在しない場合、例外をスローする
				    throw new NotImplementedException($"EventToCommandBehavior: Can't implement the '{EventName}' event.");

			    var senderParameter = Expression.Parameter(typeof(object));
			    var eventParameter = Expression.Parameter(typeof(EventArgs));
			    ParameterExpression[] eventParameters = {senderParameter, eventParameter};


			    var actionInvoke = typeof(Action<object, EventArgs>).GetRuntimeMethods().First(m => m.Name == "Invoke");

			    _eventHandler =
				    Expression.Lambda(
					    _eventInfo.EventHandlerType,
					    Expression.Call(Expression.Constant((Action<object, EventArgs>) OnEventRaised), actionInvoke, senderParameter,
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

	    private void StartListeningRequest(IInteractionRequest interactionRequest)
	    {
		    if (interactionRequest != null)
		    {
			    interactionRequest.Requested += OnEventRaised;
		    }
	    }

	    private void StopListeningRequest(IInteractionRequest interactionRequest)
	    {
		    if (interactionRequest != null)
		    {
			    interactionRequest.Requested -= OnEventRaised;
		    }
	    }
    }
}
