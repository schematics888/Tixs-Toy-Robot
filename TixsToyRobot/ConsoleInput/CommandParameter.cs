using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.ToyEngine;

namespace TixsToyRobot.ConsoleInput
{
    public class CommandParameter
    {
        public Position Position { get; set; }
        public Direction Direction { get; set; }

        public CommandParameter(Position position, Direction direction)
        {
            Position = position;
            Direction = direction;
        }


    }
}
