using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace SmartGarbage
{
    class voiceSynthesizer
    {
        public void Synthesizer(int parameter) {
            // Configurando o sintetizador
            SpeechSynthesizer synth = new SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            synth.Rate = 0;
            synth.Volume = 100;
            
            // Verificando as vozes disponíveis no Windows (selecionado uma em pt-BR, se tiver)
            // Se comentar este try, funciona normalmente (com a voz padrão do windows)
            try
            {
                Console.WriteLine("Voices: " + synth.GetInstalledVoices().Count);

                foreach (var v in synth.GetInstalledVoices().Select(v => v.VoiceInfo))
                {
                    Console.WriteLine("Name:{0}, Gender:{1}, Age:{2}, Culture: {3}", v.Name, v.Gender, v.Age, v.Culture);
                    if (v.Culture.Name.Equals("pt-BR"))
                    {
                        synth.SelectVoice(v.Name);
                        Console.WriteLine("Selected Voice: (" + v.Culture + ") " + v.Name);
                    }
                }
            }
            catch (Exception e) { }

            switch (parameter)
            {
                case 1: synth.Speak("texto que será falado, se 1..."); break;
                case 2: synth.Speak("texto que será falado, se 2..."); break;
                case 3: synth.Speak("texto que será falado, se 3..."); break;
            }
        }
    }
}
