using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataStructure.LinearList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.LinearList.Tests
{
    [TestClass()]
    public class LinearListTestsTests
    {
        [TestMethod()]
        public void TestSequentialList()
        {
            ILinearList<string> list = new SequentialList<string>(5);
            TestLinearList(list);
        }

        [TestMethod()]
        public void TestLinkList()
        {
            ILinearList<string> list = new LinkList<string>();
            TestLinearList(list);
        }

        void TestLinearList(ILinearList<string> list)
        {
            Assert.AreEqual(list.IsEmpty(), true);
            Assert.AreEqual(list.Length, 0);

            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");

            Assert.AreEqual(list.LocateItem("d"), 3);

            Assert.AreEqual(list.IsEmpty(), false);
            Assert.AreEqual(list.Length, 5);
            Assert.AreEqual(list.GetItem(2), "c");
            //Assert.AreEqual(list.isFull(), true);

            list.Delete(4);

            Assert.AreEqual(list.Length, 4);

            list.Add("e");
            Assert.AreEqual(list.GetItem(3), "d");
            Assert.AreEqual(list.GetItem(4), "e");
            list.Delete(3);
            Assert.AreEqual(list.GetItem(3), "e");

            list.Clear();
            Assert.AreEqual(list.Length, 0);
        }
    }
}