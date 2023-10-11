using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime;

namespace Project
{
    [TestClass]
    public class UTLab05
    {
        public TestContext TestContext { get; set; }

        [TestMethod,
            DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "|DataDirectory|\\UTLab05.CSV",
                "UTLab05#CSV",
                DataAccessMethod.Sequential),
                DeploymentItem("UTLab05.csv")]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            String actualResult = methodLibrary.HuyChuoi(TestContext.DataRow[0].ToString(), Int32.Parse(TestContext.DataRow[1].ToString()), Int32.Parse(TestContext.DataRow[2].ToString()));

            String expectedResult = TestContext.DataRow[3].ToString();

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
