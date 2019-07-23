using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class AnotherdJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Another Job");
        }
    }
}
