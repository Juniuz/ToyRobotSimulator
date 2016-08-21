using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BauerXcel.Media.RobotSimulator.model;
using BauerXcel.Media.RobotSimulator.common;
using BauerXcel.Media.RobotSimulator;

namespace RobotSimulator
{
    /// <summary>
    /// The main entry point of the application to play with our toy robot simulator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ToyRobot robot = new ToyRobot();
            GridCell gridCell = new GridCell(5, 5);
            ToyRobotController controller = new ToyRobotController(robot, gridCell);

            DisplayIntro();

            bool keepRunning = true;

            while (keepRunning)
            {
                string inputCommand = Console.ReadLine();
                if ("EXIT".Equals(inputCommand))
                {
                    keepRunning = false;
                }
                else
                {
                    try
                    {
                        string outputVal = controller.Eval(inputCommand);
                        Console.WriteLine(outputVal);
                    }
                    catch (ToyRobotException ex)
                    {
                        Console.WriteLine("Exception occurred: " + ex.Message);
                    }
                }
            }
        }

        private static void DisplayIntro()
        {
            Console.WriteLine("---------- Hello Toy Robot Simulator ----------");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Enter a command (valid commands are:)");
            Console.WriteLine("\\'PLACE X, Y, NORTH | SOUTH | EAST | WEST\\', MOVE, LEFT, RIGHT, REPORT or EXIT");
        }
    }
}
