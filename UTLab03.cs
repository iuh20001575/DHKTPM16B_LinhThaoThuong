using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime;

namespace Project
{
    [TestClass]
    public class UTLab03
    {
        public TestContext TestContext { get; set; }

        [TestMethod,
            DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
                "|DataDirectory|\\UTLab03.CSV",
                "UTLab03#CSV",
                DataAccessMethod.Sequential),
                DeploymentItem("UTLab03.csv")]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            int actualResult = (int)methodLibrary.TinhTienDien(Int16.Parse(TestContext.DataRow[0].ToString()), Int16.Parse(TestContext.DataRow[1].ToString()));
            
            int expectedResult = Int32.Parse(TestContext.DataRow[2].ToString());

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}