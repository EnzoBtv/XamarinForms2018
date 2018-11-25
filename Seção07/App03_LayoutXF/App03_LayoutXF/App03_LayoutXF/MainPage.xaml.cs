using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App03_LayoutXF
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}
		private void MudarParaStack(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Layouts.Stack.StackPage());
		}
		private void MudarParaGrid(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Layouts.Grid.GridPage());
		}
		private void MudarParaAbsolute(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Layouts.Absolute.AbsolutePage());
		}
		private void MudarParaRelative(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Layouts.Relative.RelativePage());
		}
		private void MudarParaScroll(object sender, EventArgs args)
		{
			Navigation.PushAsync(new Layouts.Scroll.ScrollPage());
		}
	}
}
