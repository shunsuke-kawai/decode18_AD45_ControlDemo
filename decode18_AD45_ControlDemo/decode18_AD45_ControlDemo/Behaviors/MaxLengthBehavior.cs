using System.Linq;
using Xamarin.Forms;

namespace decode18_AD45_ControlDemo.Behaviors
{
    internal class MaxLengthBehavior : Behavior<Editor>
    {
        public int MaxLength { get; set; }

        protected override void OnAttachedTo(Editor editor)
        {
            editor.TextChanged += TextChanged;
        }

        protected override void OnDetachingFrom(Editor editor)
        {
            editor.TextChanged -= TextChanged;
        }

        internal void TextChanged(object sender, TextChangedEventArgs e)
        {
            // 入力制限文字数内なら OK
            if (e.NewTextValue?.Length <= MaxLength)
            {
                return;
            }
            // 入力制限文字数を越えていたら変更前の値に戻す
            if (e.OldTextValue?.Length <= MaxLength)
            {
                ((Editor)sender).Text = e.OldTextValue;
                return;
            }
            ((Entry)sender).Text = new string((e.OldTextValue ?? string.Empty).ToCharArray().Take(MaxLength).ToArray());
        }
    }
}
