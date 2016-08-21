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

        /// <summary>
        /// Moves the robot one unit forward in the direction it is currently facing
        /// </summary>
        /// <returns>true if moved successfully, otherwise false</returns>
        public bool Move(Position newPosition)
        {
            if (newPosition == null)
                return false;
            
            //change position
            _position = newPosition;
            return true;
        }

        /// <summary>
        /// Get the toy robot position
        /// </summary>
        /// <returns>Returns the toy robot position</returns>
        public Position GetPosition()
        {
            return _position;
        }

        /// <summary>
        /// Set the toy robot position
        /// </summary>
        /// <returns>true if set successfully, if not false</returns>
        public bool SetPosition(Position position)
        {
            if (position == null)
                return false;

            _position = position;
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

            //_position.direction = _position.direction.LeftDirection();
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

            //_position.direction = _position.direction.RightDirection();
            return true;
        }

        public string Report()
        {
            return "";
        }
    }
}
