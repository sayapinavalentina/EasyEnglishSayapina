using System;
using EasyEnglishSayapina.iOS.Renderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ImageButton), typeof(CustomImageButtonRenderer))]
namespace EasyEnglishSayapina.iOS.Renderers
{
    public class CustomImageButtonRenderer : ImageButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<ImageButton> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.AdjustsImageWhenHighlighted = false;
            }
        }

        protected override UIButton CreateNativeControl()
        {
            return new UIButton(UIButtonType.Custom);
        }
    }
}
