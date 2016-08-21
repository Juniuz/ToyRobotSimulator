using BauerXcel.Media.RobotSimulator.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator.Interface
{
    public interface IGrid
    {
        bool isValidPosition(Position position);
    }
}
