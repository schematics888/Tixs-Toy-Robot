using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.Board.Interface;
using TixsToyRobot.ConsoleInput;
using TixsToyRobot.ConsoleInput.Interface;
using TixsToyRobot.Robot;
using TixsToyRobot.Robot.Interface;

namespace TixsToyRobot.ToyEngine
{

    public class ToyRobotEngine
    {
        public ITableTop TableTop { get; set; }
        private IRobot TRobot;
        private IInputParser PInput;

        public ToyRobotEngine(ITableTop tableTop)
        {
            TableTop = tableTop;
            TRobot = new TRobot();
            PInput = new InputParser();
        }

        public string ProcessCommand(string[] input)
        {
            var command = PInput.ParseCommand(input);
            if (command != Command.Place && TRobot.Position == null) return string.Empty;

            switch (command)
            {
                case Command.Place:
                    var placeCommandParameter = PInput.CommandParameter(input);
                    if (TableTop.IsValidPosition(placeCommandParameter.Position))
                        TRobot.Place(placeCommandParameter.Position, placeCommandParameter.Direction);
                    break;
                case Command.Move:
                    var newPosition = TRobot.GetNextPosition();
                    if (TableTop.IsValidPosition(newPosition))
                    { 
                        TRobot.Position = newPosition;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Careful on the edge on the table...");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                    break;
                case Command.Left:
                    TRobot.RotateLeft();
                    break;
                case Command.Right:
                    TRobot.RotateRight();
                    break;
                case Command.Report:
                    return GetReport();
            }
            return string.Empty;
        }

        public string GetReport()
        {
            return string.Format("Output: {0},{1},{2}", TRobot.Position.X,
                TRobot.Position.Y, TRobot.Direction.ToString().ToUpper());
        }


    }
}
