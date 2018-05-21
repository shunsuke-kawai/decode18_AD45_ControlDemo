
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace decode18_AD45_ControlDemo.Controls
{
    public class GrowImageGrid : Grid
    {
        /// <summary>
        /// 画像デフォルトスケール
        /// </summary>
        private double _defaultScale = 1.0;

        /// <summary>
        /// 画像拡大スケール
        /// </summary>
        public double GrowScale { get; set; } = 1.4;

        /// <summary>
        /// アニメーション時間(各動作毎)
        /// </summary>
        public int GrowLength { get; set; } = 75;

        /// <summary>
        /// アニメーション繰り返し
        /// </summary>
        public bool AfterAnimation { get; set; } = false;

        /// <summary>
        /// アニメーション追加済み
        /// </summary>
        private bool _addedAnimation;

        /// <summary>
        /// バインディング変更
        /// </summary>
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (_addedAnimation || GestureRecognizers.Count == 0) { return; }
            _addedAnimation = true;

            var tapGesture = GestureRecognizers[0] as TapGestureRecognizer;
            if (tapGesture == null) { return; }

            var images = this.Children.Where(n => n is Image).Cast<Image>();
            if (images.Count() == 0) { return; }

            tapGesture.Tapped += (sender, e) =>
            {
                Device.BeginInvokeOnMainThread(async () => await Grow(images));
            };
        }

        /// <summary>
        /// イメージ拡大アニメーション
        /// </summary>
        /// <param name="images"></param>
        /// <returns></returns>
        public async Task Grow(IEnumerable<Image> images)
        {
            foreach (var image in images)
            {
                try
                {
                    await image.ScaleTo(GrowScale, (uint)GrowLength);
                    await image.ScaleTo(_defaultScale, (uint)GrowLength);
                }
                catch
                {
                }

                if (AfterAnimation)
                {
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        try
                        {
                            image.ScaleTo(GrowScale, (uint)GrowLength).ContinueWith((task) =>
                            {
                                try
                                {
                                    image.ScaleTo(_defaultScale, (uint)GrowLength);
                                }
                                catch
                                {
                                }
                            },
                            scheduler: TaskScheduler.FromCurrentSynchronizationContext());
                        }
                        catch
                        {
                        }
                    });
                }
            }
        }
    }
}
