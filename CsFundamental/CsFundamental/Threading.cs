using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CsFundamental
{
    public class Threading
    {       

        public Threading()
        {
            Thread threadFirst = new Thread(ThreadMethodFirst);
            Thread threadSecond = new Thread(ThreadMethodSecond);

            threadFirst.Start();
            threadSecond.Start();

        }

        private void ThreadMethodFirst()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(200);
            }
        }

        private void ThreadMethodSecond()
        {
            for (int i = 11; i <= 15; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(400);
            }
        }
    }
}
