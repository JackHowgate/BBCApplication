using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBCGameOfLife
{
    class Grid
    {
        List<List<Cell>> xy = new List<List<Cell>>();

        //Generates an initial grid of a specified size based on the specified seed code
        public Grid(string seed, int xDim, int yDim) 
        {
            char[] splitSeed = seed.ToCharArray();
            int seedVal = 0;
            for(int i = 0; i < xDim; i++)
            {
                xy.Add(new List<Cell>());
                for(int j = 0; j < yDim; j++)
                {
                    try
                    {
                        if (int.Parse(splitSeed[seedVal].ToString()) > 0)
                        {
                            xy[i].Add(new Cell(true));
                        }
                        else
                        {
                            xy[i].Add(new Cell(false));
                        }
                    }
                    catch
                    {
                        xy[i].Add(new Cell(false));
                    }
                    if(seedVal >= splitSeed.Length)
                    {
                        seedVal = 0;
                    }
                    else
                    {
                        seedVal++;
                    }
                }
            }
        }

        //Loops through all cells in the grid and updates them accordingly in a replacement grid.
        public void updateAllCells()
        {
            List<List<Cell>> xyNew = xy;
            for(int i = 0; i < xy.Count(); i++)
            {
                for(int j = 0; j < xy[i].Count; j++)
                {
                    if (xy[i][j].alive)
                    {
                        if(!(Rules.minStayAlive<=countSurroundingCells(i, j)) || !(Rules.maxStayAlive>=countSurroundingCells(i,j)))
                        {
                            xyNew[i][j].alive = false;
                        }
                    }
                    else if (Rules.requiredForBirth == countSurroundingCells(i, j))
                    {
                        xyNew[i][j].alive = true;
                    }
                }
            }
            xy = xyNew;
        }

        //Counts the number of living cells around a given coordinate in the grid 
        private int countSurroundingCells(int x, int y)
        {
            int output = 0;

            if (x > 0)
            {
                if(y > 0)
                {
                    if (xy[x - 1][y - 1].alive)
                    {
                        output++;
                    }
                }
                if (xy[x - 1][y].alive)
                {
                    output++;
                }
                if (y < xy[0].Count()-1)
                {
                    if (xy[x - 1][y + 1].alive)
                    {
                        output++;
                    }
                }
            }
            if (y > 0)
            {
                if (xy[x][y - 1].alive)
                {
                    output++;
                }
            }
            if (x < xy.Count()-1)
            {
                if(y < xy[0].Count()-1)
                {
                    if (xy[x + 1][y + 1].alive)
                    {
                        output++;
                    }
                }
                if (xy[x+1][y].alive)
                {
                    output++;
                }
                if(y > 0)
                {
                    if (xy[x + 1][y - 1].alive)
                    {
                        output++;
                    }
                }
            }
            if(y < xy[0].Count()-1)
            {
                if (xy[x][y + 1].alive)
                {
                    output++;
                }

            }
            return output;
        }

        public bool getCellStatus(int x, int y)
        {
            return xy[x][y].alive;
        }
    }
}
