using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Moq;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class SelectedItemBehaviorFixture
    {
        [Fact]
        public void ExecuteCommand()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<object>())).Returns(true);

            var behavior = new SelectedItemBehavior {Command = command.Object};
            listView.Behaviors.Add(behavior);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Once);
            command.Verify(x => x.Execute("One"), Times.Once);
            Assert.Null(listView.SelectedItem);
        }

        [Fact]
        public void NotExecuteCommand()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<object>())).Returns(false);

            var behavior = new SelectedItemBehavior { Command = command.Object, ClearSelected = false};
            listView.Behaviors.Add(behavior);

            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Once);
            command.Verify(x => x.Execute("One"), Times.Never);

            Assert.NotNull(listView.SelectedItem);
        }

        [Fact]
        public void OnDetachingFrom()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<object>())).Returns(true);

            var behavior = new SelectedItemBehavior { Command = command.Object };
            listView.Behaviors.Add(behavior);
            listView.Behaviors.Remove(behavior);

            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Never);
            command.Verify(x => x.Execute("One"), Times.Never);
            Assert.NotNull(listView.SelectedItem);
        }

    }
}
