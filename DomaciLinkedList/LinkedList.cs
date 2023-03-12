using System;
using System.Collections.Generic;
using System.Text;

namespace DomaciLinkedList
{
    class LinkedList 
    {
        private Node head;
        public Node First
        {
            get { return head; }
        }

        private Node tail;
        public Node Last
        {
            get { return tail; }
        }

        public int Count { get; }

        public int Length { get; private set; }


        public IEnumerator<Node> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }


 



        public void AddTail(int _data)
        {
            Node dodatiNode = new Node(_data);
            if (tail == null)
            {
                head = dodatiNode;
            }
            else
            {
                dodatiNode.Prev = tail;
                tail.Next = dodatiNode;
            }
            tail = dodatiNode;
            Length++;
        }


        public void AddHead(int _data)
        {
            Node dodatiNode = new Node(_data);
            dodatiNode.Next = head;
            if (head == null)
            {
                tail = dodatiNode;
            }
            else
            {
                head.Prev = dodatiNode;
            }
            head = dodatiNode;
            Length++;
        }


        public void InsertAt(int index)
        {
            Node temp = new Node(Convert.ToInt32(Console.ReadLine()));
            temp.Next = null;

            if (index >= 0 && index < Length)
            {
                Node temp2 = new Node(0);
                temp2 = head;
                for (int i = 0; i < index - 1; i++)
                {
                    if (temp2 != null)
                    {
                        temp2 = temp2.Next;
                    }
                }
                if (temp2 != null)
                {
                    temp.Next = temp2.Next;
                    temp2.Next = temp;
                }

            }
            else if (index == -1)
            {
                temp.Next = head;
                head = temp;
            }
        }


        public void RemoveAt(int index)
        {
            if (index < Length - 1 && index >= 0)
            {

                Node temp = head;

                while (index > 0)
                {
                    temp = temp.Next;
                    index--;

                }


                Node temp2 = temp.Next;
                temp.Data = temp2.Data;
                temp.Next = temp2.Next;
                temp2 = null;


                Length--;


            }
            else if (index == Length - 1)
            {
                Node temp = head;
                while (temp.Next.Next != null)
                    temp = temp.Next;
                temp.Next = null;
            }

        }




        public override string ToString()
        {

            Node writer = head;
            string write = "";
            while (writer != null)
            {
                write = write + writer.Data + " ";
                writer = writer.Next;

            }
            return write;
        }
    }
}
