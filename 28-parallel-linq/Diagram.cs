using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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

        public void PrintResult()
        {
            Console.WriteLine(_result);
            string fullPath = Directory.GetCurrentDirectory() + "/../../../" + "results.txt";
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.Write(_result);
            }

        }
        public void PrintHeader()
        {
            _result = "        Method          |    N     |       SUM          | Execute time: |\n";
            _result += "-------------------------------------------------------------------------\n";
            
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
            _result += $"{countType}\t|{nStr}|{sumStr}|  {stopwatch.Elapsed.Milliseconds}\t\t|\n";
            _result += "-------------------------------------------------------------------------\n";
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
            _result +=
                $"{countType}\t\t|{nStr}|{sumStr}|  {stopwatch.Elapsed.Milliseconds}\t\t|\n";

            _result += "-------------------------------------------------------------------------\n";
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
            _result +=
                $"{countType}\t\t|{nStr}|{sumStr}|  {stopwatch.Elapsed.Milliseconds}\t\t|\n";

            _result += "-------------------------------------------------------------------------\n";
        }

    }
}
