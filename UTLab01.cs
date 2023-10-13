using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime;

namespace Project
{
    [TestClass]
    public class UTLab01
    {
        [TestMethod]
        public void TestMethod1()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int a = -5;
                int b = 4;
                int c = 6;
                int maxActualResult = methodLibrary.Max(a, b, c);
            }
            catch (Exception e)
            {
                expectedResult = e;
            }
            Assert.IsNotNull(expectedResult);

        }
        [TestMethod]
        public void TestMethod2()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int a = 55;
                int b = 4;
                int c = 6;
                int maxActualResult = methodLibrary.Max(a, b, c);
            }
            catch (Exception e)
            {
                expectedResult = e;
            }
            Assert.IsNotNull(expectedResult);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int a = 3;
                int b = -5;
                int c = 6;
                int maxActualResult = methodLibrary.Max(a, b, c);
            }
            catch (Exception e)
            {
                expectedResult = e;
            }
            Assert.IsNotNull(expectedResult);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int a = 3;
                int b = 55;
                int c = 6;
                int maxActualResult = methodLibrary.Max(a, b, c);
            }
            catch (Exception e)
            {
                expectedResult = e;
            }
            Assert.IsNotNull(expectedResult);
        }
        [TestMethod]
        public void TestMethod5()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int a = 3;
                int b = 4;
                int c = -5;
                int maxActualResult = methodLibrary.Max(a, b, c);
            }
            catch (Exception e)
            {
                expectedResult = e;
            }
            Assert.IsNotNull(expectedResult);
        }
        [TestMethod]
        public void TestMethod6()
        {
            Exception expectedResult = null;
            try
            {
                MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
                int a = 3;
                int b = 4;
                int c = 55;
                int maxActualResult = methodLibrary.Max(a, b, c);
            }
            catch (Exception e)
            {
                expectedResult = e;
            }
            Assert.IsNotNull(expectedResult);
        }
        [TestMethod]
        public void TestMethod7()
        {
            int expectedResult = 6;
            MethodLibrary.MethodLibrary methodLibrary = new MethodLibrary.MethodLibrary();
            int maxActualResult = methodLibrary.Max(3, 4, 6);
            Assert.AreEqual(expectedResult, maxActualResult);
        }
    }
}