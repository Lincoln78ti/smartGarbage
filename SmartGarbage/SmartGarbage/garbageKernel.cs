using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarbage
{
    class garbageKernel
    {
        static void Main(string[] args)
        {
            serialConfig readSerail = new serialConfig();
            voiceSynthesizer speech = new voiceSynthesizer();

            while (true) {
                int cmd = readSerail.Serial("COM3", 9600);

                if(cmd != 0)
                    speech.Synthesizer(cmd);
            }
        }
    }
}
