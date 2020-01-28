using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomlistTesting
{
    [TestClass]
    public class AddOverloadUnitTests
    {
        [TestMethod]
        public void AddOverload_AddTwoLists_GetIndexCount()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2 };
            CustomList<int> MyList2 = new CustomList<int>() { 3, 4 };
            int expected = 4;
            CustomList<int> actual;
            //act
            actual = (MyList1 + MyList2);
            //assert
            Assert.AreEqual(expected, actual.Count);
        }
        [TestMethod]
        public void AddOverload_AddTwoList_IncreasedCapacity()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> MyList2 = new CustomList<int>() { 4, 5, 6 };
            int expected = 8;
            CustomList<int> actual;
            //act
            actual = (MyList1 + MyList2);
            //assert
            Assert.AreEqual(expected, actual.Capacity);
        }
        [TestMethod]
        public void AddOverload_AddTwoLists_ReturnStringOfAddedLists()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2 };
            CustomList<int> MyList2 = new CustomList<int>() { 3, 4 };
            string expected = "1234";
            CustomList<int> actual;
            //act
            actual = MyList1 + MyList2;
            //assert
            Assert.AreEqual(expected, actual.ToString());
        }
        [TestMethod]
        public void AddOverload_AddTwoListsOfDifferentCounts_IncreasedCount()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2 };
            CustomList<int> MyList2 = new CustomList<int>() { 3, 4, 5 };
            int expected = 5;
            CustomList<int> actual;
            //act
            actual = (MyList1 + MyList2);
            //assert
            Assert.AreEqual(expected, actual.Count);
        }
    }
}
