using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin.Forms.BehaviorsPack
{
    public class AlertButton : IAlertButton
    {
        public string Message { get; set; }
        public Action Action { get; set; }
        public void OnClicked(object sender, EventArgs eventArgs)
        {
            Action?.Invoke();
        }
    }

    public class AlertButton<T> : IAlertButton
    {
        public string Message { get; set; }
        public T Parameter { get; set; }
        public Action<T> Action { get; set; }
        public void OnClicked(object sender, EventArgs eventArgs)
        {
            Action?.Invoke(Parameter);
        }
    }

}
