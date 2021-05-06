using System;

namespace LinkedListBubbleSortSwapNodes
{
    class Program
    {
        static void SwapNextWithNextNext(Node node)
        {
            Node nodesNextNext = node.Next.Next;
            Node nodesNext = node.Next;

            Node nodesNextNextNext = null;
            if (node?.Next?.Next?.Next != null)
            {
                nodesNextNextNext = node.Next.Next.Next;
            }

            node.Next.Next = null;
            node.Next = null;


            node.Next = nodesNextNext;

            if (nodesNextNext != null)
            {
                nodesNextNext.Next = nodesNext;
            }
            nodesNext.Next = nodesNextNextNext;


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

            //  SwapNextWithNextNext(list);


            ;

            bool didSwapHappen= false;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Starting sorting loop");

                current = list;
                didSwapHappen = false;
                
                while(current != null)
                {
                    if (current.Next == null)
                    {
                        break;
                    }

                    Console.WriteLine($"Comparing {current.Value} with {current.Next.Value}");

                    if (current.Value > current.Next.Value)
                    {
                        Console.WriteLine($"Swapping {current.Value} with {current.Next.Value}");

                        // TEST CODE
                        var temp = current.Value;
                        current.Value = current.Next.Value;
                        current.Next.Value = temp;

                        
                        //SwapNextWithNextNext(current);
                        didSwapHappen = true;
                    }
                    
                    Console.WriteLine("Advancing to next node");
                    current = current.Next;
                }

            } while (didSwapHappen);

            Console.WriteLine(" ");
            Console.Write("Sorted List");
            Console.WriteLine("");

            current = list;
            while(current != null)
            { 
                Console.WriteLine(current.Value);
                current = current.Next;
            }
            Console.ReadKey();

        }
    }
}
