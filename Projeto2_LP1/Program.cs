using System;

namespace Projeto2_LP1
{
    class Program
    {
        /// <summary>
        /// Method that runs the program once the program is called
        /// </summary>
        /// <param name="args">arguments that the user has type on the comand line while called the program</param>
        static void Main(string[] args)
        {
            //Variable to create a matrix with dimensions x X y
            GameMap[,] map = new GameMap [Int32.Parse(args[0]),Int32.Parse(args[1])];

            //Variable to create a Controller, essential class to make a program on MVC format.(makes the logical part of yhe program)
            Controller controller = new Controller (map);

            //Variable to create a View, essential class to make a program on MVC format.(makes the print opn screen part of the program)
            View view = new View(controller, map);

            //Controller method to start the logic of the program
            controller.Run(view,args[2]);

        }
    }
}
