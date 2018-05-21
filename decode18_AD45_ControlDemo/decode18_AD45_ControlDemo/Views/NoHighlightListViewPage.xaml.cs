using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace decode18_AD45_ControlDemo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoHighlightListViewPage : ContentPage
    {
        public NoHighlightListViewPage()
        {
            InitializeComponent();

            var source = new List<string>
            {
                "AAAAA",
                "BBBBB",
                "CCCCC",
                "DDDDD",
                "EEEEE",
                "FFFFF",
            };

            lst1.ItemsSource = source;
            lst2.ItemsSource = source;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            (sender as ListView).SelectedItem = null;
        }
    }
}