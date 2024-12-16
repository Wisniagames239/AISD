using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewa
{
    internal class BST
    {
        public NodeT root;
        public void Add(int liczba)
        {
            var dziecko = new NodeT(liczba);
            if (root == null)
            {
                root = new NodeT(liczba);
                return;
            }
            var rodzic = SzukajRodzica(dziecko);
            dziecko.rodzic = rodzic;
            if (rodzic.data > dziecko.data)
                rodzic.lewe = dziecko;
            else
                rodzic.prawe = dziecko;
        }
        private NodeT SzukajRodzica(NodeT dziecko)
        {
            NodeT tmp = root;
            while (true)
            {
                if (tmp.data > dziecko.data)
                {
                    if (tmp.lewe == null)
                        return tmp;
                    else
                        tmp = tmp.lewe;
                }
                else
                {
                    if (tmp.prawe == null)
                        return tmp;
                    else
                        tmp = tmp.prawe;
                }
            }

        }
        public void RemoveElement(NodeT wezel)
        {
            switch (wezel.LiczbaDzieci())
            {
                case 0:
                    {
                        RemoveElement0(wezel);
                        return;
                    }
                case 1:
                    {
                        var dziecko = this.RemoveElement1(wezel);
                        var rodzic = wezel.rodzic;
                        RemoveElement0(wezel);
                        if (rodzic == wezel)
                        {
                            rodzic.PolaczPrawe(dziecko);
                        }
                        else
                            rodzic.PolaczLewe(dziecko);
                        return;
                    }
                case 2:
                    {
                        var tmp = Min(wezel.prawe);
                        this.RemoveElement(tmp);
                        
                        tmp.rodzic = wezel.rodzic;
                        wezel.rodzic = null;
                        tmp.lewe = wezel.lewe;
                        wezel.lewe = null;
                        tmp.prawe = wezel.prawe;
                        wezel.prawe = null;
                        return;
                    }
            }
            
        }
        private NodeT Min(NodeT n)
        {
            var tmp = n;
            while (tmp.lewe != null)
            {
                tmp = tmp.lewe;
            }
            return tmp;
        }
        private void RemoveElement0(NodeT wezel)
        {
            if(root== wezel)
            {
                root = null;
                return;
            }
            if(wezel.rodzic.lewe == wezel)
            {
                wezel.rodzic.lewe = null;
            }
            else
            {
                wezel.rodzic.prawe = null;
                
            }
            wezel.rodzic = null;


        }
        private NodeT RemoveElement1(NodeT wezel)
        {
            NodeT dziecko = null;
            if (wezel == null)
                return null;
            if(wezel.lewe !=null)
            {
                dziecko = wezel.lewe;
            }
            else if(wezel.prawe !=null)
            {
                dziecko = wezel.prawe;
            }
            RemoveElement0(dziecko);
            return dziecko;

        }
        public void CPD(NodeT wezel, int wariant, ref string bania)
        {
            if (wezel == null)
                return;
            if(wariant == 0)
            {
                bania += wezel.data + " ";
            }
            CPD(wezel.lewe, wariant, ref bania);
            if(wariant==1)
            {
                bania += wezel.data + " ";
            }
            CPD(wezel.prawe, wariant, ref bania);
            if(wariant!=1&&wariant!=0)
            {
                bania += wezel.data + " ";
            }

        }
        public string test(int wariant)
           {
            string bania = "";
            CPD(this.root,wariant ,ref bania);
            return bania;
        }
        public NodeT Znajdz(int data)
        {
            NodeT current = root;
            while (current != null)
            {
                if (data == current.data)
                {
                    return current; 
                }
                else if (data < current.data)
                {
                    current = current.lewe;
                }
                else
                {
                    current = current.prawe;
                }
            }
            return null;
        }
        /*void wglab(NodeT n, string kod)
        {
            if(n!=null)
            {
                wglab(n.lewe, kod+"0");
                wglab(n.prawe, kod+"1");
            }
        }

        /*public Dictionary<char,string> kodowanieHoffmana(Dictionary<char,int> slownik)
        {
           var posortowana = lista.OrderBy(n => n.data).ThenBy(n=>n.GetType()==typeof(NodeGS)?0:1).ToList();
            var lista = new List<NodeT>();
        }*/
    }
}
