using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Input;
using Moq;
using Xamarin.Forms;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class EventToCommandBehaviorFixture
    {
	    [Fact]
	    public void WhenOnEventRaised()
	    {
		    var commandExecuterMock = new Mock<ICommandExecutor>();
		    var command = new Mock<ICommand>().Object;
		    var commandParameter = new object();
		    var eventArgs = new EventArgs();
		    var eventArgsConverter = new Mock<IValueConverter>().Object;
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "";

		    var behavior =
			    new EventToCommandBehaviorMock
				{
					CommandExecutor = commandExecuterMock.Object,
					Command = command,
					CommandParameter = commandParameter,
					EventArgsConverter = eventArgsConverter,
					EventArgsConverterParameter = eventArgsConverterParameter,
					EventArgsPropertyPath = eventArgsPropertyPath
				};
			behavior.Rise(this, eventArgs);

			commandExecuterMock.Verify(
				executer => executer.Execute(command, commandParameter, eventArgs, eventArgsConverter, eventArgsConverterParameter, eventArgsPropertyPath), 
				Times.Once);
	    }

	    private class EventToCommandBehaviorMock : EventToCommandBehavior
	    {
		    public void Rise(object sender, EventArgs eventArgs)
		    {
			    OnEventRaised(sender, eventArgs);
		    }
	    }
    }
}
