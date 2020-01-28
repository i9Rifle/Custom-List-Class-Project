using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomlistTesting
{
    [TestClass]
    public class RemoveOverloadUnitTests
    {
        [TestMethod]
        public void RemoveOverload_RemoveSimilarValues_FromDifferentSizeLists()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2, 3 };
            CustomList<int> MyList2 = new CustomList<int>() { 2, 3, 4, 5 };
            CustomList<int> expected = new CustomList<int>() { 1 };
            CustomList<int> actual;
            //act
            actual = (MyList1 - MyList2);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void RemoveOverload_RemoveSimilarValue_FromSameCapacityLists()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> MyList2 = new CustomList<int>() { 3, 4, 5, 6, 7 };
            CustomList<int> expected = new CustomList<int>() { 1, 2 };
            CustomList<int> actual;
            //act
            actual = (MyList1 - MyList2);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void RemoveOverload_DidNotRemoveValues_IfNoneFound()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> MyList2 = new CustomList<int>() { 5, 6, 7, 8 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> actual;
            //act
            actual = (MyList1 - MyList2);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void RemoveOverload_RemovedValues_CheckCapacity()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> MyList2 = new CustomList<int>() { 5, 6, 7, 8 };
            int expected = 0;
            int actual;
            //act
            actual = (MyList1.Capacity - MyList2.Capacity);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
