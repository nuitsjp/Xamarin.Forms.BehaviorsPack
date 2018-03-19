using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using Moq;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class ItemSelected
    {
        [Fact]
        public void ItemSelectedProperty()
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

            listView.SetValue(ListViews.ItemSelectedProperty, command.Object);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute(It.IsAny<SelectedItemChangedEventArgs>()), Times.Once);
            command.Verify(x => x.Execute(It.IsAny<SelectedItemChangedEventArgs>()), Times.Once);
            Assert.NotNull(listView.SelectedItem);
        }

        [Fact]
        public void ItemSelectedPropertyWhenCommandIsNull()
        {
            var listView = new ListView();
            listView.SetValue(ListViews.ItemSelectedProperty, null);

            listView.SelectedItem = "One";

            Assert.NotNull(listView.SelectedItem);
        }

        [Fact]
        public void NotifySelectedItemWhenItemSelectedProperty()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<string>())).Returns(true);

            listView.SetValue(ListViews.ItemSelected.SelectedItemProperty, command.Object);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Once);
            command.Verify(x => x.Execute("One"), Times.Once);
            Assert.NotNull(listView.SelectedItem);
        }

        [Fact]
        public void ClearSelectedItemCommand()
        {
            var listView = new ListView();
            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<string>())).Returns(true);

            listView.SetValue(ListViews.ItemSelected.ClearSelectedItemWhenItemSelectedProperty, command.Object);


            listView.SelectedItem = "One";

            command.Verify(x => x.CanExecute("One"), Times.Once);
            command.Verify(x => x.CanExecute(It.IsAny<object>()), Times.Once);
            command.Verify(x => x.Execute("One"), Times.Once);
            command.Verify(x => x.Execute(It.IsAny<object>()), Times.Once);
            Assert.Null(listView.SelectedItem);
        }

        [Fact]
        public void ClearSelectedItemCommandWhenSelectedItemIsNull()
        {
            var listView = new ListView {SelectedItem = "One"};

            var command = new Mock<ICommand>();
            command.Setup(x => x.CanExecute(It.IsAny<object>())).Returns(true);

            listView.SetValue(ListViews.ItemSelected.ClearSelectedItemWhenItemSelectedProperty, command.Object);


            listView.SelectedItem = null;

            command.Verify(x => x.CanExecute(It.IsAny<object>()), Times.Never);
            command.Verify(x => x.Execute(It.IsAny<object>()), Times.Never);
            Assert.Null(listView.SelectedItem);
        }
    }
}
