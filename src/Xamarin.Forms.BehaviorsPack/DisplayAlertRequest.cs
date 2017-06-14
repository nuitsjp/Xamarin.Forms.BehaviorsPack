using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class DisplayAlertRequest : INotificationRequest<EventArgs>
    {
	    public event EventHandler<EventArgs> Requested;

	    public void Raise(string title = null, string message = null, IAlertButton accept = null, IAlertButton cancel = null)
	    {
		    Requested?.Invoke(this, new DisplayAlertRequestEventArgs
		    {
			    Title = title,
				Message = message,
				Accept = accept,
				Cancel = cancel
		    });
	    }
	}
}
