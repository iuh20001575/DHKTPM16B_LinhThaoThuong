using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestBlack_box
{
    [TestClass]
    public class UTLab07
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            int[] a = new int[] { 2, 5, 7, 47, 55, 33, 22 };
            int actualResult = methodLibrary.Largest(a);
            int expectedResult = 55;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            int[] a = new int[] {};
            int actualResult = methodLibrary.Largest(a);
            int expectedResult = Int32.MaxValue;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();

            int[] a = new int[] { 5 };
            int actualResult = methodLibrary.Largest(a);
            int expectedResult = 5;

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
