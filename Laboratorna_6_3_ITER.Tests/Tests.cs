using System;
using NUnit.Framework;

namespace Laboratorna_6_3_ITER.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int[] arr = { 8, 4, 3, 4, 10 };
            int size = arr.Length;

            int result = Program.FindMin(arr, size);

            Assert.AreEqual(3, result);
        }
        
        [Test]
        public void Test2()
        {
            int[] arr = { 8, 4, 3, 4, 10 };
            int size = arr.Length;

            int result = Program.FindMinT(arr, size);

            Assert.AreEqual(3, result);
        }
    }
}