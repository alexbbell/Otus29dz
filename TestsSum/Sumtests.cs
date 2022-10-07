using _28_parallel_linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsSum
{
    [TestClass]
    public class Sumtests
    {
        [TestMethod]
        public void TestSimpleCalculation()
        {

            int n = 100;
            Methods methods = new Methods(n);
            decimal sumn = methods.SumOfN();
            Assert.AreEqual(5050, sumn);
        }

        [TestMethod]
        public void TestDifferentMethods()
        {
            int n = 1000;
            Methods methods = new Methods(n);
            
            decimal sum2 = methods.SumOfNParallelTasks();
            decimal sum3 = methods.SumOfNAsParallelLinq();
            Assert.AreEqual(sum3, sum2);
        }

    }
}
