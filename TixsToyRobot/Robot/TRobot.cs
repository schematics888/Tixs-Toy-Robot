using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TixsToyRobot.Robot.Interface;
using TixsToyRobot.ToyEngine;


namespace TixsToyRobot.Robot
{
    public class TRobot : IRobot
    {
        public Direction Direction { get; set; }
        public Position Position { get; set; }

        // Sets the toy's position and direction.
        public void Place(Position position, Direction direction)
        {
            this.Position = position;
            this.Direction = direction;
        }

        public Position GetNextPosition()
        {
            var newPosition = new Position(Position.X, Position.Y);
            switch (Direction)
            {
                case Direction.NORTH:
                    newPosition.Y += 1;
                    break;
                case Direction.EAST:
                    newPosition.X += 1;
                    break;
                case Direction.SOUTH:
                    newPosition.Y -= 1;
                    break;
                case Direction.WEST:
                    newPosition.X -= 1;
                    break;
            }
            return newPosition;
        }

        public void Rotate(int rotationNumber)
        {

            var directions = (Direction[])Enum.GetValues(typeof(Direction));
            Direction updateDirection;
            if ((Direction + rotationNumber) < 0)
                updateDirection = directions[directions.Length - 1];
            else
            {
                var index = ((int)(Direction + rotationNumber)) % directions.Length;
                updateDirection = directions[index];
            }
            Direction = updateDirection;
        }

        public void RotateLeft()
        {

            Rotate(-1);
        
        }

        public void RotateRight()
        {

            Rotate(1);
        }
    }
}
