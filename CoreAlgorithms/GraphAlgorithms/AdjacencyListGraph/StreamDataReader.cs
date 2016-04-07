using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GraphAlgorithms.AdjacencyListGraph
{
    class StreamDataReader : IDataReader
    {

        public StreamDataReader(Stream stream)
        {
            this.stream = stream;
        }

        public IEnumerable<string> ReadAllLines()
        {            
            var fileData = new List<string>();
            using (var reader = new StreamReader(stream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    fileData.Add(line);
                }
            }
            return fileData;
        }


        private Stream stream;
    }
}
