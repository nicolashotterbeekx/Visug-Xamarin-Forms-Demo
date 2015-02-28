using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using VisugDemo.Contracts;
using VisugDemo.WinPhone.Helpers;
using Microsoft.Practices.Unity;

namespace VisugDemo.WinPhone
{
    public partial class MainPage : global::Xamarin.Forms.Platform.WinPhone.FormsApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

            global::Xamarin.Forms.Forms.Init();
            RegisterTypes();
            LoadApplication(new VisugDemo.App());
        }

        private void RegisterTypes()
        {
            VisugDemo.App.Container.RegisterType<ITextToSpeech, TextToSpeech>();
        }
    }
}
