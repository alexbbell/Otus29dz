
using System;
using System.Diagnostics;

namespace _28_parallel_linq
{
    internal class Program
    {


        static void Main(string[] args)
        {

            int n1 = 10000;
            Console.WriteLine("N1 = " + n1);
            Methods methods = new Methods(n1);
            StopWatchWrapper(methods);

            int n2 = 100000;
            Console.WriteLine("N2 = " + n2);
            Methods methods2 = new Methods(n2);
            StopWatchWrapper(methods2);


            int n3 = 1000000;
            Console.WriteLine("N3 = " + n3);
            Methods methods3 = new Methods(n3);
            StopWatchWrapper(methods3);



            Console.WriteLine("Hello World!");
        }


        //static void StopWatchWrapper (Func<int> func, Methods method)
        static void StopWatchWrapper(Methods method)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            int sum = method.SumOfN();
            stopwatch.Stop();
            Console.WriteLine("The sum is: {0}", sum);
            Console.WriteLine("Execute time: {0}", stopwatch.Elapsed.Milliseconds);
            Console.WriteLine("");


            Console.WriteLine("-----Parallel linq");
            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            int sum2 = method.SumOfNAsParallelLinq();
            stopwatch2.Stop();
            Console.WriteLine("The sum is: {0}", sum2);
            Console.WriteLine("Execute time: {0}", stopwatch2.Elapsed.Milliseconds);
            Console.WriteLine("");



            Console.WriteLine("-----Parallel Task linq");
            var stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            int sum3 = method.SumOfNParallelTasks();
            stopwatch3.Stop();
            Console.WriteLine("The sum is: {0}", sum3);
            Console.WriteLine("Execute time: {0}", stopwatch3.Elapsed.Milliseconds);


        }
    }
}
