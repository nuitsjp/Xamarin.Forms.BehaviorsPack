using System;
using System.Windows.Input;
using Moq;
using Xamarin.Forms;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class ActionSheetButtonFixture
    {
	    [Fact]
	    public void MessageProperty()
	    {
			var actionSheetButton = new ActionSheetButton { Message = "Message"};
		    Assert.Equal("Message", actionSheetButton.Message);
	    }

	    [Fact]
	    public void OnClick()
	    {
		    var commandExecuterMock = new Mock<ICommandExecutor>();
		    var command = new Mock<ICommand>().Object;
		    var commandParameter = new object();
		    var eventArgs = new EventArgs();
		    var eventArgsConverter = new Mock<IValueConverter>().Object;
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "";

		    var button =
			    new ActionSheetButton()
			    {
				    CommandExecutor = commandExecuterMock.Object,
				    Command = command,
				    CommandParameter = commandParameter,
				    EventArgsConverter = eventArgsConverter,
				    EventArgsConverterParameter = eventArgsConverterParameter,
				    EventArgsPropertyPath = eventArgsPropertyPath
			    };
		    button.OnClick(this, eventArgs);

		    commandExecuterMock.Verify(
			    executer => executer.Execute(command, commandParameter, eventArgs, eventArgsConverter, eventArgsConverterParameter, eventArgsPropertyPath),
			    Times.Once);
	    }
    }
}
