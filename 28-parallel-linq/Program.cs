using System;
using System.Diagnostics;

namespace _28_parallel_linq
{
    internal class Program
    {

        


        static void Main(string[] args)
        {

            Diagram diagram = new Diagram();
            diagram.PrintHeader();
            
            
            int n1 = 100000;
            Methods methods1 = new Methods(n1);
            diagram.SimpleCount(methods1);
            diagram.LinqAsParallel(methods1);
            diagram.ParallellTasks(methods1);


            int n2 = 1000000;
            Methods methods2 = new Methods(n2);
            diagram.SimpleCount(methods2);
            diagram.LinqAsParallel(methods2);
            diagram.ParallellTasks(methods2);


            int n3 = 10000000;
            Methods methods3 = new Methods(n3);
            diagram.SimpleCount(methods3);
            diagram.LinqAsParallel(methods3);
            diagram.ParallellTasks(methods3);
            
            //StopWatchWrapper(methods3);



            Console.WriteLine("Hello World!");
        }


        //static void StopWatchWrapper (Func<int> func, Methods method)
        static void StopWatchWrapper(Methods method)
        {
            //var stopwatch = new Stopwatch();
            //stopwatch.Start();
            //decimal sum = method.SumOfN();
            //stopwatch.Stop();
            //Console.WriteLine("The sum is: {0}", sum);
            //Console.WriteLine("Execute time: {0}", stopwatch.Elapsed.Milliseconds);
            //Console.WriteLine("");


 





        }
    }
}
