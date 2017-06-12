using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinForms.Behaviors
{
	public interface IActionSheetButton
	{
		string Message { get; set; }

		void OnClick(object sender, EventArgs eventArgs);
	}
}