using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.Board.Interface;
using TixsToyRobot.ToyEngine;

namespace TixsToyRobot.Board
{
    public class TableTop : ITableTop
    {
        public TableTop(int rows, int cols)
        {
            this.iRows = rows;
            this.iCols = cols;
        }

        public int iRows { get; set; }
        public int iCols { get; set; }

        public bool IsValidPosition(Position position)
        {
            return position.X <= iCols && position.X >= 0 &&
                   position.Y <= iRows && position.Y >= 0;
        }
    }
}
