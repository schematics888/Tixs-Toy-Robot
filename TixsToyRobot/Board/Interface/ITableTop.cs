using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.ToyEngine;

namespace TixsToyRobot.Board.Interface
{
    public interface ITableTop
    {

        bool IsValidPosition(Position position);
    }
}
