using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TADAKOGLUHOMEWORK1
{
    class Point
    {
        private int row, column;

        public Point(int row, int column)
        {
            this.row = row;
            this.column = column;
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public int Column
        {
            get { return column; }
            set { column = value; }
        }
    }
}
