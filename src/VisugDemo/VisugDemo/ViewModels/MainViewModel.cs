using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VisugDemo.Contracts;
using Xamarin.Forms;

namespace VisugDemo.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private INavigation _navigation;        
        private ICommand _navigateCommand;

        public MainViewModel(INavigation navigation, ITextToSpeech speak)
        {
            IsEnabled = false;
            _navigation = navigation;            
        }


        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { SetProperty(ref _isEnabled, value);}
        }

        public ICommand NavigateCommand
        {
            get { return _navigateCommand ?? (_navigateCommand = new Command(async (page) => await ExecuteNavigateCommand(page))); }
        }

        private async Task ExecuteNavigateCommand(object page)
        {
            switch (page.ToString())
            {
                case "FirstPage":
                    await _navigation.PushAsync(new FirstPage());
                    break;
                case "SecondPage":
                    await _navigation.PushAsync(new SecondPage());
                    break;
                case "ThirdPage":
                    await _navigation.PushAsync(new ThirdPage());
                    break;
                case "FourthPage":
                    await _navigation.PushAsync(new FourthPage());
                    break;
                case "FifthPage":
                    await _navigation.PushAsync(new FifthPage());
                    break;
            }
            
        }
    }
}
