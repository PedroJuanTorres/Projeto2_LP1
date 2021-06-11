using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Class to print on the screen
    /// </summary>
    class View
    {
        //Controller class
        private Controller controller;

        //map of the program
        private GameMap[,] map;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="controller">Controller class</param>
        /// <param name="map">map of the program</param>
        public View(Controller controller, GameMap[,] map)
        {
            this.controller = controller;
            this.map = map;
        }
    }
}