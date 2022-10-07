using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Task[] tasks = new Task[5];
            for(int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task(() =>
                {
                    Thread.Sleep(1000);
                    Console.WriteLine($"Task {i} finished");
                    
                });
                tasks[i].Start();
            }
            Task.WaitAll(tasks);
        }
    }
}
