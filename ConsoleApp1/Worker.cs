using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Worker
    {
        private int mId;
        private Thread mThread;
        private Data mDataObj;

        public Worker(int _id, Data _data)
        {
            mId = _id;
            mThread = new Thread(new ThreadStart(Run));
            mDataObj = _data;
            //thread.Name = name;
            mThread.Start();
        }
        private void Run()
        {
            lock (mDataObj)
            {
                for (int i = 0; i < 10; i++)
                {
                    while (mDataObj.getState() != mId)
                    {
                        Monitor.Wait(mDataObj);
                    }

                    if (mId == 1)
                    {
                        mDataObj.Tic();
                    }
                    else
                    {
                        mDataObj.Tak();
                    }

                    Monitor.Pulse(mDataObj);
                }
            }
            
        }


    }
}

