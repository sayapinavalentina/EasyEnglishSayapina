﻿using System;
using Android.Content;
using Android.Content.Res;
using Android.Support.Design.Widget;
using EasyEnglishSayapina.Controls;
using EasyEnglishSayapina.Droid.Renderers;
using EasyEnglishSayapina.Droid.Utils;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(FormsFloatingActionButton), typeof(FormsFloatingActionButtonRenderer))]
namespace EasyEnglishSayapina.Droid.Renderers
{
    public class FormsFloatingActionButtonRenderer : Xamarin.Forms.Platform.Android.AppCompat.ViewRenderer<FormsFloatingActionButton, FloatingActionButton>
    {
        private FloatingActionButton _floatingActionButton;

        public FormsFloatingActionButtonRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<FormsFloatingActionButton> e)
        {
            base.OnElementChanged(e);

            if (e.NewElement != null)
            {
                _floatingActionButton = new FloatingActionButton(Context);
                _floatingActionButton.UseCompatPadding = true;
                ConfigureBackgroundColor();
                ConfigureImage();
                _floatingActionButton.Click += OnFabClick;

                SetNativeControl(_floatingActionButton);
            }
        }

        private void ConfigureBackgroundColor()
        {
            if (Element == null)
                return;

            var floatingActionButtonColor = Element.BackgroundColor.ToAndroid();
            _floatingActionButton.BackgroundTintList = ColorStateList.ValueOf(floatingActionButtonColor);
            Element.BackgroundColor = Color.Transparent;
        }

        private void ConfigureImage()
        {
            if (Element == null)
                return;

            var fileName = (Element.ImageSource as FileImageSource)?.File;
            if (fileName == null)
                return;

            var resourceId = ResourceUtil.GetDrawableIdByFileName(fileName, Context);
            _floatingActionButton.SetImageResource(resourceId);
        }

        private void OnFabClick(object sender, EventArgs e)
        {
            Element?.Command?.Execute(null);
        }
    }
}
