using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using Enigma.Components;
using Enigma;


namespace Enigma
{
    public class Enigma
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {

            ILogger logger = Logger.GetInstance();
            MachineConfig config = MachineConfig.Instance;
            logger.LogDebug($"Plugboard configuration:");
            foreach (string plugboardConnection in config.Plugboard)
            {
                logger.LogDebug($"\t{plugboardConnection}");
            }
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
