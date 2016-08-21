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
        private int _rows;
        private int _columns;

        public GridCell(int rows, int columns)
        {
            this._rows = rows;
            this._columns = columns;
        }

        public bool isValidPosition(Position position)
        {
            return !(position.GetX() > _columns || position.GetX() < 0 || position.GetY() > _rows || position.GetY() < 0);
        }
    }
}
