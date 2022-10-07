using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _28_parallel_linq
{
    public class Diagram
    {

        // Замерьте время выполнения для 100 000, 1 000 000 и 10 000 000
        //Укажите в таблице результаты замеров, указав:
        //Окружение(характеристики компьютера и ОС)
        //Время выполнения последовательного вычисления
        //Время выполнения параллельного вычисления
        //Время выполнения LINQ

        string _result { get; set; }

        public void PrintHeader()
        {
            Console.WriteLine("\tMethod\t\t|\tN  |\tSUM\t\t|  Execute time:|");
            Console.WriteLine("-------------------------------------------------------------------------");

        }
        public void SimpleCount(Methods method )
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            decimal sum = method.SumOfN();
            stopwatch.Stop();

            string countType = "Simple Calculation";
            string sumStr = sum.ToString().PadRight(20).Substring(0, 20);
            string nStr = method.n.ToString().PadRight(10).Substring(0, 10);
            string watchStr = stopwatch.Elapsed.Milliseconds.ToString().PadRight(8).Substring(0, 8);
            Console.WriteLine( 
                ($"{countType}\t|{nStr}|{sumStr}|  {stopwatch.Elapsed.Milliseconds}\t\t|"));
            Console.WriteLine("-------------------------------------------------------------------------");
        }


        public void LinqAsParallel(Methods method)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            decimal sum = method.SumOfNAsParallelLinq();
            stopwatch.Stop();


            string countType = "Parallel linq";
            string sumStr = sum.ToString().PadRight(20).Substring(0, 20);
            string nStr = method.n.ToString().PadRight(10).Substring(0, 10);
            string watchStr = stopwatch.Elapsed.Milliseconds.ToString().PadRight(8).Substring(0, 8);
            Console.WriteLine(
                ($"{countType}\t\t|{nStr}|{sumStr}|  {stopwatch.Elapsed.Milliseconds}\t\t|"));

            Console.WriteLine("-------------------------------------------------------------------------");
        }


        public void ParallellTasks(Methods method)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            decimal sum = method.SumOfNParallelTasks();
            stopwatch.Stop();

            string countType = "Parallel Tasks";
            string sumStr = sum.ToString().PadRight(20).Substring(0, 20);
            string nStr = method.n.ToString().PadRight(10).Substring(0, 10);
            string watchStr = stopwatch.Elapsed.Milliseconds.ToString().PadRight(8).Substring(0, 8);
            Console.WriteLine(
                ($"{countType}\t\t|{nStr}|{sumStr}|  {stopwatch.Elapsed.Milliseconds}\t\t|"));

            Console.WriteLine("-------------------------------------------------------------------------");
        }

    }
}
