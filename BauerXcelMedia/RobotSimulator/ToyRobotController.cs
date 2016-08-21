using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauerXcel.Media.RobotSimulator.model;
using BauerXcel.Media.RobotSimulator.Interface;
using BauerXcel.Media.RobotSimulator.common.EnumTypes;

namespace BauerXcel.Media.RobotSimulator
{
    /// <summary>
    /// This class behaves as a controller for the toy robot simulator
    /// </summary>
    public class ToyRobotController
    {
        ToyRobot _robot;
        IGrid _gridCell;

        public ToyRobotController(ToyRobot robot, IGrid gridCell)
        {
            _gridCell = gridCell;
            _robot = robot;
        }

        /// <summary>
        /// Places the robot on the grid cell in position X, Y and facing NORTH, SOUTH, EAST or WEST
        /// </summary>
        /// <returns></returns>
        public bool PlaceToyRobot(Position position)
        {
            if (_gridCell == null)
                throw new ToyRobotException("Grid cell object is invalid!");

            if (position == null)
                throw new ToyRobotException("Position object is invalid!");

            if (position.GetDirection() == null)
                throw new ToyRobotException("Direction value is invalid!");

            // validate the position
            if (!_gridCell.isValidPosition(position))
                return false;

            // if position is valid then assign values to fields
            _robot.SetPosition(position);

            return true;
        }

        /// <summary>
        /// Returns the X, Y and Direction of the toy robot
        /// </summary>
        /// <returns></returns>
        public string Report()
        {
            if (_robot.GetPosition() == null)
                return null;

            return _robot.GetPosition().GetX() + ", " + _robot.GetPosition().GetY() + ", " + _robot.GetPosition().GetDirection().ToString();
        }

        /// <summary>
        /// Evaluates the input command for the toy robot
        /// </summary>
        /// <returns></returns>
        public string Eval(string inputString)
        {
            string[] args = inputString.Split(' ');

            //validate command
            Command command;
            try
            {
                command = Enum.GetValues(typeof(Command));
            }
            catch (Exception ex)
            {
                throw new ToyRobotException("That's an invalid command!");
            }

            if (command == Command.Place && args.Length < 2)
                throw new ToyRobotException("That's an invalid command!");

            //validate Place param
            string[] param;
            int x = 0;
            int y = 0;
            Facing commandDirection;

            if (command == Command.Place)
            {
                param = args[1].Split(',');
                try
                {
                    x = int.Parse(param[0]);
                    y = int.Parse(param[1]);
                    commandDirection = BauerXcel.Media.RobotSimulator.model.Direction.CourseOf(Convert.ToInt32(param[2]));
                }
                catch (Exception ex)
                {
                    throw new ToyRobotException("That's an invalid command!");
                }
            }

            string output;

            switch (command)
            {
                case Command.Place:
                    output = Convert.ToString(PlaceToyRobot(new Position(x, y, commandDirection)));
                    break;
                case Command.Left:
                    break;
                case Command.Right:
                    break;
                case Command.Move:
                    break;
                case Command.Report:
                    break;
                default:
                    break;
            }

            return output;
        }
    }
}
