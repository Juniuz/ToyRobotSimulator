using BauerXcel.Media.RobotSimulator.common.EnumTypes;
using BauerXcel.Media.RobotSimulator.Interface;
using BauerXcel.Media.RobotSimulator.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BauerXcel.Media.RobotSimulator
{
    public class GridCell: IGrid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }

        public GridCell(int rows, int columns)
        {
            Rows = rows;
            Columns = columns;
        }

        public virtual bool isValidPosition(Position position)
        {
            return !(position.GetX() > Columns || position.GetX() < 0 || position.GetY() > Rows || position.GetY() < 0);
        }
    }
}
