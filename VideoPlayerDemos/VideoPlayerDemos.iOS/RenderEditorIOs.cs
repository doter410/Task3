using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using VideoPlayerDemons.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Editor), typeof(CustomEditorRenderer))]

namespace VideoPlayerDemons.iOS
{
    public class CustomEditorRenderer : EditorRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Editor> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Layer.BorderColor = UIColor.DarkGray.CGColor;
                Control.Layer.BorderWidth = 0.5f;
                Control.Layer.CornerRadius = 3f;
            }
        }
    }
}