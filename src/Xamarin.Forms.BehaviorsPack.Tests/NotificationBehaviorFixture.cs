using System;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class NotificationBehaviorFixture
    {
	    [Fact]
	    public void NotifyReceivedEvent()
	    {
		    var request = new NotificationRequest();
		    var behavior = new NotificationBehavior { NotificationRequest = request };

		    var receivedEvent = Assert.Raises<EventArgs>(h => behavior.Received += h, h => behavior.Received -= h, () => request.Raise());

		    Assert.NotNull(receivedEvent);
		    Assert.Equal(request, receivedEvent.Sender);
		    Assert.Equal(EventArgs.Empty, receivedEvent.Arguments);

		    behavior.NotificationRequest = null;

		    request.Raise();
		    behavior.Received += (sender, args) =>
		    {
			    Assert.True(false);
		    };
	    }

		[Fact]
	    public void NotificationRequestProperty()
	    {
		    var request = new NotificationRequest();
		    var behavior = new NotificationBehavior { NotificationRequest = request };
			Assert.Equal(request, behavior.NotificationRequest);
		}
	}
}
