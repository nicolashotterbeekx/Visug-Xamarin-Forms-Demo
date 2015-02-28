using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using VisugDemo.Controls;
using VisugDemo.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(MyCustomEntryRenderer))]
namespace VisugDemo.iOS.Renderers
{
    public class MyCustomEntryRenderer : EntryRenderer
    {        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                ;
                var _nativeTextField = (UITextField)Control;
                _nativeTextField.Layer.BorderColor = ((MyCustomEntry)Element).BorderColor.ToCGColor();
                _nativeTextField.Layer.BorderWidth = 1;
                _nativeTextField.Layer.MasksToBounds = true;
                //SetNativeControl(_nativeTextField);
            }
        }
    }
}