using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlack_box
{
    [TestClass]
    public class UTLab06
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            String actualResult = methodLibrary.ThayThe("", "b", "d");
            String expectedResult = "";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            String actualResult = methodLibrary.ThayThe("abc", "", "d");
            String expectedResult = "abc";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            String actualResult = methodLibrary.ThayThe("abc", "b", "");
            String expectedResult = "ac";

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            String actualResult = methodLibrary.ThayThe("abc", "b", "d");
            String expectedResult = "";

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
