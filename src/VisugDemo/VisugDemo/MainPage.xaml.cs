using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.Unity;
using VisugDemo.Contracts;
using VisugDemo.ViewModels;
using Xamarin.Forms;

namespace VisugDemo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            BindingContext = App.Container.Resolve<MainViewModel>(new ParameterOverride("navigation", this.Navigation));            
            InitializeComponent();
            
        }

        private MainViewModel ViewModel
        {
            get { return BindingContext as MainViewModel; }
        }

        void Button_Clicked(object sender, EventArgs e)
        {
            //DisabledButton.IsEnabled = !DisabledButton.IsEnabled;
            ViewModel.IsEnabled = !ViewModel.IsEnabled;
            var test = App.Container.Resolve<ITextToSpeech>();
            test.Speak("Hi Visug, how are you doing today?");
        }


    }
}
