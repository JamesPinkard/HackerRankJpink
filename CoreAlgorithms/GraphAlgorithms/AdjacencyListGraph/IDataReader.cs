﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphAlgorithms.AdjacencyListGraph
{
    public interface IDataReader
    {
        IEnumerable<string> ReadAllLines();
    }
}
