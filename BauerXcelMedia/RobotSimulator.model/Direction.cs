using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BauerXcel.Media.RobotSimulator.common.EnumTypes;

namespace BauerXcel.Media.RobotSimulator.model
{
    /// <summary>
    /// This class encapsulates the direction of toy robot's movement
    /// </summary>
    public class Direction
    {
        private static IDictionary<int, Facing> mapDirection = new Dictionary<int, Facing>();
        private int _directionIndex;
        internal Facing _facing;

        static Direction()
        {
            foreach (var direction in Enum.GetValues(typeof(Facing)))
            {
                mapDirection.Add((int)direction, (Facing)direction);
            }
        }

        private Direction(int direction)
        {
            _directionIndex = direction;
        }

        private Facing Rotate(int step)
        {
            int newIndex = (_directionIndex + step) < 0 ? mapDirection.Count - 1 : (_directionIndex + step) % mapDirection.Count;
            return Direction.CourseOf(newIndex);
        }

        public static Facing CourseOf(int directionNumber)
        {
            return mapDirection[directionNumber];
        }

        /// <summary>
        /// Returns the direction on the left of the current position
        /// </summary>
        /// <returns></returns>
        public Facing LeftDirection()
        {
            return Rotate(-1);
        }

        /// <summary>
        /// Returns the direction on the right of the current position
        /// </summary>
        /// <returns></returns>
        public Facing RightDirection()
        {
            return Rotate(1);
        }
    }
}
