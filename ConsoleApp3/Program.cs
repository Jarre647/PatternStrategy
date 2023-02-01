using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = new Worker();
            worker.DoWork(new AnotherJob());
            worker.DoWork(new SomeJob());
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
