using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*1*/

        //private static int shareCount = 0;

        //private Object o1 = new object();
        static void Main(string[] args)
        {
            /*Thread t1 = new Thread(new ThreadStart(() =>
            {
                Object o1 = new object();
                for (int i = 0; i < 100; i++)
                {
                    
                    Monitor.Enter(o1);
                        Thread.Sleep(1);
                        int tmp = shareCount;
                        Thread.Sleep(12);
                        tmp++;
                        Thread.Sleep(3);
                        shareCount = tmp;
                        Thread.Sleep(7);
                    Monitor.Exit(o1);
                }
            }));

            Thread t2 = new Thread(new ThreadStart(() =>
            {
                Object o1 = new object();
                for (int i = 0; i < 100; i++)
                {
                    Monitor.Enter(o1);
                    Thread.Sleep(5);
                    int tmp = shareCount;
                    Thread.Sleep(10);
                    tmp++;
                    Thread.Sleep(2);
                    shareCount = tmp;
                    Thread.Sleep(8);
                    Monitor.Exit(o1);
                }
            }));

            Thread t3 = new Thread(new ThreadStart(work));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
            Console.WriteLine(shareCount);*/

            Data dt = new Data();
            Worker w1 = new Worker(1, dt);
            Worker w2 = new Worker(2, dt);
        }
    }
}
