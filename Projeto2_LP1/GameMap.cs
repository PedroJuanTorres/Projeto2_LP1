using System;

namespace Projeto2_LP1
{
    /// <summary>
    /// Map of the game
    /// </summary>
    class GameMap
    {
        //Coordinate in x
        private int x;

        //Coordinate in y
        private int y;

        //Symbol that is pn that x,y coordinate
        private char symbol;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="x_limit">Size of the matrix in x</param>
        /// <param name="y_limit">Size of the matrix in y</param>
        public GameMap(int x_limit, int y_limit)
        {
            x = x_limit;
            y = y_limit;
            symbol = '.';
        }
        
        public void ChangeToRock()
        {
            symbol = '#';
        }

        public void ChangeToGround()
        {
            symbol = '.';
        }
        public char GetSymbol()
        {
            return symbol;
        }


    }
}