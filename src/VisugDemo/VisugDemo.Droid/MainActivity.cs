using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using VisugDemo.Contracts;
using Microsoft.Practices.Unity;
using VisugDemo.Droid.Helpers;
using VisugDemo.ViewModels;


namespace VisugDemo.Droid
{
    [Activity(Label = "VisugDemo", Icon = "@drawable/icon", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            RegisterTypes();
            LoadApplication(new App());
        }

        private void RegisterTypes()
        {            
            App.Container.RegisterType<ITextToSpeech, TextToSpeech>();
        }
    }
}

