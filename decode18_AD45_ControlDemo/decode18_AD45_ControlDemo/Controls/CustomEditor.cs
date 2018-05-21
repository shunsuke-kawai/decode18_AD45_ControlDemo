using Xamarin.Forms;

namespace decode18_AD45_ControlDemo.Controls
{
    public class CustomEditor : Editor
    {
        public static readonly BindableProperty BorderColorProperty =
            BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEditor), default(Color),
                propertyChanged: (bindable, oldValue, newValue) =>
                    ((CustomEditor)bindable).BorderColor = (Color)newValue);

        public Color BorderColor
        {
            get { return (Color)GetValue(BorderColorProperty); }
            set { SetValue(BorderColorProperty, value); }
        }
    }
}
