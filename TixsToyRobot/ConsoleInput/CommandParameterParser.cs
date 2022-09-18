﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.ToyEngine;

namespace TixsToyRobot.ConsoleInput
{
    public class CommandParameterParser
    {
        // Number of parameters provided for "PLACE" Command. (X,Y,F)
        private const int ParameterCount = 3;

        // Number of raw input items expected from user.
        private const int CommandInputCount = 2;

        // Checks the toy's initial position and the direction it is going to be facing.
        public CommandParameter ParseParameters(string[] input)
        {
            Direction direction;
            Position position = null;

            // Checks that Place command is followed by valid command parameters (X,Y and F toy's face direction).
            if (input.Length != CommandInputCount)
                throw new ArgumentException("Incomplete command. Please ensure that the PLACE command is using format: PLACE X,Y,F");

            // Checks that three command parameters are provided for the PLACE command.   
            var commandParams = input[1].Split(',');
            if (commandParams.Length != ParameterCount)
                throw new ArgumentException("Incomplete command. Please ensure that the PLACE command is using format: PLACE X,Y,F");

            // Checks the direction which the toy is going to be facing.
            if (!Enum.IsDefined(typeof(Direction), (commandParams[commandParams.Length - 1]).ToUpper()))
            {   
                throw new ArgumentException("Invalid direction. Please select from one of the following directions: NORTH|EAST|SOUTH|WEST");
            }
            else
            {
                Enum.TryParse(commandParams[commandParams.Length - 1], true, out direction);
            }

            var x = Convert.ToInt32(commandParams[0]);
            var y = Convert.ToInt32(commandParams[1]);
            position = new Position(x, y);

            return new CommandParameter(position, direction);
        }
    }

}

