using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.ToyEngine;

namespace TixsToyRobot.ConsoleInput.Interface
{
    public interface IInputParser
    {
        // Interface to process the raw input from the user.
        Command ParseCommand(string[] rawInput);

        // This extracts the parameters from the user's input.        
        CommandParameter CommandParameter(string[] input);
    }

}
