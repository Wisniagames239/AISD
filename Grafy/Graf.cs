using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafy
{
    internal class Graf
    {
        public List<NodeG> nodes = new List<NodeG>();

        public List<NodeG> Wszerz(NodeG start)
        {
            List<NodeG> odwiedzone = new List<NodeG>() { start };
            for (int i = 0; i < odwiedzone.Count; i++)
            {
                var tmp = odwiedzone[i];
                for (int j = 0; j < tmp.sasiedzi.Count; j++)
                {
                    if (!odwiedzone.Contains(tmp.sasiedzi[j]))
                        odwiedzone.Add(tmp.sasiedzi[j]);
                }
            }
            return odwiedzone;
        }
        public List<NodeG> Wglab(NodeG start, List<NodeG> odwiedzone)
        {
            if (!odwiedzone.Contains(start))
            {
                odwiedzone.Add(start);
            }
            for(int i = 0;i < start.sasiedzi.Count;i++)
            {
                Wglab(start.sasiedzi[i], odwiedzone);
            }
            return odwiedzone;
        }
        public void dodaj(NodeG node, List<NodeG> sasiedzi)
        {
            if (!nodes.Contains(node))
            {
                nodes.Add(node);
            }

            node.Join(sasiedzi);
        }
    }
}

