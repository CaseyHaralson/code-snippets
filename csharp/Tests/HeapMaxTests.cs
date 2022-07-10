using csharp.Examples;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Tests
{
    [TestClass]
    public class HeapMaxTests
    {
        [TestMethod]
        public void ShouldPeekMax()
        {
            var maxHeap = new HeapMax();

            maxHeap.Add(5);
            Assert.AreEqual(5, maxHeap.Peek());

            maxHeap.Add(3);
            Assert.AreEqual(5, maxHeap.Peek());

            maxHeap.Add(17);
            Assert.AreEqual(17, maxHeap.Peek());

            maxHeap.Add(10);
            Assert.AreEqual(17, maxHeap.Peek());

            maxHeap.Add(84);
            Assert.AreEqual(84, maxHeap.Peek());

            maxHeap.Add(19);
            Assert.AreEqual(84, maxHeap.Peek());

            maxHeap.Add(6);
            Assert.AreEqual(84, maxHeap.Peek());

            maxHeap.Add(22);
            Assert.AreEqual(84, maxHeap.Peek());

            maxHeap.Add(9);
            Assert.AreEqual(84, maxHeap.Peek());
        }

        [TestMethod]
        public void ShouldPollMax()
        {
            var maxHeap = new HeapMax();
            maxHeap.Add(5);
            maxHeap.Add(3);
            maxHeap.Add(17);
            maxHeap.Add(10);
            maxHeap.Add(84);
            maxHeap.Add(19);
            maxHeap.Add(6);
            maxHeap.Add(22);
            maxHeap.Add(9);

            Assert.AreEqual(84, maxHeap.Poll());
            Assert.AreEqual(22, maxHeap.Poll());
            Assert.AreEqual(19, maxHeap.Poll());
            Assert.AreEqual(17, maxHeap.Poll());
            Assert.AreEqual(10, maxHeap.Poll());
            Assert.AreEqual(9, maxHeap.Poll());
            Assert.AreEqual(6, maxHeap.Poll());
            Assert.AreEqual(5, maxHeap.Poll());
            Assert.AreEqual(3, maxHeap.Poll());
        }

        [TestMethod]
        public void ShouldDeleteNode()
        {
            var maxHeap = new HeapMax();
            maxHeap.Add(5);
            maxHeap.Add(3);
            maxHeap.Add(17);
            maxHeap.Add(10);
            maxHeap.Add(84);
            maxHeap.Add(19);
            maxHeap.Add(6);
            maxHeap.Add(22);
            maxHeap.Add(9);

            maxHeap.Delete(17);
            maxHeap.Delete(6);
            maxHeap.Delete(21);

            Assert.AreEqual(84, maxHeap.Poll());
            Assert.AreEqual(22, maxHeap.Poll());
            Assert.AreEqual(19, maxHeap.Poll());
            Assert.AreEqual(10, maxHeap.Poll());
            Assert.AreEqual(9, maxHeap.Poll());
            Assert.AreEqual(5, maxHeap.Poll());
            Assert.AreEqual(3, maxHeap.Poll());
        }


    }
}
