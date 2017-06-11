using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class EventToCommandBehaviorFixture
    {
	    [Fact]
	    public void WhenCanNotExecute()
	    {
		    var command = new CommandMock { CanExecuteProperty = false };
		    var behavior = 
				new EventToCommandBehaviorMock
				{
					Command = command
				};
			behavior.Rise(this, EventArgs.Empty);

		    Assert.True(command.CalledCanExecute);
		    Assert.Null(command.CanExecuteParameter);
		    Assert.False(command.CalledExecute);
	    }

	    [Fact]
	    public void WhenUseCommandParameter()
	    {
		    var command = new CommandMock();
		    var commandParameter = new object();
		    var eventArgs = new EventArgs();
		    var converter = new ValueConverterMock();
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "";

		    var behavior =
			    new EventToCommandBehaviorMock
			    {
				    Command = command,
					CommandParameter = commandParameter,
					EventArgsConverter = converter,
					EventArgsConverterParameter = eventArgsConverterParameter,
					EventArgsPropertyPath = eventArgsPropertyPath
			    };
		    behavior.Rise(this, eventArgs);

			Assert.True(command.CalledCanExecute);
		    Assert.Equal(commandParameter, command.CanExecuteParameter);
		    Assert.True(command.CalledExecute);
		    Assert.Equal(commandParameter, command.ExecuteParameter);
	    }

	    [Fact]
	    public void WhenUseValueConverter()
	    {
		    var command = new CommandMock();
		    var eventArgs = new EventArgs();
		    var converter = new ValueConverterMock();
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "";

		    var behavior =
			    new EventToCommandBehaviorMock
			    {
				    Command = command,
				    EventArgsConverter = converter,
				    EventArgsConverterParameter = eventArgsConverterParameter,
				    EventArgsPropertyPath = eventArgsPropertyPath
			    };
		    behavior.Rise(this, eventArgs);

			Assert.True(command.CalledCanExecute);
		    Assert.Equal("Success", command.CanExecuteParameter);
		    Assert.True(command.CalledExecute);
		    Assert.Equal("Success", command.ExecuteParameter);

		    Assert.Equal(eventArgs, converter.Value);
		    Assert.Equal(typeof(object), converter.TargetType);
		    Assert.Equal(eventArgsConverterParameter, converter.Parameter);
		    Assert.Equal(CultureInfo.CurrentUICulture, converter.CultureInfo);
	    }

	    [Fact]
	    public void WhenUseEventArgsPropertyPath()
	    {
		    var command = new CommandMock();
		    var eventArgs = new EventArgsMock { Property = new EventArgsMockProperty() };
		    var eventArgsConverterParameter = new object();
		    var eventArgsPropertyPath = "Property.Value";

		    var behavior =
			    new EventToCommandBehaviorMock
			    {
				    Command = command,
				    EventArgsConverterParameter = eventArgsConverterParameter,
				    EventArgsPropertyPath = eventArgsPropertyPath
			    };
		    behavior.Rise(this, eventArgs);

			Assert.True(command.CalledCanExecute);
		    Assert.Equal("EventArgsMockPropertyValue", command.CanExecuteParameter);
		    Assert.True(command.CalledExecute);
		    Assert.Equal("EventArgsMockPropertyValue", command.ExecuteParameter);
	    }


	    private class EventToCommandBehaviorMock : EventToCommandBehavior
	    {
		    public void Rise(object sender, EventArgs eventArgs)
		    {
			    OnEventRaised(sender, eventArgs);
		    }
	    }

		private class EventArgsMock : EventArgs
	    {
		    public EventArgsMockProperty Property { get; set; }
	    }

	    private class EventArgsMockProperty
	    {
		    public string Value { get; set; } = "EventArgsMockPropertyValue";

	    }

	    private class ValueConverterMock : IValueConverter
	    {
		    public object Value { get; set; }
		    public Type TargetType { get; set; }
		    public object Parameter { get; set; }
		    public CultureInfo CultureInfo { get; set; }
		    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		    {
			    Value = value;
			    TargetType = targetType;
			    Parameter = parameter;
			    CultureInfo = culture;
			    return "Success";
		    }

		    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		    {
			    throw new NotImplementedException();
		    }
	    }

	    private class CommandMock : ICommand
	    {
		    public bool CanExecuteProperty { get; set; } = true;
		    public object CanExecuteParameter { get; set; }
		    public object ExecuteParameter { get; set; }
		    public bool CalledCanExecute { get; set; }
		    public bool CalledExecute { get; set; }
		    public bool CanExecute(object parameter)
		    {
			    CanExecuteParameter = parameter;
			    CalledCanExecute = true;

			    return CanExecuteProperty;
		    }

		    public void Execute(object parameter)
		    {
			    ExecuteParameter = parameter;
			    CalledExecute = true;
		    }

		    public event EventHandler CanExecuteChanged;
	    }
    }
}
