using System;

namespace Xamarin.Forms.BehaviorsPack
{
	public interface IActionSheetButton
	{
		string Message { get; set; }

		void OnClicked(object sender, EventArgs eventArgs);
	}
}