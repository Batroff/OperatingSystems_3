using System;
using System.Collections.Generic;

namespace OS3
{
    public static class MyQueue
    {
        public static Queue<int> Queue = new Queue<int>(200);
        public static int SIZE = 200;

        public static void FillQueue() 
        {
            for (int i = 0; i < SIZE; i++)
            {
                Queue.Enqueue(i);
            }
        }

        public static void ShowQueue() 
        {
            foreach (var q in Queue)
            {
                Console.WriteLine(q);
            }
        }
    }
}