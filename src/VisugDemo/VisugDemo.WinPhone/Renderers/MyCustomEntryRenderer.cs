using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using Microsoft.Phone.Controls;
using VisugDemo.Controls;
using VisugDemo.WinPhone.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(MyCustomEntry), typeof(MyCustomEntryRenderer))]
namespace VisugDemo.WinPhone.Renderers
{
    public class MyCustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                //Get the element als MyCustomEntry to access the properties               
                MyCustomEntry entry = (MyCustomEntry)Element;

                var converter = new ColorConverter();

                //Get the native windows phone controle (PhoneTextBox)
                var nativeControl = (PhoneTextBox)Control.Children.FirstOrDefault(c => c is PhoneTextBox);

                if (nativeControl != null)
                {
                    nativeControl.BorderBrush = (SolidColorBrush) (converter.Convert(entry.BorderColor, null, null, null));
                    nativeControl.BorderThickness = new System.Windows.Thickness(entry.BorderThickness);
                }
                //nativeControl.Margin = new System.Windows.Thickness(0.0, -12.0, 0.0, -12.0);
            }

        }

        //override 
    }
}
