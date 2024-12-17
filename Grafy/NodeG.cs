using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace Grafy
{
    internal class NodeG
    {
        public List<NodeG> sasiedzi = new List<NodeG>();
        public int data;
        public NodeG(int liczba)
        {
            this.data = liczba;
        }
        public override string ToString()
        {
            return this.data.ToString();
        }

        public void Join(List<NodeG> sasiedzi)
        {
            foreach (var sasied in sasiedzi)
            {
                if (!this.sasiedzi.Contains(sasied))
                {
                    this.sasiedzi.Add(sasied);
                    sasied.Join(new List<NodeG> { this }); 
                }
            }

        }

    }
}
