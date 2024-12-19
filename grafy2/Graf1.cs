using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy2
{
    internal class Graf1
    {
        public List<NodeG1> nodes = new List<NodeG1>();
        public List<Edge> edges = new List<Edge>();
        public Graf1(Edge k)
        {
            nodes.Add(k.start);
            nodes.Add(k.end);
            edges.Add(k);
        }

        public void Add(Edge k)
        {
            if (ileNowychWezlow(k) == 1)
            {
                if (!nodes.Contains(k.start)) nodes.Add(k.end);
                else nodes.Add(k.start);
                edges.Add(k);
            }

        }
        public int ileNowychWezlow(Edge k)
        {
            int ilosc = 0;
            if (!nodes.Contains(k.start)) ilosc++;
            if (!nodes.Contains(k.end)) ilosc++;
            return ilosc;
        }
        public void Join(Graf1 g1)
        {
            foreach (Edge edge in g1.edges)
            {
                this.Add(edge);
                g1.edges.Remove(edge);
            }
        }
        public struct Element
        {
            public NodeG1 wezel;
            public int dystans;
            public NodeG1 poprzednik;
        };
        
        public List<Element> AlgorytmDijkstry(NodeG1 start)
        {
            var tab = this.PrzygotujTabelke(start);
            var zbS = new List<NodeG1>();
            while(zbS.Count != nodes.Count)
            {
                var kandydaci = tab.Where(e => !zbS.Contains(e.wezel)).ToList();
                var kandydat = kandydaci.OrderBy(e => e.dystans).First();
                var sasiedzi = edges.Where(e => e.start == kandydat.wezel);
                zbS.Add(kandydat.wezel);
                foreach(Edge sasiad in sasiedzi)
                {
                    var sos = tab.FirstOrDefault(e => e.wezel == sasiad.end);
                    var nowyDystans = kandydat.dystans + sasiad.weight;
                    if(sos.wezel != null&&nowyDystans < sos.dystans)
                    {
                        sos.dystans = nowyDystans;
                        sos.poprzednik = kandydat.wezel;
                    }
                }
            }
            return tab;
        }

        public List<Element> PrzygotujTabelke(NodeG1 start)
        {
            List<Element> tab = new List<Element>();
            foreach(NodeG1 e in nodes)
            {
                var tmp = new Element();
                tmp.wezel = e;
                tmp.dystans = int.MaxValue;
                tmp.poprzednik = null;
                tab.Add(tmp);
            }
            var pierw = tab.FirstOrDefault(e=> e.wezel== start);
            if (pierw.wezel != null)
            {
                pierw.dystans = 0;
            }
            return tab;



        }
    }
}
