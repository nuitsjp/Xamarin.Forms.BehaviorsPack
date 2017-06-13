using System;

namespace Xamarin.Forms.BehaviorsPack
{
    public class ActionSheetButtonAction : IActionSheetButton
    {
	    public string Message { get; set; }
	    public Action Action { get; set; }
	    public void OnClicked(object sender, EventArgs eventArgs)
	    {
			Action?.Invoke();
	    }
    }

	public class ActionSheetButtonAction<T> : IActionSheetButton
	{
		public string Message { get; set; }
		public Action<T> Action { get; set; }
		public T Parameter { get; set; }
		public void OnClicked(object sender, EventArgs eventArgs)
		{
			Action?.Invoke(Parameter);
		}
	}
}
