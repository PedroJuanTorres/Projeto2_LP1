using System;

namespace Projeto2_LP1
{
    class Program
    {
        static void Main(string[] args)
        {
            GameMap[,] map = new GameMap [10 ,10];

            Controller controller = new Controller (map);

            View view = new View(controller, map);

            controller.Run(view, args[0], args[1], args[2]);

        }
    }
}
