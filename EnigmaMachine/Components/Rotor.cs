using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigma.Components
{
    internal class Rotor
    {
        private Dictionary<Char, Char> mappings;
        private int position;
        public void Step()
        {
            if (position == mappings.Keys.Count - 1)
            {
                position = 0;
            }
            else
            {
                position++;
            }
        }

        public Rotor(Dictionary<Char, Char> mappings, int position)
        {
            this.mappings = mappings;
            this.position = position;
        }
    }
}
