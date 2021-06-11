using System;

namespace Projeto2_LP1
{
    class GameMap
    {
        private int x;
        private int y;
        private char symbol;
        public GameMap(int x_limit, int y_limit)
        {
            x = x_limit;
            y = y_limit;
            symbol = '.';
        }
    }
}