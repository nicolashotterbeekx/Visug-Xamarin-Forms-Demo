using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VisugDemo.Contracts;
using Xamarin.Forms;

namespace VisugDemo.ViewModels
{
    public class FifthViewModel : BaseViewModel
    {
        private ITextToSpeech _textToSpeech;
        private ICommand _speakCommand;

        public FifthViewModel(ITextToSpeech textToSpeech)
        {
            _textToSpeech = textToSpeech;
            Text = "Hi Visuug, how are you doing?";
        }

        public ICommand SpeakCommand
        {
            get { return _speakCommand ?? (_speakCommand = new Command(async () => await ExecuteSpeakCommand())); }
        }

        private async Task ExecuteSpeakCommand()
        {
            await Task.Run(() =>_textToSpeech.Speak(Text));
        }

        private string _text;

        public string Text
        {
            get { return _text; }
            set { SetProperty(ref _text, value);}
        }
    }
}
