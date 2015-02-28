using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Phone.Speech.Synthesis;
using VisugDemo.Contracts;

namespace VisugDemo.WinPhone.Helpers
{
    public class TextToSpeech : ITextToSpeech
    {
        public TextToSpeech() { }

        public async void Speak(string text)
        {
            SpeechSynthesizer synth = new SpeechSynthesizer();
            await synth.SpeakTextAsync(text);
        }
    }
}
