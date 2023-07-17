using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6p1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            //stack.Push("Aman");
            //stack.Push("vijay");
            //stack.Push("Zoya");
            //stack.Push("Raj");
            //stack.Push("Kiran");
            //Console.WriteLine(" No.of Items in stack are \t"+stack.Count);

            //foreach( var item in stack)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("After removing " + stack.Pop());
            //Console.WriteLine("After removing" +stack.Pop());
            //Console.WriteLine("Number of intems in stack are : \t" + stack.Count);
            //foreach ( var item in stack)
            //{ Console.WriteLine(item); }
            //Console.WriteLine("Peel Example :\t"+stack.Peek());
            //Console.WriteLine("After peek");
            //Console.WriteLine("Number of ithems in stack are:\t" + stack.Count);
            //foreach (var item in stack)

            //{ Console.WriteLine(item); }
            //stack.Clear();
            //Console.WriteLine("After clear number of items are : \t" + stack.Count);
            //Console.ReadKey();
            //Console.ReadKey();







            Queue queue = new Queue();
            queue.Enqueue("Aman");
            queue.Enqueue("vijay");
            queue.Enqueue("Zoya");
            queue.Enqueue("Raj");
            queue.Enqueue("Kiran");
            Console.WriteLine(" No.of Items in Queue are \t" + queue.Count);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After removing " + queue.Dequeue());
            Console.WriteLine("After removing" + queue.Dequeue());
            Console.WriteLine("Number of intems in  are Queue: \t" + queue.Count);
            foreach (var item in queue)
            { Console.WriteLine(item); }
            Console.WriteLine("Peel Example :\t" + queue.Peek());
            Console.WriteLine("After peek");
            Console.WriteLine("Number of ithems in Queue are:\t" + queue.Count);
            foreach (var item in queue)

            { Console.WriteLine(item); }
            queue.Clear();
            Console.WriteLine("After clear number of items are : \t" + queue.Count);
            Console.ReadKey();
            Console.ReadKey();

        }
    }
}
