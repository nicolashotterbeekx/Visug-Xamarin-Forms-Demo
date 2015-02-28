using System;
using System.Collections.Generic;
using System.Linq;
using Android.Speech.Tts;
using VisugDemo.Contracts;
using Xamarin.Forms;


namespace VisugDemo.Droid.Helpers
{
    public class TextToSpeech : Java.Lang.Object, ITextToSpeech, Android.Speech.Tts.TextToSpeech.IOnInitListener
    {
        private Android.Speech.Tts.TextToSpeech speaker;
        private string toSpeak;

        public TextToSpeech()
        {
        }

        public void Speak(string text)
        {
            var ctx = Forms.Context; // useful for many Android SDK features
            toSpeak = text;
            if (speaker == null)
            {
                speaker = new Android.Speech.Tts.TextToSpeech(ctx, this);
            }
            else
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

        #region IOnInitListener implementation

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
            {
                var p = new Dictionary<string, string>();
                speaker.Speak(toSpeak, QueueMode.Flush, p);
            }
        }

        #endregion
    }
}