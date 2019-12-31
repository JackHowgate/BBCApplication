using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCGameOfLife
{
    class Cell
    {
        public bool alive { get; set; }

        public Cell(bool isAlive)
        {
            alive = isAlive;
        }
    }
}
