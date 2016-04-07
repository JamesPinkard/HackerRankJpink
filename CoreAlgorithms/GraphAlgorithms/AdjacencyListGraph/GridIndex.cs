using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    struct GridIndex
    {
        public int Row { get; private set; }
        public int Column { get; private set; }

        public GridIndex(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }
    }
}
