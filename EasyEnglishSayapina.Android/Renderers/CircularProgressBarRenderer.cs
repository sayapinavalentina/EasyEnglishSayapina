﻿using System;
using Android.Content;
using Android.Content.Res;
using Android.Graphics.Drawables;
using EasyEnglishSayapina.Controls;
using EasyEnglishSayapina.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CircularProgressBar), typeof(CircularProgressBarRenderer))]
namespace EasyEnglishSayapina.Droid.Renderers
{
    // Implementação inspirada em https://www.tutorialspoint.com/how-to-create-circular-progressbar-in-android
    public class CircularProgressBarRenderer : ViewRenderer<CircularProgressBar, Android.Widget.ProgressBar>
    {
        private const int PROGRESS_MAX_VALUE = 100;

        public CircularProgressBarRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CircularProgressBar> e)
        {
            base.OnElementChanged(e);

            if (Control is null)
            {
                var nativeControl = new Android.Widget.ProgressBar(
                    Context,
                    null,
                    Android.Resource.Attribute.ProgressBarStyleHorizontal
                );

                nativeControl.SetBackground(GetCircularTrack(Element.TrackColor.ToAndroid()));
                nativeControl.ProgressDrawable = GetCircularProgress(Element.ProgressColor.ToAndroid());
                nativeControl.Max = PROGRESS_MAX_VALUE;
                nativeControl.Progress = GetProgress(Element.Progress);

                SetNativeControl(nativeControl);
            }
        }

        private Drawable GetCircularTrack(Android.Graphics.Color color)
        {
            var drawable = Context.GetDrawable(Resource.Drawable.circular_track_bar) as GradientDrawable;
            drawable.SetColor(ColorStateList.ValueOf(color));
            return drawable;
        }

        private Drawable GetCircularProgress(Android.Graphics.Color color)
        {
            var rotageDrawable = Context.GetDrawable(Resource.Drawable.circular_progress_bar) as RotateDrawable;

            var drawable = rotageDrawable.Drawable as GradientDrawable;
            drawable.SetColor(ColorStateList.ValueOf(color));

            return rotageDrawable;
        }

        private int GetProgress(double progress)
        {
            return Convert.ToInt32(
                Math.Floor(progress * PROGRESS_MAX_VALUE)
            );
        }
    }
}
