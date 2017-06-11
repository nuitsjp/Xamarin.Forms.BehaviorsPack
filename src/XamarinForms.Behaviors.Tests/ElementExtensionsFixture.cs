using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinForms.Behaviors;
using Xunit;

namespace XamarinForms.Behaviors.Tests
{
    public class ElementExtensionsFixture
    {
	    [Fact]
	    public void ReturnNull()
	    {
		    var layout = new StackLayout();
			Assert.Null(layout.GetCurrentPage());
	    }

	    [Fact]
	    public void ReturnPage()
	    {
			var page = new ContentPage();
		    var layout = new StackLayout();
		    page.Content = layout;
		    Assert.Equal(page, layout.GetCurrentPage());
	    }
	}
}
