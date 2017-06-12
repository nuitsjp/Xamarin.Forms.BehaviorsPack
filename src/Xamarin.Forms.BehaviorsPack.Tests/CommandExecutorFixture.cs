using System;
using System.Globalization;
using System.Windows.Input;
using Moq;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class CommandExecutorFixture
    {
	    [Fact]
	    public void WhenCanNotExecute()
	    {
		    var commandMock = new Mock<ICommand>();
		    commandMock.Setup(x => x.CanExecute(It.IsAny<object>())).Returns(false);
		    new CommandExecutor().Execute(commandMock.Object);

			commandMock.Verify(x => x.CanExecute(It.IsAny<object>()), Times.Once);
		    commandMock.Verify(x => x.Execute(It.IsAny<object>()), Times.Never);
	    }

	    [Fact]
	    public void WhenUseCommandParameter()
	    {
		    var commandMock = new Mock<ICommand>();
			var commandParameter = new object();
			var eventArgs = new EventArgs();
			var converter = new Mock<IValueConverter>().Object;
			var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "";

		    commandMock.Setup(x => x.CanExecute(commandParameter)).Returns(true);

		    new CommandExecutor().Execute(commandMock.Object, commandParameter, eventArgs, converter, eventArgsConverterParameter, eventArgsPropertyPath);

		    commandMock.Verify(x => x.CanExecute(commandParameter), Times.Once);
		    commandMock.Verify(x => x.Execute(commandParameter), Times.Once);
	    }

	    [Fact]
	    public void WhenUseValueConverter()
	    {
		    var commandMock = new Mock<ICommand>();
		    var eventArgs = new EventArgs();
		    var converterMock = new Mock<IValueConverter>();
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "";

		    converterMock.Setup(x => x.Convert(eventArgs, typeof(object), eventArgsConverterParameter,
			    CultureInfo.CurrentUICulture)).Returns("Success");
		    commandMock.Setup(x => x.CanExecute("Success")).Returns(true);

			new CommandExecutor().Execute(commandMock.Object, null, eventArgs, converterMock.Object, eventArgsConverterParameter, eventArgsPropertyPath);

			commandMock.Verify(x => x.CanExecute("Success"), Times.Once);
		    commandMock.Verify(x => x.Execute("Success"), Times.Once);

			converterMock.Verify(x => x.Convert(eventArgs, typeof(object), eventArgsConverterParameter, CultureInfo.CurrentUICulture), Times.Once);
		}

		[Fact]
	    public void WhenUseEventArgsPropertyPath()
	    {
		    var commandMock = new Mock<ICommand>();
		    var eventArgs = new EventArgsMock { Property = new EventArgsMockProperty()};
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "Property.Value";

		    commandMock.Setup(x => x.CanExecute("EventArgsMockPropertyValue")).Returns(true);

			new CommandExecutor().Execute(commandMock.Object, null, eventArgs, null, eventArgsConverterParameter, eventArgsPropertyPath);

		    commandMock.Verify(x => x.CanExecute("EventArgsMockPropertyValue"), Times.Once);
		    commandMock.Verify(x => x.Execute("EventArgsMockPropertyValue"), Times.Once);
	    }

	    [Fact]
	    public void WhenUseEventArgsPropertyPath_WhenPropertyIsNull()
	    {
		    var commandMock = new Mock<ICommand>();
		    var eventArgs = new EventArgsMock();
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "Property.Value";

		    commandMock.Setup(x => x.CanExecute(null)).Returns(true);

			new CommandExecutor().Execute(commandMock.Object, null, eventArgs, null, eventArgsConverterParameter, eventArgsPropertyPath);

		    commandMock.Verify(x => x.CanExecute(null), Times.Once);
		    commandMock.Verify(x => x.Execute(null), Times.Once);
	    }

	    [Fact]
	    public void WhenParameterIsNull()
	    {
		    var commandMock = new Mock<ICommand>();
		    var eventArgs = new EventArgsMock();
		    var eventArgsConverterParameter = new object();

		    commandMock.Setup(x => x.CanExecute(null)).Returns(true);

			new CommandExecutor().Execute(commandMock.Object, null, eventArgs, null, eventArgsConverterParameter);

		    commandMock.Verify(x => x.CanExecute(null), Times.Once);
		    commandMock.Verify(x => x.Execute(null), Times.Once);
	    }

		[Fact]
	    public void WhenCommandIsNull()
	    {
		    new CommandExecutor().Execute(null);
	    }

	    private class EventArgsMock : EventArgs
	    {
		    // ReSharper disable once UnusedAutoPropertyAccessor.Local
		    public EventArgsMockProperty Property { get; set; }
	    }

	    private class EventArgsMockProperty
	    {
		    // ReSharper disable once UnusedMember.Local
		    public string Value { get; set; } = "EventArgsMockPropertyValue";

	    }
    }
}
