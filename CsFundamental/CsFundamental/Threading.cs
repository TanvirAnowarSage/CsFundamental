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
            Thread thread = new Thread(new ThreadStart(ThreadMethod));

            thread.Start();

        }

        private void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(0);
            }
        }
        
    }
}
