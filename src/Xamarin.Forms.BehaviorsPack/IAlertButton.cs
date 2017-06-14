using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public interface IAlertButton
    {
        string Message { get; set; }
        void OnClicked(object sender, EventArgs eventArgs);
    }
}