using System;
using Android.Widget;
using VideoPlaerDemons;
using VideoPlayerDemos.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(RenderEntry), typeof(RenderDroid))]

namespace VideoPlayerDemos.Droid
{
    [Obsolete] 
    public class RenderDroid : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.White);
                Control.SetTextColor(global::Android.Graphics.Color.Black);
                Control.SetText("From Droid", TextView.BufferType.Normal);
            }
        }
    }
}