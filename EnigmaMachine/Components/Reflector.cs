using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Components
{
    internal class Reflector
    {
        private char[] chars;
        private int position;
        public Reflector(string chars, int position)
        {
            this.chars = chars.ToCharArray();
            this.position = position;
        }
    }
}
