using BauerXcel.Media.RobotSimulator.common.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator.model
{
    /// <summary>
    /// This class encapsulates the position and movement of toy robot.
    /// </summary>
    public class ToyRobot
    {
        private int _posX;
        private int _postY;
        private Position _position;

        public string ErrorMessage { get; set; }

        public ToyRobot()
        {
        }

        public ToyRobot(Position position)
        {
            ErrorMessage = string.Empty;
            _position = position;
        }

        public bool Location(int x, int y, Facing position)
        {

            return true;
        }

        public bool Move()
        {
            return true;
        }

        /// <summary>
        /// Turns the toy robot 90 degress LEFT
        /// </summary>
        /// <returns>true if turned successfully, if not false</returns>
        public bool TurnLeft()
        {
            if (_position.direction == null)
                return false;

            _position.direction = _position.direction.LeftDirection();
            return true;
        }

        /// <summary>
        /// Turns the toy robot 90 degress RIGHT
        /// </summary>
        /// <returns>true if turned successfully, if not false</returns>
        public bool TurnRight()
        {
            if (_position.direction == null)
                return false;

            _position.direction = _position.direction.RightDirection();
            return true;
        }

        public bool Turn()
        {
            return true;
        }

        public string Report()
        {
            return "";
        }
    }
}
