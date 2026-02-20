using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Enigma.Components;
using Enigma.Utils;


namespace Enigma;

/// <summary>
/// initialises and manages the overall state of the Enigma machine
///</summary>
internal class EnigmaMachine
{
    private Plugboard plugboard;
    private List<Rotor> rotors;
    private Reflector reflector;


    /// <summary>
    /// initializes a new instance of the <see cref="EnigmaMachine"/> class using config file settings
    /// </summary>
    public EnigmaMachine()
    {
        MachineConfig config = MachineConfig.Instance;
        plugboard = new Plugboard(config.Plugboard);
        rotors = new List<Rotor>();

        // load rotor positions from config. for each rotor position, grab name and load definition as a map
        foreach (RotorPosition position in config.Rotors.rotorPositions)
        {
            Map<char, char> map = new Map<char, char>(config.Rotors.definitions[position.rotor]);
            Rotor rotor = new Rotor(map, position.position);
            rotors.Add(rotor);
        }
        // load plugboard settings from config file and initialise plugboard

        // load rotor settings from config file and initialize rotors

        // load reflector settings from config file and initialize reflector
    }
}
