using Android.Widget;
using decode18_AD45_ControlDemo.Droid.Effects;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(ListViewHasNoHighlightEffect), "ListViewHasNoHighlightEffect")]
namespace decode18_AD45_ControlDemo.Droid.Effects
{
    class ListViewHasNoHighlightEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            var listView = Control as AbsListView;

            if (listView == null) return;

            listView.SetSelector(Resource.Drawable.NoHighlightViewCellBackground);
        }

        protected override void OnDetached()
        {

        }
    }
}