using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
   public class myGame : Board
    {
        private List<List<bool>> cells = new List<List<bool>>();
        private int index = 0;

        public myGame()
        {
            List<List<bool>> row = new List<List<bool>>();
            row.Add(new List<bool>(new bool[] { false, true, false}));
            row.Add(new List<bool>(new bool[] { false, true, false}));
            row.Add(new List<bool>(new bool[] { false, true, false}));
            cells = row;
            Tick();
        }

        public int getIndex()
        {
            return index;
        }

        public void setIndex(int newIndex)
        {
            index = newIndex;
        }

        public void LoopThroughCells()
        {
            List<List<bool>> newCells = new List<List<bool>>(); 
            for (int i = 0; i < cells.Count(); i++)
            {
                List<bool> newRow = new List<bool>();

                for (int j = 0; j < cells[i].Count(); j++)
                {
                    newRow.Add(caseOne(i, j));
                }
                newCells.Add(newRow);
            }
            cells = newCells;
        }

        public bool caseOne(int i, int j)
        { 
            bool firstToCheck = cells[i][j];
            bool topCenter;
            bool topRight;
            bool right;
            bool bottomRight;
            bool bottom;
            bool bottomLeft;
            bool left;
            bool topLeft;

            try
            {
                topCenter = cells[i - 1][j];
            }
            catch (Exception e)
            {
                topCenter = false;
            }

            try
            {
                topRight = cells[i - 1][j + 1];
            }
            catch (Exception e)
            {
                topRight = false;
            }

            try
            {
                right = cells[i][j + 1];
            }
            catch (Exception e)
            {
                right = false;
            }

            try
            {
                bottomRight = cells[i + 1][j + 1];
            }
            catch (Exception e)
            {
                bottomRight = false;
            }

            try
            {
                bottom = cells[i + 1][j];
            }
            catch (Exception e)
            {
                bottom = false;
            }

            try
            {
                bottomLeft = cells[i + 1][j - 1];
            }
            catch (Exception e)
            {
                bottomLeft = false;
            }

            try
            {
                left = cells[i][j - 1];
            }
            catch (Exception e)
            {
                left = false;
            }

            try
            {
                topLeft = cells[i - 1][j - 1];
            }
            catch (Exception e)
            {
                topLeft = false;
            }

            int numNeighborsAlive = 0;

            List<bool> neighborCellList = new List<bool> { topCenter, topRight, right, bottomRight, bottom, bottomLeft, left, topLeft };

            for (int k = 0; k < neighborCellList.Count(); k++ )
            {
                if (neighborCellList[k])
                {
                    numNeighborsAlive++;
                }
            }

            if (firstToCheck)
            {
                if (firstToCheck == true && numNeighborsAlive < 2) //Checks for under population
                {
                    firstToCheck = false;
                } else if (numNeighborsAlive == 2 || numNeighborsAlive == 3) //Checks for live on to next generation
                {
                    firstToCheck = true;
                } else if (numNeighborsAlive > 3) //Checks for overpopulation
                {
                    firstToCheck = false;
                }
            } else if (!firstToCheck && numNeighborsAlive == 3)
            {
                firstToCheck = true;
            }
            

            return firstToCheck;
        }   

        public List<List<bool>> ToList()
        {
            return cells;
        }

        public void Tick()
        {
            LoopThroughCells();
        }

    }
}
