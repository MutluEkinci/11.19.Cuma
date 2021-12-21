using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //STACK VE QUEUE

            Stack stack = new Stack();

            stack.Push(12);
            stack.Push(22);
            stack.Push(32);

            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());


            Queue queue = new Queue();

            queue.Enqueue(12);
            queue.Enqueue(22);
            queue.Enqueue(32);


            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());

        }
    }
}
