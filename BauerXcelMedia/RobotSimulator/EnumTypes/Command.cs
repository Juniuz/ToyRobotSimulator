using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator.EnumTypes
{
    /// <summary>
    /// Determines the instruction given to the toy robot
    /// </summary>
    public enum Command : byte
    {
        Invalid = 0,
        Place = 1,
        Left = 2,
        Right = 3,
        Move = 4,
        Report = 5
    }
}
