using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Components
{
    /// <summary>
    /// 
    /// </summary>
    internal class Keyboard
    {

        /// <summary>
        /// This class represents a single keystroke input. Defines behaviour for whether or not a given
        /// key should be encrypted via the machine.
        /// </summary>
        /// <param name="key">The value of the keystroke.</param>
        /// <param name="encipher">Whether the key should be enciphered through the machine.</param>
        /// <param name="terminator">Whether this key represents the end of the input stream.</param>
        public class Input(char key, bool encipher, bool terminator)
        {
            private readonly char _key = key;
            /// <summary>
            /// Getter for Key property.
            /// </summary>
            public char Key {
                get { return _key; }
            }

            private readonly bool _encrypt = encipher;
            /// <summary>
            /// Getter for Encrypt property.
            /// </summary>
            public bool Encrypt
            {
                get { return _encrypt; }
            }

            private readonly bool _terminator = terminator;
            /// <summary>
            /// Getter for Terminator property.
            /// </summary>
            public bool Terminator
            {
                get { return _terminator; }
            }

        }
        public Keyboard() { }
        
        public Input GetSingleKeyInput()
        {
            ConsoleKeyInfo cki = Console.ReadKey(true);
            char key = Char.ToUpper(cki.KeyChar);
            bool terminator = cki.Key == ConsoleKey.Enter;
            return new Input(key, Char.IsLetter(key), terminator);
        }
    }
}
    