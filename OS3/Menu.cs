using System;
using System.Threading;

namespace OS3
{
    public class Menu
    {
        public static bool InMenu = true;


        public static void Start()
        {
            new Thread(() => {
                for(;;) if (Console.ReadKey(true).Key == ConsoleKey.Q) 
                {
                    InMenu = false;
                    Console.WriteLine("Program will shut down after consumers finish work");
                }
            }){IsBackground = true}.Start();
            
            Generator g1 = new Generator();
            Generator g2 = new Generator();
            Generator g3 = new Generator();
            
            Consumer c1 = new Consumer();
            Consumer c2 = new Consumer();
            
            
            Thread tGen1 = new Thread(g1.Generate);
            Thread tGen2 = new Thread(g2.Generate);
            Thread tGen3 = new Thread(g3.Generate);
            
            Thread tCons1 = new Thread(c1.Consume);
            Thread tCons2 = new Thread(c2.Consume);
            
            tCons1.Start();
            tCons2.Start();
            
            tGen1.Start();
            tGen2.Start();
            tGen3.Start();
        }
    }
}