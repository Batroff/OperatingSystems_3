using System;
using System.Threading;
using static OS3.MyQueue;

namespace OS3
{
    public class Consumer
    {
        public void Consume()
        {
            while (true)
            {
                lock (Queue)
                {
                    if (Queue.Count > 0)
                    {
                        Console.WriteLine("Consumed: " + Queue.Dequeue());
                    }
                    else
                    {
                        Console.WriteLine("Queue count = 0. Consumer is stopping...");
                        break;
                    }
                }
                Thread.Sleep(250);
            }
        }   
    }
}