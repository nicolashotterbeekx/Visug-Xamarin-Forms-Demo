using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisugDemo.ViewModels;
using Xamarin.Forms;
using Microsoft.Practices.Unity;

namespace VisugDemo
{
    public partial class FifthPage : ContentPage
    {
        public FifthPage()
        {
            BindingContext = App.Container.Resolve<FifthViewModel>();
            InitializeComponent();
        }
    }
}
