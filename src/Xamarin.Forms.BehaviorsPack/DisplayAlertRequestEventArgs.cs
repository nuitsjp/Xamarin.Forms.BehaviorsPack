using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class DisplayAlertRequestEventArgs : EventArgs
    {
	    public string Title { get; set; }
	    public string Message { get; set; }
	    public IAlertButton Accept { get; set; }
	    public IAlertButton Cancel { get; set; }
    }
}
