using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enigma.Utils;

namespace Enigma.Components;

/// <summary>
/// Allows the user to configure the machine to direct the inputs of two keys into one another.The plugboard
/// supports up to 13 key-to-key mappings; one for each pair.If there were a connection on the plugboard between
/// the keys A and G, for instance, a keypress of G would be interpreted as an electrical signal from A, and vice
/// versa.
/// 
/// The plugboard is the first layer of encipherment in the Engima machine.
/// 
/// In the original machine, this mapping was represented by the presence of a wire that would plug into two
/// jacks (each beneath the two target letters).
/// </summary>
internal class Plugboard
{
    // define key mappings
    private Map<char, char> _mappings = new Map<char, char>();

    // create a method to apply mapping
    public char GetMapping(char character)
    {
        return _mappings[character];
    }

    public Plugboard(List<string> mappings)
    {
        foreach (string mapping in mappings)
        {
            if (mapping.Length != 2) { 
                throw new ArgumentException($"invalid plugboard mapping: {mapping}. Each mapping must be exactly 2 characters long.");
            }

        }
    }

}
