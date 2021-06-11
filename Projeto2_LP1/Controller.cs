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
        /// <param name="steps">Steps od distance to generate a rock</param>
        public void Run(View view, string steps)
        {
            RandomizeField(map);

            ComparerRockPositions(map,steps);

            view.Show(map);

            

        }

        /// <summary>
        /// Method to make the entire field with radom spots to rocks and ground
        /// </summary>
        /// <param name="map"></param>
        public void RandomizeField(GameMap[,] map)
        {
            foreach(GameMap element in map)
            {
                Random rnd = new Random();
                int aux = rnd.Next(1,2);
                if(aux == 1)
                {
                    element.ChangeToRock();
                }

            }
        }

        private void ComparerRockPositions(GameMap[,] map, string steps)
        {

        }


    }
}