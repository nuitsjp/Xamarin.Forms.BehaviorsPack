using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Moq;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class ListViewItemSelectedFixture
    {
        [Fact]
        public void Command()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command
                .Setup(x => x.CanExecute(It.IsAny<SelectedItemChangedEventArgs>()))
                .Callback<object>(eventArg =>
                {
                    Assert.Equal(typeof(SelectedItemChangedEventArgs), eventArg.GetType());
                    Assert.Equal("One", ((SelectedItemChangedEventArgs)eventArg).SelectedItem);
                })
                .Returns(true);

            listView.SetValue(ListViewItemSelected.CommandProperty, command.Object);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute(It.IsAny<SelectedItemChangedEventArgs>()), Times.Once);
            command.Verify(x => x.Execute(It.IsAny<SelectedItemChangedEventArgs>()), Times.Once);
            Assert.NotNull(listView.SelectedItem);
        }

        [Fact]
        public void SelectedItemCommand()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<string>())).Returns(true);

            listView.SetValue(ListViewItemSelected.SelectedItemCommandProperty, command.Object);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Once);
            command.Verify(x => x.Execute("One"), Times.Once);
            Assert.NotNull(listView.SelectedItem);
        }

        [Fact]
        public void ClearAfterExecuteCommand()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<string>())).Returns(true);

            listView.SetValue(ListViewItemSelected.ClearAfterExecuteCommandProperty, command.Object);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Once);
            command.Verify(x => x.Execute("One"), Times.Once);
            Assert.Null(listView.SelectedItem);
        }

    }
}
