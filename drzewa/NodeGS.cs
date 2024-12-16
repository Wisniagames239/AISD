using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewa
{
    internal class NodeGS : NodeT
    {
        char symbol;
        public NodeGS(int liczba, char symbol) : base(liczba)
        {
            this.symbol = symbol;
        }
    }
}
