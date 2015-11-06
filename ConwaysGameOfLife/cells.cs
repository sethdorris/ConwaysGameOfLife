using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConwaysGameOfLife
{
    public class Cells
    {
        public bool life = true;
        private Cells rightCell;
        private Cells bottomCell;
        private Cells leftCell;
        private Cells topCell;
        public Cells RightCell
        {
            get
            {
                return rightCell;
            }
            set
            {
                rightCell = value;
            }
        }
        public Cells BottomCell
        {
            get
            {
                return bottomCell;
            }
            set
            {
                bottomCell = value;
            }
        }
        public Cells LeftCell
        {
            get
            {
                return leftCell;
            }
            set
            {
                leftCell = value;
            }
        }
        public Cells TopCell
        {
            get
            {
                return topCell;
            }
            set
            {
                topCell = value;
            }
        }
    }
}
        
