using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BehaviorsSampleApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateListViewButton_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new ListViewPage());
        }
    }
}
