using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xunit;
using Assert = Xunit.Assert;

namespace XamarinForms.Behaviors.Tests
{
    public class InheritBindingBehaviorFixture
    {
        [Fact]
        public void FromAttachToDettach()
        {
            var page = new ContentPage();
            var contextObject = new object();
            page.BindingContext = contextObject;

            var behavior = new BehaviorMock();
            page.Behaviors.Add(behavior);

            Assert.NotNull(behavior.BindingContext);
            Assert.Equal(contextObject, behavior.BindingContext);

            page.Behaviors.Clear();
            Assert.Null(behavior.BindingContext);
        }

        [Fact]
        public void ParentBindingContextChanged()
        {
            var page = new ContentPage();
            var contextObject = new object();

            var behavior = new BehaviorMock();
            page.Behaviors.Add(behavior);

            Assert.Null(behavior.BindingContext);
            page.BindingContext = contextObject;

            Assert.NotNull(behavior.BindingContext);
            Assert.Equal(contextObject, behavior.BindingContext);

	        page.BindingContext = null;
	        Assert.Null(behavior.BindingContext);

			page.Behaviors.Clear();

            // Chech removed event handler
            page.BindingContext = new object();
            Assert.Null(behavior.BindingContext);
        }

        [Fact]
        public void HasOriginalBindingContedt()
        {
            var page = new ContentPage();
            var contextObject = new object();
            page.BindingContext = contextObject;

            var behavior = new BehaviorMock();
            behavior.BindingContext = new object();
            page.Behaviors.Add(behavior);

            Assert.NotNull(behavior.BindingContext);
            Assert.NotEqual(contextObject, behavior.BindingContext);

            page.BindingContext = new object();
            Assert.NotEqual(page.BindingContext, behavior.BindingContext);


            page.Behaviors.Clear();
            Assert.Null(behavior.BindingContext);

        }

        public class BehaviorMock : InheritBindingBehavior<Page>
        {
            
        }
    }
}
