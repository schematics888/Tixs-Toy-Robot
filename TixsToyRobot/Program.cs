
using TixsToyRobot.Board;
using TixsToyRobot.Board.Interface;
using TixsToyRobot.ToyEngine;


ITableTop Board = new TableTop(5, 5);
var toyEngine = new ToyRobotEngine(Board);

bool blnStopApplication = false;

do
{
    var command = Console.ReadLine();

    if (command == null) continue;

    //Exit Application
    if (command.Equals("EXIT")) 
    { 
        blnStopApplication = true; 
    } 
    //Clear Command in Console
    else if (command.Equals("CLEAR"))
    {
        Console.Clear();
    }
    else
    {
        try
        {
            var output = toyEngine.ProcessCommand(command.Split(' '));
            if (!string.IsNullOrEmpty(output))
                Console.WriteLine(output);
        }
        catch (ArgumentException exception)
        {
            Console.WriteLine(exception.Message);
        }
    }
} while (!blnStopApplication);