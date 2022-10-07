
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

    
namespace _28_parallel_linq
{
    public class Methods
    {
        public int n;
        List<decimal> vs { get; set; }
        public Methods(int x)
        {
            n = x;
            PopulateList();
        }

        public void PopulateList()
        {
            vs = new List<decimal>();
            for (int i = 0; i < n; i++) {       
                vs.Add(i+1);
            }
        }


        public decimal SumOfN()
        {            
            return vs.Sum();
        }

        public decimal Sum(IEnumerable<decimal> collection)
          => collection.Sum();

        public decimal SumOfNAsParallelLinq()
        {
            return vs.AsParallel<decimal>().Sum();
        }

 


        public decimal SumOfNParallelTasks()
        {
            int cpus = Environment.ProcessorCount;

            int[] sum = new int[cpus];
            //Cut to pieces
            int smallListLength = (int)Math.Ceiling( (decimal)n / cpus);
            IEnumerable<decimal>[] parts = new IEnumerable<decimal>[cpus];

            Task<decimal>[] tasks = new Task<decimal>[cpus];
            decimal sums = 0;
            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = new Task<decimal>(() => vs.Skip(i * smallListLength).Take(smallListLength).Sum());
                tasks[i].Start();
                sums += tasks[i].Result;
            }
            Task.WaitAll();
            return sums;
        }

    }
}
