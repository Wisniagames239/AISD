using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listy
{
    internal class List
    {
        public Node head;
        public Node tail;
        public int count = 0;
        public List()
        {
            this.head = null;
            this.tail = null;
        }
        public void AddLast(int liczba)
        {
            Node add = new Node(liczba);
            if(head==null)
            {
                this.head = add;
                this.tail = add;
                this.count = 1;
            }
            else
            {
                this.tail.next = add;
                add.prev = this.tail;
                this.tail = add;
                this.count++;
            }
            
        }
        public void AddFirst(int liczba)
        {
            Node add = new Node(liczba);
            if(tail==null)
            {
                this.head = add;
                this.tail = add;
                this.count = 1;
            }
            else
            { 
            this.head.prev = add;
            add.next = this.head;
            this.head = add;
            this.count++;
            }
        }
        public void RemoveFirst()
        {
            if (head == null) return;
            else if(head.next==null)
            {
                head = null;
                tail = null;
            }
            else {
                head = head.next;
                head.prev = null;
                count--;
            }
            
        }
        public void RemoveLast()
        {
            if (tail == null) return;
            else if (tail.prev == null)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
                count--;
            }
        }
        public string ToString()
        {
            Node node = this.head;
            string wyraz = "";
            while (node != null)
            {
                wyraz += Convert.ToString(node.data)+" ";
                node= node.next;
            }
            return wyraz;
        }
        public string ToStringReversed()
        {
            Node node = this.tail;
            string wyraz = "";
            while (node != null)
            {
                wyraz += Convert.ToString(node.data) + " ";
                node = node.prev;
            }
            return wyraz;
        }
    }
    
}
