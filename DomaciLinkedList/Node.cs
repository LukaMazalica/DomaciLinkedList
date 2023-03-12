using System;
using System.Collections.Generic;
using System.Text;

namespace DomaciLinkedList
{
    class Node
    {
        private int data;
        public int Data
        {
            get { return data; }
            set { data = value; }
        }

        private Node next;
        public Node Next
        {
            get { return next; }
            set { next = value; }
        }

        private Node prev;
        public Node Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public Node(int _data)
        {
            Data = _data;
        }
    }
}
