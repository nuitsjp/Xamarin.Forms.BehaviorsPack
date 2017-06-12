using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorsSampleApp.ViewModels
{
	public class SelectedFruitEventArgs : EventArgs
	{
		public Fruit SelectedFruit { get; set; }
	}
}
