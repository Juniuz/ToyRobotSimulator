using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BauerXcel.Media.RobotSimulator.model;
using BauerXcel.Media.RobotSimulator.common.EnumTypes;

namespace ToyRobotUnitTest
{
    [TestClass]
    public class ToyRobotTests
    {
        #region Toy robot test cases for placing and movement
        [TestMethod]
        public void Robot_Cannot_Be_Placed()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            var result = toyRobot.Location(-1, 0, Facing.East);

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual("Toy robot cannot be placed in East", toyRobot.ErrorMessage);

            //Act
            result = toyRobot.Location(3, 5, Facing.East);

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual("Toy robot cannot be placed in East", toyRobot.ErrorMessage);
        }

        [TestMethod]
        public void Robot_Not_Placed_But_Cannot_Move() 
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            var result = toyRobot.Move();

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual("Until it hasn't been placed, toy robot cannot move", toyRobot.ErrorMessage);
        }

        [TestMethod]
        public void Robot_Not_Placed_But_Cannot_Turn()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            var result = toyRobot.TurnLeft();

            //Assert
            Assert.AreEqual("Until it hasn't been placed, toy robot cannot turn", toyRobot.ErrorMessage);
        }
        #endregion


        #region Toy robot test cases for movement and position
        [TestMethod]
        public void Robot_Not_Placed_Cannot_Report_Position()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            var result = toyRobot.Report();

            //Assert
            Assert.AreEqual("", result);
            Assert.AreEqual("Until it hasn't been placed, toy robot cannot report its position", toyRobot.ErrorMessage);
        }

        [TestMethod]
        public void Robot_Placed_Can_Report_Position()
        {
            //Arrange
            var toyRobot = new ToyRobot();
            var result = toyRobot.Location(2, 4, Facing.West);
            var report = toyRobot.Report();

            //Assert
            Assert.IsTrue(result);
            Assert.AreEqual("", toyRobot.ErrorMessage);
            Assert.AreEqual("2,4,WEST", report);
        }

        [TestMethod]
        public void Robot_Placed_Can_Report_Correct_Position()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            toyRobot.Location(1, 1, Facing.North);
            toyRobot.Move();

            //Assert
            Assert.AreEqual("1,2,NORTH", toyRobot.Report());
        }

        [TestMethod]
        public void Robot_Placed_And_Turned_Left_Report_Correct_Position()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            toyRobot.Location(1, 1, Facing.South);
            toyRobot.TurnLeft();

            //Assert
            Assert.AreEqual("1,1,SOUTH", toyRobot.Report());
        }

        [TestMethod]
        public void Robot_Placed_And_Turned_Right_Report_Correct_Position()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            toyRobot.Location(1, 1, Facing.East);
            toyRobot.TurnRight();

            //Assert
            Assert.AreEqual("1,1,EAST", toyRobot.Report());
        }

        [TestMethod]
        public void Robot_Placed_And_Moved_Report_Correct_Position()
        {
            //Arrage
            var toyRobot = new ToyRobot();

            //Act
            toyRobot.Location(1, 1, Facing.North);
            toyRobot.Move();

            //Assert
            Assert.AreEqual("2,3,NORTH", toyRobot.Report());
        }

        [TestMethod]
        public void Robot_Placed_Moved_And_Turned_Report_Correct_Position()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            toyRobot.Location(4, 5, Facing.West);
            toyRobot.Move();
            toyRobot.Move();
            toyRobot.TurnLeft();
            toyRobot.Move();

            //Assert
            Assert.AreEqual("4,5,WEST", toyRobot.Report());
        }
        #endregion
    }
}
