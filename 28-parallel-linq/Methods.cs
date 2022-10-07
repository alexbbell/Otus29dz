
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
namespace _28_parallel_linq
{
    public class Methods
    {
        public int n;
        List<int> vs { get; set; }
        public Methods(int x)
        {
            n = x;
            PopulateList();
        }

        public void PopulateList()
        {
            vs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                //Random random = new Random();
                //int number = random.Next(0, 10);
                int number = i % 10;
                vs.Add(number);
            }
        }


        public int SumOfN()
        {            
            return vs.Sum();
        }

        public int Sum(IEnumerable<int> collection)
          => collection.Sum();

        public int SumOfNAsParallelLinq()
        {
            return vs.AsParallel<int>().Sum();
        }

        public int SumOfNParallel()
        {
            int cpus = Environment.ProcessorCount;
            int sum = 0;
            Parallel.For(0, n, x =>
            {
                sum = vs.Sum();
            });
            return sum;
        }


        public int SumOfNParallelTasks()
        {
            int cpus = Environment.ProcessorCount;

            int[] sum = new int[cpus];


            //Cut to pieces
            int smallListLength   = (int)Math.Ceiling( (decimal)n / cpus);
            
            var parts = Enumerable.Range(0, smallListLength)
                .Select(i => vs.Skip(i * smallListLength).Take(smallListLength));

            var tasks = parts.Select(
                    e => Task.Run(
                        () => Sum(e))
                ).ToArray();            
            Task.WaitAll(tasks);


            return tasks.Select(t => t.Result).Sum();  //sum.ToList().Sum();

        }

    }
}
