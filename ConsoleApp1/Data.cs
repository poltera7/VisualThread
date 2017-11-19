using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Data
    {
        private volatile int mState = 1;

        public int getState() { return mState; }

        public void Tic() {

            Console.Write("Tic-");
            mState = 2;
        }

        public void Tak()
        {

            Console.WriteLine("Tak");
            mState = 1;
        }

        //public object OnOf = new object();
        /*public void Tic(bool run)
        {
            lock (OnOf)
            {
                if (!run)
                {
                    Monitor.Pulse(OnOf);
                    return;
                }
                Console.WriteLine("Tic");
                Monitor.Pulse(OnOf);
                Monitor.Wait(OnOf);
            }
            //state = 2;
        }
        public  void  Tac(bool run)
        {

            lock (OnOf)
            {
                if (run)
                {
                    Monitor.Pulse(OnOf);
                    return;
                }
                Console.WriteLine("Tac");
                Monitor.Pulse(OnOf);
                Monitor.Wait(OnOf);
            }
        }*/
    }
}
