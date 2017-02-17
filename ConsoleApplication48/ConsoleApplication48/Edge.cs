using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication48
{

    class Edge
    {
        public readonly Points v1;
        public readonly Points v2;
        public readonly double lenght;
        public Edge(Points v1, Points v2)
        {
            this.v1 = v1;
            this.v2 = v2;
            lenght = Math.Sqrt(Math.Pow(v2.x - v1.x, 2) + Math.Pow(v2.y - v1.y, 2));
        }

    }
}
     