using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Xamarin.Forms.BehaviorsPack.Tests
{
    public class ActionSheetButtonActionFixture
    {
	    [Fact]
	    public void OnClick()
	    {
		    var called = false;
		    var action = new ActionSheetButtonAction { Action = () => { called = true; } };
		    action.OnClick(this, EventArgs.Empty);

		    Assert.True(called);
	    }

		[Fact]
	    public void OnClickWithParameter()
	    {
		    var actual = "parameter";
		    string expected = null;
		    var action = new ActionSheetButtonAction<string>{ Parameter = actual, Action = x => { expected = actual; }};
			action.OnClick(this, EventArgs.Empty);
			
			Assert.Equal(expected, actual);
	    }
    }
}
