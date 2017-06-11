using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class DisplayAlertBehaviorFixture
    {
	    [Fact]
	    public void WhenAlertDialog()
	    {
		    var acceptCommand = new CommandMock();
		    var cancelCommand = new CommandMock();
			var behavior = new DisplayAlertBehavior
			{
				EventName = "TestEventA",
				Title = "WhenCancelOnly",
				Message = "Message",
				Accept = null,
				Cancel = "Cancel",
				AcceptCommand = acceptCommand,
				CancelCommand = cancelCommand
			};
		    var page = new PageMock();
			page.Behaviors.Add(behavior);

		    MessagingCenter.Subscribe<Page, AlertArguments>(this, Page.AlertSignalName, (page1, arguments) =>
		    {
			    if (arguments.Title == "WhenCancelOnly")
			    {
					Assert.Equal("Message", arguments.Message);
				    Assert.Equal(null, arguments.Accept);
				    Assert.Equal("Cancel", arguments.Cancel);
				    arguments.SetResult(false);
			    }
		    });

			page.RiseTestEventA(this, EventArgs.Empty);

			Assert.False(acceptCommand.CalledExecute);
		    Assert.True(cancelCommand.CalledExecute);
		}

	    [Fact]
	    public void WhenSelectAcceptOfConfirmDialog()
	    {
		    var acceptCommand = new CommandMock();
		    var cancelCommand = new CommandMock();
		    var behavior = new DisplayAlertBehavior
		    {
			    EventName = "TestEventA",
			    Title = "WhenSelectAcceptOfConfirmDialog",
			    Message = "Message",
			    Accept = "Accept",
			    Cancel = "Cancel",
			    AcceptCommand = acceptCommand,
			    CancelCommand = cancelCommand
		    };
		    var page = new PageMock();
		    page.Behaviors.Add(behavior);

		    MessagingCenter.Subscribe<Page, AlertArguments>(this, Page.AlertSignalName, (page1, arguments) =>
		    {
			    if (arguments.Title == "WhenSelectAcceptOfConfirmDialog")
			    {
				    Assert.Equal("Message", arguments.Message);
				    Assert.Equal("Accept", arguments.Accept);
				    Assert.Equal("Cancel", arguments.Cancel);
				    arguments.SetResult(true);
			    }
		    });

		    page.RiseTestEventA(this, EventArgs.Empty);

		    Assert.True(acceptCommand.CalledExecute);
		    Assert.False(cancelCommand.CalledExecute);
	    }

	    [Fact]
	    public void WhenSelectCancelOfConfirmDialog()
	    {
		    var acceptCommand = new CommandMock();
		    var cancelCommand = new CommandMock();
		    var behavior = new DisplayAlertBehavior
		    {
			    EventName = "TestEventA",
			    Title = "WhenSelectCancelOfConfirmDialog",
			    Message = "Message",
			    Accept = "Accept",
			    Cancel = "Cancel",
			    AcceptCommand = acceptCommand,
			    CancelCommand = cancelCommand
		    };
		    var page = new PageMock();
		    page.Behaviors.Add(behavior);

		    MessagingCenter.Subscribe<Page, AlertArguments>(this, Page.AlertSignalName, (page1, arguments) =>
		    {
			    if (arguments.Title == "WhenSelectCancelOfConfirmDialog")
			    {
				    Assert.Equal("Message", arguments.Message);
				    Assert.Equal("Accept", arguments.Accept);
				    Assert.Equal("Cancel", arguments.Cancel);
				    arguments.SetResult(false);
			    }
		    });

		    page.RiseTestEventA(this, EventArgs.Empty);

		    Assert.False(acceptCommand.CalledExecute);
		    Assert.True(cancelCommand.CalledExecute);
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

		private class PageMock : ContentPage
	    {
		    public event EventHandler<EventArgs> TestEventA;
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

	}
}
