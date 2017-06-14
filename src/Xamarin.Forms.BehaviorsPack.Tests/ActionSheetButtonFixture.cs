using System;
using System.Windows.Input;
using Moq;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
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
	    public void OnClicked()
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
		    button.OnClicked(this, eventArgs);

		    commandExecuterMock.Verify(
			    executer => executer.Execute(command, commandParameter, eventArgs, eventArgsConverter, eventArgsConverterParameter, eventArgsPropertyPath),
			    Times.Once);
	    }

        [Fact]
        public void OnClicked_WhenInvokeAction()
        {
            var called = false;
            var action = new ActionSheetButton { Action = () => { called = true; } };
            action.OnClicked(this, EventArgs.Empty);

            Assert.True(called);
        }

        [Fact]
        public void OnClicked_WhenInvokeAction_WithParameter()
        {
            var actual = "parameter";
            string expected = null;
            var action = new ActionSheetButton<string> { Parameter = actual, Action = x => { expected = actual; } };
            action.OnClicked(this, EventArgs.Empty);

            Assert.Equal(expected, actual);
        }

    }
}
