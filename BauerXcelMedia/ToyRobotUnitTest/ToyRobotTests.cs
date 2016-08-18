using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotSimulator.Model;
using BauerXcel.Media.RobotSimulator.EnumTypes;

namespace ToyRobotUnitTest
{
    [TestClass]
    public class ToyRobotTests
    {
        [TestMethod]
        public void Robot_Cannot_Be_Placed()
        {
            //Arrange
            var toyRobot = new ToyRobot();

            //Act
            var result = toyRobot.Location(-1, 0, Position.East);

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual("Toy robot cannot be placed in East", toyRobot.ErrorMessage);

            //Act
            result = toyRobot.Location(0, 1, Position.East);

            //Assert
            Assert.IsFalse(result);
            Assert.AreEqual("Toy robot cannot be placed in East", toyRobot.ErrorMessage);
        }

        [TestMethod]
        public void Robot_Not_Placed_But_Cannot_Move_() 
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
    }
}
