using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorsSampleApp.ViewModels
{
	public class SelectionResultPageViewModel : ViewModelBase
	{
		private Fruit _fruit;

		public Fruit Fruit
		{
			get => _fruit;
			set => SetProperty(ref _fruit, value);
		}
	}
}
