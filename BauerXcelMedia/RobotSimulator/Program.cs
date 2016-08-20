using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotSimulator
{
    /// <summary>
    /// The main entry point of the application to play with our toy robot simulator
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DisplayIntro();

            Console.ReadLine();
        }

        private static void DisplayIntro()
        {
            Console.WriteLine("---------- Hello Toy Robot ----------");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("");
        }
    }
}
