using System;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class NotificationRequestFixture
    {
		[Fact]
		public void Request()
		{
			var request = new NotificationRequest();
			var requestedEvent = Assert.Raises<EventArgs>(h => request.Requested += h, h => request.Requested -= h, () => request.Raise());

			Assert.NotNull(requestedEvent);
			Assert.Equal(request, requestedEvent.Sender);
			Assert.Equal(EventArgs.Empty, requestedEvent.Arguments);
		}

	    [Fact]
	    public void RequestGenerics()
	    {
		    var request = new NotificationRequest<EventArgsMock>();
			var eventArgs = new EventArgsMock();
		    var requestedEvent = 
				Assert.Raises<EventArgsMock>(
					h => request.Requested += h, 
					h => request.Requested -= h, 
					() => request.Raise(eventArgs));

		    Assert.NotNull(requestedEvent);
		    Assert.Equal(request, requestedEvent.Sender);
		    Assert.Equal(eventArgs, requestedEvent.Arguments);
	    }

		private class EventArgsMock : EventArgs
	    {
		    
	    }
	}
}
