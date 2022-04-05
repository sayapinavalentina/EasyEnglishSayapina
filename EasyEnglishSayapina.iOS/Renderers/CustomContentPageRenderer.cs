using System;
using EasyEnglishSayapina.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ContentPage), typeof(CustomContentPageRenderer))]
namespace EasyEnglishSayapina.iOS.Renderers
{
    public class CustomContentPageRenderer : PageRenderer
    {
        public override bool PrefersStatusBarHidden()
        {
            return true;
        }
    }
}
