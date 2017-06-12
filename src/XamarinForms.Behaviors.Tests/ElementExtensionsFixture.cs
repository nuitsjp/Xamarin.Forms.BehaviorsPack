using Xamarin.Forms;
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
	    public void ReturnPageOfElement()
	    {
			var page = new ContentPage();
		    var layout = new StackLayout();
		    page.Content = layout;
		    Assert.Equal(page, layout.GetCurrentPage());
	    }

	    [Fact]
	    public void ReturnPage()
	    {
		    var page = new ContentPage();
		    Assert.Equal(page, page.GetCurrentPage());
	    }
	}
}
