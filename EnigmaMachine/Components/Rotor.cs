using Enigma.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Components
{
    internal class Rotor
    {
        private Map<char, char> mappings;
        private int position;
        public void Step()
        {
            if (position == mappings.Length - 1)
            {
                position = 0;
            }
            else
            {
                position++;
            }
        }

        public Rotor(Map<char, char> mappings, int position)
        {
            this.mappings = mappings;
            this.position = position;
        }
    }
}
