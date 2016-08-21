using BauerXcel.Media.RobotSimulator.common.EnumTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator.model
{
    /// <summary>
    /// This class define the structure of toy robot.
    /// </summary>
    public class ToyRobot
    {
        private int _posX;
        private int _postY;

        public string ErrorMessage { get; set; }

        public ToyRobot()
        {
            ErrorMessage = string.Empty;
        }

        public bool Location(int x, int y, Facing position)
        {

            return true;
        }

        public bool Move()
        {
            return true;
        }

        public bool TurnLeft()
        {
            return true;
        }

        public bool TurnRight()
        {
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
