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

            int n = 1000;
            Methods methods = new Methods(n);
            int sumn = methods.SumOfN();
            Assert.AreEqual(4500, sumn);
        }

        [TestMethod]
        public void TestDifferentMethods()
        {
            int n = 1000;
            Methods methods = new Methods(n);
            int sum1 = methods.SumOfN();
            int sum2 = methods.SumOfNParallel();
            int sum3 = methods.SumOfNAsParallelLinq();
            Assert.AreEqual(sum1, sum2);
        }

    }
}
