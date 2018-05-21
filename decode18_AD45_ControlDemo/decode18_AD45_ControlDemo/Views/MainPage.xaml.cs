using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace decode18_AD45_ControlDemo.Views
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void btnCustomEditor_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new CustomEditorPage(), true);
        }

        private async void btnVertionInfo_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new VersionInfoPage(), true);
        }

        private async void btnNoHighlightListViewPage_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new NoHighlightListViewPage(), true);
        }
    }
}
