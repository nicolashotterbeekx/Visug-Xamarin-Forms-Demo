using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VisugDemo.Controls
{
    public class MyCustomEntry : Entry
    {
        public static readonly
        BindableProperty BorderColorProperty =
            BindableProperty.Create<MyCustomEntry, Color>(p => p.BorderColor, Color.Black);

        public Color BorderColor
        {
            get { return (Color)base.GetValue(BorderColorProperty); }
            set { base.SetValue(BorderColorProperty, value); }
        }

        public static readonly
        BindableProperty BorderThicknessProperty =
            BindableProperty.Create<MyCustomEntry, int>(p => p.BorderThickness, 0);

        public int BorderThickness
        {
            get { return (int)base.GetValue(BorderThicknessProperty); }
            set { base.SetValue(BorderThicknessProperty, value); }
        }
    }
}
