using System;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class InteractionRequestFixture
    {
	    [Fact]
	    public void Request()
	    {
			var request = new InteractionRequest();
		    var requestedEvent = Assert.Raises<EventArgs>(h => request.Requested += h, h => request.Requested -= h, () => request.Request());

			Assert.NotNull(requestedEvent);
			Assert.Equal(request, requestedEvent.Sender);
			Assert.Equal(EventArgs.Empty, requestedEvent.Arguments);
	    }

		[Fact]
		public void RequestWithSender()
		{
			var request = new InteractionRequest();
			var requestedEvent = Assert.Raises<EventArgs>(h => request.Requested += h, h => request.Requested -= h, () => request.Request(this));

			Assert.NotNull(requestedEvent);
			Assert.Equal(this, requestedEvent.Sender);
			Assert.Equal(EventArgs.Empty, requestedEvent.Arguments);
		}

	}
}
