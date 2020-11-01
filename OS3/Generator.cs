using System;
using System.Threading;
using static OS3.MyQueue;

namespace OS3
{
    public class Generator
    {
        private static Random _random;
        
        public void Generate()
        {
            _random = new Random();
            
            while(Menu.InMenu)
            {
                if (Queue.Count <= 80)
                {
                    Console.WriteLine("Queue count <= 80... Generator started.");
                    lock (Queue)
                    {
                        while (Queue.Count <= SIZE)
                        {
                            int next = _random.Next(100);
                            Queue.Enqueue(next);
                            Console.WriteLine("Added: " + next);
                            Thread.Sleep(100);
                        }
                    }   
                }
                Thread.Sleep(250);
            }
        }
    }
}