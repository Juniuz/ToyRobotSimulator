using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator
{
    /// <summary>
    /// The exception handler for the toy robot
    /// </summary>
    public class ToyRobotException: Exception
    {
        public ToyRobotException(string exception)
            : base(exception)
        {
        }
    }
}
