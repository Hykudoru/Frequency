using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency
{
    public class SoundEmitter
    {
        private static int minHz = 37;
        private static int maxHz = 32767;

        private int hz;
        public int Hz
        {
            get { return hz; }
            set
            {
                hz = value;
                if (hz > maxHz)
                {
                    hz = maxHz;
                }
                else if (hz < minHz)
                {
                    hz = minHz;
                }
            }
        }

        private int sec;
        public int Seconds
        {
            get { return sec; }
            set
            {
                sec = value * 1000;
                if (sec <= 0)
                {
                    sec = 1;
                }
            }
        }

        public SoundEmitter() { }

        public SoundEmitter(int frequency, int seconds)
        {
            Hz = frequency;
            Seconds = seconds;
        }

        public void EmitSound()
        {
            Console.WriteLine("{0}Hz", Hz);
            Console.Beep(Hz, Seconds);
        }
    }
}
