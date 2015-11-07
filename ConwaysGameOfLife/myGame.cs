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
            row.Add(new List<bool>(new bool[] { false, true}));
            row.Add(new List<bool>(new bool[] { false, true}));
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

        public List<bool> LoopThroughCells()
        {
            List<bool> neighbors = new List<bool> { };
            for (int i = 0; i < cells.Count(); i++)
            {
                for (int j = 0; i < cells[i].Count(); j++)
                {
                 
                }
            }
            return neighbors;
        }

        public bool caseOne()
        {
            //Just manually checking the first cells neighbors to think about how I can build 
            //this to be done automatically
            bool firstToCheck = cells[0][0];
            bool rightNeighbor = cells[0][1];
            bool rightCorner = cells[1][1];
            bool bottomNeighbor = cells[1][0];
            int numNeighborsAlive = 0;
            List<bool> neighborsToCheck = new List<bool> { rightNeighbor, rightCorner, bottomNeighbor };
            for (int i = 0; i < neighborsToCheck.Count(); i++)
            {
                if (neighborsToCheck[i])
                {
                    numNeighborsAlive++;
                }
            }
            if (numNeighborsAlive < 2)
            {
                firstToCheck = true;
            } else
            {
                firstToCheck = false;
            }
            return firstToCheck;
        }   

        public bool caseTwo()
        {
            return false;
        }

        public bool caseThree()
        {
            return false;
        }

        public bool caseFour()
        {
            return true;
        }

        public List<List<bool>> ToList()
        {
            return cells;
        }

        public void Tick()
        {
           
        }

    }
}
