using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class AlertButtonFixture
    {
        [Fact]
        public void OnClicked()
        {
            var called = false;
            var action = new AlertButton() { Message = "message", Action = () => { called = true; } };
            action.OnClicked(this, EventArgs.Empty);

            Assert.Equal("message", action.Message);
            Assert.True(called);
        }

        [Fact]
        public void OnClicked_WithParameter()
        {
            var actual = "parameter";
            string expected = null;
            var action = new AlertButton<string> { Message = "message", Parameter = actual, Action = x => { expected = actual; } };
            action.OnClicked(this, EventArgs.Empty);

            Assert.Equal("message", action.Message);
            Assert.Equal(expected, actual);
        }

    }
}
