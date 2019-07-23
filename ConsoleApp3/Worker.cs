using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Worker
    {

        public void DoWork(IJob job)
        {
            if (job != null)
            {
                job.DoJob();
            }
        }
    }
}
