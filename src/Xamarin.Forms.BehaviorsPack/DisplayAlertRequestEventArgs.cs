using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.BehaviorsPack
{
    public class DisplayAlertRequestEventArgs : EventArgs
    {
	    public string Title { get; set; }
	    public string Message { get; set; }
	    public string Accept { get; set; }
	    public string Cancel { get; set; }
    }
}
