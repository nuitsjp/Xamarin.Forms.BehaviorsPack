using System;
using System.Windows.Input;
using Moq;
using Xamarin.Forms.Internals;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class DisplayAlertBehaviorFixture
    {
	    [Fact]
	    public void WhenAlertDialog()
	    {
			var commandExecutorMock = new Mock<ICommandExecutor>();
		    var acceptCommand = new Mock<ICommand>().Object;
		    var acceptCommandParameter = new object();
		    var acceptEventArgsConverter = new Mock<IValueConverter>().Object;
		    var acceptEventArgsConverterParameter = new object();
		    var acceptEventArgsPropertyPath = "acceptEventArgsPropertyPath";

		    var cancelCommand = new Mock<ICommand>().Object;
		    var cancelCommandParameter = new object();
		    var cancelEventArgsConverter = new Mock<IValueConverter>().Object;
		    var cancelEventArgsConverterParameter = new object();
		    var cancelEventArgsPropertyPath = "cancelEventArgsPropertyPath";

		    var behavior = new DisplayAlertBehavior
		    {
			    CommandExecutor = commandExecutorMock.Object,
			    EventName = "TestEvent",
			    Title = "WhenCancelOnly",
			    Message = "Message",
			    Accept = null,
			    Cancel = "Cancel",
			    AcceptCommand = acceptCommand,
			    AcceptCommandParameter = acceptCommandParameter,
			    AcceptEventArgsConverter = acceptEventArgsConverter,
			    AcceptEventArgsConverterParameter = acceptEventArgsConverterParameter,
			    AcceptEventArgsPropertyPath = acceptEventArgsPropertyPath,
			    CancelCommand = cancelCommand,
			    CancelCommandParameter = cancelCommandParameter,
			    CancelEventArgsConverter = cancelEventArgsConverter,
			    CancelEventArgsConverterParameter = cancelEventArgsConverterParameter,
			    CancelEventArgsPropertyPath = cancelEventArgsPropertyPath
		    };

			var page = new PageMock();
			page.Behaviors.Add(behavior);

		    MessagingCenter.Subscribe<Page, AlertArguments>(this, Page.AlertSignalName, (page1, arguments) =>
		    {
			    if (arguments.Title == "WhenCancelOnly")
			    {
					Assert.Equal("Message", arguments.Message);
				    Assert.Null(arguments.Accept);
				    Assert.Equal("Cancel", arguments.Cancel);
				    arguments.SetResult(false);
			    }
		    });

			page.RiseTestEvent(this, EventArgs.Empty);

		    commandExecutorMock.Verify(
			    commandExecutor => commandExecutor.Execute(
				    cancelCommand,
				    cancelCommandParameter, 
					EventArgs.Empty,
				    cancelEventArgsConverter,
				    cancelEventArgsConverterParameter,
				    cancelEventArgsPropertyPath),
			    Times.Once);
	    }

		[Fact]
		public void WhenSelectAcceptOfConfirmDialog()
		{
			var commandExecutorMock = new Mock<ICommandExecutor>();
			var acceptCommand = new Mock<ICommand>().Object;
			var acceptCommandParameter = new object();
			var acceptEventArgsConverter = new Mock<IValueConverter>().Object;
			var acceptEventArgsConverterParameter = new object();
			var acceptEventArgsPropertyPath = "acceptEventArgsPropertyPath";

			var cancelCommand = new Mock<ICommand>().Object;
			var cancelCommandParameter = new object();
			var cancelEventArgsConverter = new Mock<IValueConverter>().Object;
			var cancelEventArgsConverterParameter = new object();
			var cancelEventArgsPropertyPath = "cancelEventArgsPropertyPath";

			var behavior = new DisplayAlertBehavior
			{
				CommandExecutor = commandExecutorMock.Object,
				EventName = "TestEvent",
				Title = "WhenSelectAcceptOfConfirmDialog",
				Message = "Message",
				Accept = "Accept",
				Cancel = "Cancel",
				AcceptCommand = acceptCommand,
				AcceptCommandParameter = acceptCommandParameter,
				AcceptEventArgsConverter = acceptEventArgsConverter,
				AcceptEventArgsConverterParameter = acceptEventArgsConverterParameter,
				AcceptEventArgsPropertyPath = acceptEventArgsPropertyPath,
				CancelCommand = cancelCommand,
				CancelCommandParameter = cancelCommandParameter,
				CancelEventArgsConverter = cancelEventArgsConverter,
				CancelEventArgsConverterParameter = cancelEventArgsConverterParameter,
				CancelEventArgsPropertyPath = cancelEventArgsPropertyPath
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

			page.RiseTestEvent(this, EventArgs.Empty);

			commandExecutorMock.Verify(
				commandExecutor => commandExecutor.Execute(
					acceptCommand,
					acceptCommandParameter,
					EventArgs.Empty,
					acceptEventArgsConverter,
					acceptEventArgsConverterParameter,
					acceptEventArgsPropertyPath),
				Times.Once);
		}



		[Fact]
		public void WhenSelectCancelOfConfirmDialog()
		{
			var commandExecutorMock = new Mock<ICommandExecutor>();
			var acceptCommand = new Mock<ICommand>().Object;
			var acceptCommandParameter = new object();
			var acceptEventArgsConverter = new Mock<IValueConverter>().Object;
			var acceptEventArgsConverterParameter = new object();
			var acceptEventArgsPropertyPath = "acceptEventArgsPropertyPath";

			var cancelCommand = new Mock<ICommand>().Object;
			var cancelCommandParameter = new object();
			var cancelEventArgsConverter = new Mock<IValueConverter>().Object;
			var cancelEventArgsConverterParameter = new object();
			var cancelEventArgsPropertyPath = "cancelEventArgsPropertyPath";

			var behavior = new DisplayAlertBehavior
			{
				CommandExecutor = commandExecutorMock.Object,
				EventName = "TestEvent",
				Title = "WhenSelectCancelOfConfirmDialog",
				Message = "Message",
				Accept = "Accept",
				Cancel = "Cancel",
				AcceptCommand = acceptCommand,
				AcceptCommandParameter = acceptCommandParameter,
				AcceptEventArgsConverter = acceptEventArgsConverter,
				AcceptEventArgsConverterParameter = acceptEventArgsConverterParameter,
				AcceptEventArgsPropertyPath = acceptEventArgsPropertyPath,
				CancelCommand = cancelCommand,
				CancelCommandParameter = cancelCommandParameter,
				CancelEventArgsConverter = cancelEventArgsConverter,
				CancelEventArgsConverterParameter = cancelEventArgsConverterParameter,
				CancelEventArgsPropertyPath = cancelEventArgsPropertyPath
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

			page.RiseTestEvent(this, EventArgs.Empty);

			commandExecutorMock.Verify(
				commandExecutor => commandExecutor.Execute(
					cancelCommand,
					cancelCommandParameter,
					EventArgs.Empty,
					cancelEventArgsConverter,
					cancelEventArgsConverterParameter,
					cancelEventArgsPropertyPath),
				Times.Once);
		}

	    [Fact]
	    public void DisplayAlertRequest_WhenAccept()
	    {
		    var commandExecutorMock = new Mock<ICommandExecutor>();
		    var acceptCommand = new Mock<ICommand>().Object;
		    var acceptCommandParameter = new object();
		    var acceptEventArgsConverter = new Mock<IValueConverter>().Object;
		    var acceptEventArgsConverterParameter = new object();
		    var acceptEventArgsPropertyPath = "acceptEventArgsPropertyPath";

		    var cancelCommand = new Mock<ICommand>().Object;
		    var cancelCommandParameter = new object();
		    var cancelEventArgsConverter = new Mock<IValueConverter>().Object;
		    var cancelEventArgsConverterParameter = new object();
		    var cancelEventArgsPropertyPath = "cancelEventArgsPropertyPath";

		    var request = new DisplayAlertRequest();
		    var behavior = new DisplayAlertBehavior
		    {
			    CommandExecutor = commandExecutorMock.Object,
			    NotificationRequest = request,
			    Title = "Title",
			    Message = "Message",
			    Accept = "Accept",
			    Cancel = "Cancel",
			    AcceptCommand = acceptCommand,
			    AcceptCommandParameter = acceptCommandParameter,
			    AcceptEventArgsConverter = acceptEventArgsConverter,
			    AcceptEventArgsConverterParameter = acceptEventArgsConverterParameter,
			    AcceptEventArgsPropertyPath = acceptEventArgsPropertyPath,
			    CancelCommand = cancelCommand,
			    CancelCommandParameter = cancelCommandParameter,
			    CancelEventArgsConverter = cancelEventArgsConverter,
			    CancelEventArgsConverterParameter = cancelEventArgsConverterParameter,
			    CancelEventArgsPropertyPath = cancelEventArgsPropertyPath
		    };
		    var page = new PageMock();
		    page.Behaviors.Add(behavior);

		    string noticeTitle = null;
		    string noticeMessage = null;
		    string noticeAccept = null;
		    string noticeCancel = null;
		    MessagingCenter.Subscribe<Page, AlertArguments>(this, Page.AlertSignalName, (page1, arguments) =>
		    {
			    noticeTitle = arguments.Title;
			    noticeMessage = arguments.Message;
			    noticeAccept = arguments.Accept;
			    noticeCancel = arguments.Cancel;
			    if (arguments.Title == "ReplacedTitle_WhenAccept")
			    {
				    arguments.SetResult(true);
			    }
		    });

	        var calledAcceptButton = false;
            var acceptButton = new AlertButton{ Message = "ReplacedAccept", Action = () => calledAcceptButton = true};
	        var calledCancelButton = false;
	        var cancelButton = new AlertButton<string> { Message = "ReplacedCancel", Parameter = "param", Action = param =>
	        {
	            calledCancelButton = true;
	        } };

	        request.Raise("ReplacedTitle_WhenAccept", "ReplacedMessage", acceptButton, cancelButton);

			Assert.Equal("ReplacedTitle_WhenAccept", noticeTitle);
		    Assert.Equal("ReplacedMessage", noticeMessage);
		    Assert.Equal("ReplacedAccept", noticeAccept);
		    Assert.Equal("ReplacedCancel", noticeCancel);

			commandExecutorMock.Verify(
			    commandExecutor => commandExecutor.Execute(
                    It.IsAny<ICommand>(), It.IsAny<object>(), It.IsAny<EventArgs>(), It.IsAny<IValueConverter>(), It.IsAny<object>(), It.IsAny<string>()),
			    Times.Never);
            Assert.True(calledAcceptButton);
	        Assert.False(calledCancelButton);
	    }

        [Fact]
        public void DisplayAlertRequest_WhenCancel()
        {
            var commandExecutorMock = new Mock<ICommandExecutor>();
            var acceptCommand = new Mock<ICommand>().Object;
            var acceptCommandParameter = new object();
            var acceptEventArgsConverter = new Mock<IValueConverter>().Object;
            var acceptEventArgsConverterParameter = new object();
            var acceptEventArgsPropertyPath = "acceptEventArgsPropertyPath";

            var cancelCommand = new Mock<ICommand>().Object;
            var cancelCommandParameter = new object();
            var cancelEventArgsConverter = new Mock<IValueConverter>().Object;
            var cancelEventArgsConverterParameter = new object();
            var cancelEventArgsPropertyPath = "cancelEventArgsPropertyPath";

            var request = new DisplayAlertRequest();
            var behavior = new DisplayAlertBehavior
            {
                CommandExecutor = commandExecutorMock.Object,
                NotificationRequest = request,
                Title = "Title",
                Message = "Message",
                Accept = "Accept",
                Cancel = "Cancel",
                AcceptCommand = acceptCommand,
                AcceptCommandParameter = acceptCommandParameter,
                AcceptEventArgsConverter = acceptEventArgsConverter,
                AcceptEventArgsConverterParameter = acceptEventArgsConverterParameter,
                AcceptEventArgsPropertyPath = acceptEventArgsPropertyPath,
                CancelCommand = cancelCommand,
                CancelCommandParameter = cancelCommandParameter,
                CancelEventArgsConverter = cancelEventArgsConverter,
                CancelEventArgsConverterParameter = cancelEventArgsConverterParameter,
                CancelEventArgsPropertyPath = cancelEventArgsPropertyPath
            };
            var page = new PageMock();
            page.Behaviors.Add(behavior);

            string noticeTitle = null;
            string noticeMessage = null;
            string noticeAccept = null;
            string noticeCancel = null;
            MessagingCenter.Subscribe<Page, AlertArguments>(this, Page.AlertSignalName, (page1, arguments) =>
            {
                noticeTitle = arguments.Title;
                noticeMessage = arguments.Message;
                noticeAccept = arguments.Accept;
                noticeCancel = arguments.Cancel;
                if (arguments.Title == "ReplacedTitle_WhenCancel")
                {
                    arguments.SetResult(false);
                }
            });

            var calledAcceptButton = false;
            var acceptButton = new AlertButton { Message = "ReplacedAccept", Action = () => calledAcceptButton = true };
            var calledCancelButton = false;
            object cancelParameter = null;
            var cancelButton = new AlertButton<string>
            {
                Message = "ReplacedCancel",
                Parameter = "param",
                Action = param =>
                {
                    calledCancelButton = true;
                    cancelParameter = param;
                }
            };

            request.Raise("ReplacedTitle_WhenCancel", "ReplacedMessage", acceptButton, cancelButton);

            Assert.Equal("ReplacedTitle_WhenCancel", noticeTitle);
            Assert.Equal("ReplacedMessage", noticeMessage);
            Assert.Equal("ReplacedAccept", noticeAccept);
            Assert.Equal("ReplacedCancel", noticeCancel);

            commandExecutorMock.Verify(
                commandExecutor => commandExecutor.Execute(
                    It.IsAny<ICommand>(), It.IsAny<object>(), It.IsAny<EventArgs>(), It.IsAny<IValueConverter>(), It.IsAny<object>(), It.IsAny<string>()),
                Times.Never);
            Assert.False(calledAcceptButton);
            Assert.True(calledCancelButton);
            Assert.Equal("param", cancelParameter);
        }

        private class PageMock : ContentPage
	    {
		    // ReSharper disable once EventNeverSubscribedTo.Local
		    public event EventHandler<EventArgs> TestEvent;

            public PageMock()
            {
                IsPlatformEnabled = true;
            }

		    public void RiseTestEvent(object sender, EventArgs eventArgs)
		    {
			    TestEvent?.Invoke(sender, eventArgs);
		    }
	    }

	}
}
