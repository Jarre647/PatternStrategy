using System;

namespace ConsoleApp3
{
    class SomeJob : IJob
    {
        public void DoJob()
        {
            Console.WriteLine("Some Job");
        }
    }
}
