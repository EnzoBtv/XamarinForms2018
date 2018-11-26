using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App04_HistoriaXamarin.Master
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Menu : MasterDetailPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}
		private void GoToPerfil1(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Pages.Perfil1()) {BarBackgroundColor= Color.FromHex("#ffc926") };
			IsPresented = false;
		}
		private void GoToEmpresa(object sender, EventArgs args)
		{
			Detail = new NavigationPage(new Pages.Empresa()) { BarBackgroundColor = Color.FromHex("#ffc926") };
			IsPresented = false;
		}
	}
}