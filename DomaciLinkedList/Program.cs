using System;

namespace DomaciLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList V = new LinkedList();

            V.AddHead(33);
            V.AddTail(43);

            V.AddHead(13);
            V.AddTail(123);

            V.AddHead(53);
            V.AddTail(103);

            V.AddHead(73);
            V.AddTail(83);


            V.AddTail(63);

            Console.WriteLine(V);

            V.RemoveAt(8);

            Console.WriteLine(V);

            V.InsertAt(5);
            // V.InsertAt(-1);

            Console.WriteLine(V);

        }
    }
}
