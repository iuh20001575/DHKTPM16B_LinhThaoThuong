using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlack_box
{
    [TestClass]
    public class UTLab04
    {
        public TestContext TestContext { get; set; }

        [
            TestMethod,
            DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "|DataDirectory|\\UTLab04.CSV",
                "UTLab04#CSV", 
                DataAccessMethod.Sequential),
                DeploymentItem("UTLab04.csv")

            ]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            long kActualResult = methodLibrary.Sum(Int64.Parse(TestContext.DataRow[0].ToString()), out long sActualResult);

            long sExpectedResult = Int64.Parse(TestContext.DataRow[1].ToString());
            long kExpectedResult = Int64.Parse(TestContext.DataRow[2].ToString());

            Assert.AreEqual(sActualResult, sExpectedResult);
            Assert.AreEqual(kExpectedResult, kActualResult);
        }
    }
}
