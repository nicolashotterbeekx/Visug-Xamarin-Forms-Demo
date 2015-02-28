using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisugDemo.Controls;
using VisugDemo.WinPhone.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

[assembly: ExportRenderer(typeof(MyCustomTabbedPage), typeof(MyCustomTabbedPageRenderer))]
namespace VisugDemo.WinPhone.Renderers
{
    class MyCustomTabbedPageRenderer : TabbedPageRenderer
    {
        public override void OnApplyTemplate()
        {

            this.Style = App.Current.Resources["PivotStyle"] as System.Windows.Style;
            this.HeaderTemplate = App.Current.Resources["PivotHeaderTemplate"] as System.Windows.DataTemplate;
            base.OnApplyTemplate();
        }
    }
}
