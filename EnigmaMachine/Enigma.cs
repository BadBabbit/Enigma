using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Enigma.Components;


namespace Enigma;

/// <summary>
/// initialises and manages the overall state of the Enigma machine
///</summary>
internal class Enigma
{
    private Plugboard plugboard;
    private List<Rotor> rotors;
    private Reflector reflector;


    /// <summary>
    /// initializes a new instance of the <see cref="Enigma"/> class using config file settings
    /// </summary>
    public Enigma()
    {
        // load plugboard settings from config file and initialize plugboard

        // load rotor settings from config file and initialize rotors

        // load reflector settings from config file and initialize reflector
    }
}
