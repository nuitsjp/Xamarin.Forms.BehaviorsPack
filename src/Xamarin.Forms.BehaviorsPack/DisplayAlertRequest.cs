using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.BehaviorsPack
{
    public class DisplayAlertRequest : INotificationRequest<EventArgs>
    {
	    public event EventHandler<EventArgs> Requested;

	    public void Request(string title = null, string message = null, string accept = null, string cancel = null)
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
