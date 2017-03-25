using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            SoundEmitter wistle = new SoundEmitter();
            int frequency;
            int seconds;

            while (true) 
            {
                Console.Clear();
                Console.Write("Sound Frequency (Hertz): ");

                //If frequency input does not successfully convert to an 
                //int, return to the beginning the the loop to ask again.

                if (Int32.TryParse(Console.ReadLine().Trim(), out frequency) == false)
                {
                    continue;
                }
                else
                {
                    wistle.Hz = frequency;
                }
                
                while (true)
                {
                    Console.Clear();
                    Console.Write("Duration (seconds): ");

                    //If time input successfully converts to an int, break out of loop.

                    if (Int32.TryParse(Console.ReadLine().Trim(), out seconds) != false)
                    {
                        wistle.Seconds = seconds;
                        break;
                    }
                }

                Console.Clear();
                wistle.EmitSound();
            }
        }
    }
}
