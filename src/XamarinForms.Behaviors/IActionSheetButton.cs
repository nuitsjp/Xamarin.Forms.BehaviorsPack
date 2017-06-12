using System;

namespace XamarinForms.Behaviors
{
	public interface IActionSheetButton
	{
		string Message { get; set; }

		void OnClick(object sender, EventArgs eventArgs);
	}
}