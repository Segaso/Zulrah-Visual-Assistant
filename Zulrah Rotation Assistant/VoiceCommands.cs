﻿using System.Speech.Recognition;

namespace Zulrah_Rotation_Assistant {
    class VoiceCommands {
        private SpeechRecognitionEngine SpeechEngine;

        /*
            SpeechSynth.SetOutputToDefaultAudioDevice();

            var Language = new CultureInfo("en-us");

            SpeechEngine = new SpeechRecognitionEngine(Language);
            SpeechEngine.SetInputToDefaultAudioDevice();
            SpeechEngine.SpeechRecognized += SpeechEngine_SpeechRecognized;

            var Commands = new Choices();

            Commands.Add("Speech Off");
            Commands.Add("Speech On");
            Commands.Add("Next");
            Commands.Add("Reset");
            Commands.Add("Blue");
            Commands.Add("Red");
            Commands.Add("Green");
            Commands.Add("Top");

            var GramarCommands = new GrammarBuilder();
            GramarCommands.Append(Commands);

            SpeechEngine.LoadGrammarAsync(new Grammar(GramarCommands));
            SpeechEngine.RecognizeAsync(RecognizeMode.Multiple);
            */
    }
}
