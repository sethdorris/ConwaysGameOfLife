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

        }

        public int getIndex()
        {
            return index;
        }

        public void setIndex(int newIndex)
        {
            index = newIndex;
        }

        public void Tick()
        {
            while (index < 2)
            {
                Checker();
            }
        }

        public int Checker()
        {
            int counter = 0;
            bool previousCell;
            bool currentCell;
            for (int i =0; i < cells.Count(); i++)
            {
                for (int j = 0; j < cells[i].Count(); j++)
                {
                    currentCell = cells[i][j];
                    previousCell = currentCell;
                }
            }
            return counter;
        }

        public List<List<bool>> ToList()
        {
            return cells;
        }
    }
}
