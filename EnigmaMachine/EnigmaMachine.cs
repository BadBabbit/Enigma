using System;
using Enigma.Components;

namespace Enigma
{
    public class EnigmaMachine
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a key:");
            Keyboard keyboard = new Keyboard();
            while (true)
            {
                Keyboard.Input input = keyboard.GetSingleKeyInput();
                Console.Write(input.Key);
                if (input.Terminator) break;
            }
        }
    }
}
