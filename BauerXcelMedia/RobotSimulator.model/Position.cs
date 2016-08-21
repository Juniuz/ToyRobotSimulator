using BauerXcel.Media.RobotSimulator.common.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator.model
{
    /// <summary>
    /// This class encapsulates the position of the toy robot
    /// </summary>
    public class Position
    {
        internal int X { get; set; }
        internal int Y { get; set; }
        internal Direction direction { get; set; }

        public Position(Position position)
        {
            X = position.GetX();
            Y = position.GetY();
            direction = position.GetDirection();
        }

        public Position(int x, int y, Direction course)
        {
            X = x;
            Y = y;
            direction = course;
        }

        public int GetX()
        {
            return X;
        }

        public int GetY() 
        {  
            return Y;
        }

        public Direction GetDirection() 
        {
            return direction;
        }

        public void SetDirection(Direction course)
        {
            direction = course;
        }

        public void Change(int x, int y)
        {
            X = X + x;
            Y = Y + y;
        }

        public Position GetNextPosition()
        {
            if (direction == null)
                throw new ArgumentNullException("Toy robot direction is invalid!");

            //the new position to validate
            Position newPosition = new Position(this);

            switch (direction._facing)
            {
                case Facing.North:
                    newPosition.Change(0, 1);
                    break;
                case Facing.East:
                    newPosition.Change(1, 0);
                    break;
                case Facing.South:
                    newPosition.Change(0, -1);
                    break;
                case Facing.West:
                    newPosition.Change(-1, 0);
                    break;
                default:
                    break;
            }
            return newPosition;
        }
    }
}
