using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCGameOfLife
{
    static class Rules
    {
        public const int minStayAlive = 2;
        public const int maxStayAlive = 3;
        public const int requiredForBirth = 3;
    }

    class GameOfLife
    {

        GameForm window;
        

        public GameOfLife(string seed)
        {
            window = new GameForm(seed);
            window.Show();

            
        }


    }
}
