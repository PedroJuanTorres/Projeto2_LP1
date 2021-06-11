using System;

namespace Projeto2_LP1
{
    class View
    {
        private Controller controller;
        private GameMap[,] map;

        public View(Controller controller, GameMap[,] map)
        {
            this.controller = controller;
            this.map = map;
        }
    }
}