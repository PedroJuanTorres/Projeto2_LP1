using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Class to make the logic of the program
    /// </summary>
    class Controller
    {
        //map of the program
        private GameMap[,] map;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="map">map of the program</param>
        public Controller(GameMap[,] map)
        {
            this.map = map;
        }

        /// <summary>
        /// Method to run yhe project
        /// </summary>
        /// <param name="view">View class</param>
        /// <param name="x_coordinate">Limit of x</param>
        /// <param name="y_coordinate">Limit of y</param>
        /// <param name="steps">Steps od distance to generate a rock</param>
        public void Run(View view, string x_coordinate, string y_coordinate, string steps)
        {

        }
    }
}