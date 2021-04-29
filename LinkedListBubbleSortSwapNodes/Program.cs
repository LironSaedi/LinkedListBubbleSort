using System;

namespace LinkedListBubbleSortSwapNodes
{
    class Program
    {
        static void SwapNextWithNextNext(Node node)
        {
            Node nodesNextNext = node.Next.Next;
            Node nodesNext = node.Next;
            Node nodesNextNextNext;
            if (node.Next.Next.Next.Value != null)
            {
                nodesNextNextNext = node.Next.Next.Next;
            }

            node.Next.Next = null;
            node.Next = null;
           

            node.Next = nodesNextNext;
            nodesNextNext.Next = nodesNext;
            nodesNext.Next = nodesNextNextNext;
            if (nodesNextNextNext!= null)
            {
                
            }
         
        }

        static void Main(string[] args)
        {

            Random gen = new Random();

            Node list = new Node();
            int count = 0;

            // Populate list            
            Node current = list;
            int totalItems = 5;
            for (int i = 0; i < totalItems; i++)
            {
                current.Value = gen.Next(1, 100);
                count++;

                if (i < totalItems - 1)
                {
                    current.Next = new Node();
                    current = current.Next;
                }
            }

            ;

            // Print the list

            Console.WriteLine("UnSorted:");
            bool swapped;
            current = list;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

      SwapNextWithNextNext(list);


            ;


            current = list;
            for (int i = 0; i < count; i++)
            {
                swapped = false;
                for (int j = 0; j < count - 2; j++)
                {
                    //Node temp1 = current;

//                    Node temp2 = temp1.Next;

                    if (current.Value > current.Next.Value)
                    {
                        //SwapNextWithNextNext(previous);

                        SwapNextWithNextNext(current);
                        swapped = true;
                    }

                    current = current.Next;
                }

                if (swapped == false)
                {
                    break;
                }
            }


            Console.WriteLine(" ");
            Console.Write("Sorted List");
            Console.WriteLine("");

            current = list;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            Console.ReadKey();

        }
    }
}
