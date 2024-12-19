using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace grafy2
{
    internal class dijkstra
    {
        int[] d;
        int[] p;
        List<int> s;

        public dijkstra(int n)
        {
            d = new int[n];
            p = new int[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0)
                {
                    d[i] = 0;
                }
                else
                {
                    d[i] = 99999;
                }
                p[i] = -1;
            }
            s = new List<int>();
        }



    }
}
