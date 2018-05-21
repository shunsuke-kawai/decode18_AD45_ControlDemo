using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using decode18_AD45_ControlDemo.Controls;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using decode18_AD45_ControlDemo.Droid.Renderers;
using Android.Graphics.Drawables;
using Android.Graphics;

[assembly: ExportRenderer(typeof(CustomEditor), typeof(CustomEditorRenderer))]
namespace decode18_AD45_ControlDemo.Droid.Renderers
{
    public class CustomEditorRenderer : EditorRenderer
    {

        public CustomEditorRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);
            var el = (CustomEditor)Element;
            var nativeEditText = (global::Android.Widget.EditText)Control;

            var shape = new ShapeDrawable(new Android.Graphics.Drawables.Shapes.RectShape());
            shape.Paint.Color = el.BorderColor.ToAndroid();
            shape.Paint.SetStyle(Paint.Style.Stroke);
            nativeEditText.Background = shape;
        }
    }
}