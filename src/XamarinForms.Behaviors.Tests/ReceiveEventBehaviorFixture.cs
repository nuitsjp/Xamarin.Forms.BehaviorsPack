using System;
using Xamarin.Forms;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class ReceiveEventBehaviorFixture
    {
	    [Fact]
	    public void ReceiveEvent()
	    {
		    var behavior = new BehaviorMock {EventName = "TestEventA"};
		    var page = new PageMock();
			page.Behaviors.Add(behavior);

			var eventArgs = new EventArgs();
			page.RiseTestEventA(this, eventArgs);

			Assert.NotNull(behavior.Sender);
			Assert.Equal(this, behavior.Sender);
			Assert.NotNull(behavior.EventArgs);
			Assert.Equal(eventArgs, behavior.EventArgs);

		    behavior.Sender = null;
		    behavior.EventArgs = null;

			// ChangeEvent
		    behavior.EventName = "TestEventB";

			page.RiseTestEventA(this, eventArgs);
		    Assert.Null(behavior.Sender);
		    Assert.Null(behavior.EventArgs);

		    page.RiseTestEventB(this, eventArgs);
		    Assert.NotNull(behavior.Sender);
		    Assert.Equal(this, behavior.Sender);
		    Assert.NotNull(behavior.EventArgs);
		    Assert.Equal(eventArgs, behavior.EventArgs);

		    behavior.Sender = null;
		    behavior.EventArgs = null;
			page.Behaviors.Clear();

		    page.RiseTestEventB(this, eventArgs);
			Assert.Null(behavior.Sender);
		    Assert.Null(behavior.EventArgs);
		}

	    [Fact]
	    public void ReceiveEventAfterEventChanged()
	    {
		    var behavior = new BehaviorMock { EventName = "TestEventA" };
		    var page = new PageMock();
		    page.Behaviors.Add(behavior);


		    // ChangeEvent
		    behavior.EventName = "TestEventB";

		    var eventArgs = new EventArgs();
		    page.RiseTestEventA(this, eventArgs);
		    Assert.Null(behavior.Sender);
		    Assert.Null(behavior.EventArgs);

		    page.RiseTestEventB(this, eventArgs);
		    Assert.NotNull(behavior.Sender);
		    Assert.Equal(this, behavior.Sender);
		    Assert.NotNull(behavior.EventArgs);
		    Assert.Equal(eventArgs, behavior.EventArgs);
	    }

	    [Fact]
	    public void WhenNothingEventName()
	    {
		    var behavior = new BehaviorMock { EventName = "NothingEvent" };
		    var page = new PageMock();
		    var exception = Assert.Throws<NotImplementedException>(() => page.Behaviors.Add(behavior));

			Assert.NotNull(exception);
		}

		[Fact]
	    public void ReceiveInteragtionRequest()
	    {
		    var request = new InteractionRequest();
		    var behavior = new BehaviorMock { InteractionRequest = request};
		    var page = new PageMock();
		    page.Behaviors.Add(behavior);

		    request.Request();

			Assert.NotNull(behavior.Sender);
		    Assert.Equal(request, behavior.Sender);
		    Assert.NotNull(behavior.EventArgs);
		    Assert.Equal(EventArgs.Empty, behavior.EventArgs);

		    behavior.Sender = null;
		    behavior.EventArgs = null;
		    page.Behaviors.Clear();

		    request.Request();
		    Assert.Null(behavior.Sender);
		    Assert.Null(behavior.EventArgs);
	    }

	    [Fact]
	    public void ReceiveInteragtionRequestAfterInteractionRequestChanged()
	    {
		    var requestA = new InteractionRequest();
		    var behavior = new BehaviorMock { InteractionRequest = requestA };
		    var page = new PageMock();
		    page.Behaviors.Add(behavior);

			var requestB = new InteractionRequest();
		    behavior.InteractionRequest = requestB;

			requestA.Request();
		    Assert.Null(behavior.Sender);
		    Assert.Null(behavior.EventArgs);

			requestB.Request();

			Assert.NotNull(behavior.Sender);
		    Assert.Equal(requestB, behavior.Sender);
		    Assert.NotNull(behavior.EventArgs);
		    Assert.Equal(EventArgs.Empty, behavior.EventArgs);
	    }

		private class PageMock : ContentPage
	    {
		    // ReSharper disable once EventNeverSubscribedTo.Local
		    public event EventHandler<EventArgs> TestEventA;
		    // ReSharper disable once EventNeverSubscribedTo.Local
		    public event EventHandler<EventArgs> TestEventB;
		    public void RiseTestEventA(object sender, EventArgs eventArgs)
		    {
				TestEventA?.Invoke(sender, eventArgs);
		    }
		    public void RiseTestEventB(object sender, EventArgs eventArgs)
		    {
			    TestEventB?.Invoke(sender, eventArgs);
		    }
	    }

		private class BehaviorMock : ReceiveEventBehavior<Page>
	    {
		    public object Sender { get; set; }
		    public object EventArgs { get; set; }
		    protected override void OnEventRaised(object sender, EventArgs eventArgs)
		    {
			    Sender = sender;
			    EventArgs = eventArgs;
		    }
	    }
    }
}
