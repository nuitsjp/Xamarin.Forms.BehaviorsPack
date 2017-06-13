using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.BehaviorsPack
{
    public class DisplayActionSheetRequest : INotificationRequest<EventArgs>
    {
	    public event EventHandler<EventArgs> Requested;

	    public void Raise(string title = null, IActionSheetButton cancel = null, IActionSheetButton destruction = null, params IActionSheetButton[] buttons)
	    {
		    Requested?.Invoke(this, new DisplayActionSheetRequestEventArgs
		    {
			    Title = title,
				Cancel = cancel,
				Destruction = destruction,
				ActionSheetButtons = buttons
		    });
	    }
    }
}
