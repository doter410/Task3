using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using VideoPlaerDemons;
using VideoPlayerDemos.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RenderEntry), typeof(RenderEntryIOS))]

namespace VideoPlayerDemos.iOS
{
    public class RenderEntryIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                Control.Layer.CornerRadius = 20;
                Control.Layer.BorderWidth = 3f;
                Control.Layer.BorderColor = Color.Black.ToCGColor();
                Control.Layer.BackgroundColor = Color.White.ToCGColor();

                Control.LeftView = new UIKit.UIView(new CGRect(0, 0, 10, 0));
                Control.LeftViewMode = UIKit.UITextFieldViewMode.Always;

            }
        }
    }
}