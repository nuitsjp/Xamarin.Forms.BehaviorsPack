using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace BehaviorsSampleApp.ViewModels
{
    public class WebViewPageViewModel
    {
        public Command<string> NavigatedCommand => new Command<string>(x =>
        {
        });
    }
}
