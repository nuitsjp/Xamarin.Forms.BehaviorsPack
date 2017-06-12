using System;

namespace Xamarin.Forms.BehaviorsPack
{
	public interface IActionSheetButton
	{
		string Message { get; set; }

		void OnClick(object sender, EventArgs eventArgs);
	}
}