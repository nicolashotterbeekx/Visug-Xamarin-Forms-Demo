using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisugDemo.Controls;
using Xamarin.Forms;

namespace VisugDemo.Controls
{
    public partial class MyCustomEntryWrapper : StackLayout
    {
        public static readonly BindableProperty PlaceholderProperty =
            BindableProperty.Create<MyCustomEntryWrapper, string>(
                p => p.Placeholder,
                "",
                BindingMode.TwoWay,
                null,
                null,
                null,
                null);


        public string Placeholder
        {
            get { return (string)GetValue(PlaceholderProperty); }
            set { SetValue(PlaceholderProperty, value); }
        }

        public static readonly BindableProperty TextProperty =
            BindableProperty.Create<MyCustomEntryWrapper, string>(
                p => p.Text,
                "",
                BindingMode.TwoWay,
                null);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }


        public MyCustomEntryWrapper()
        {
            InitializeComponent();
            LblEntry.BindingContext = this;
            lblPlaceholder.BindingContext = this;  
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            if (Device.OS != TargetPlatform.WinPhone)
            {
                LblEntry.Placeholder = Placeholder;                
            }
            else
            {
                LblEntry.IsPassword = false;
            }            
        }               
    }
}
