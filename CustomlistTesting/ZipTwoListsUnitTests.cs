using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomlistTesting
{
    [TestClass]
    public class ZipTwoListsUnitTests
    {
        [TestMethod]
        public void Zip_DoesItZip_IntoNewCustomList()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> MyList2 = new CustomList<int>() { 2, 4, 6 };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5, 6 };
            CustomList<int> actual;
            //act
            actual = MyList1.Zip(MyList1,MyList2);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_DoesItZip_SecondListLonger()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 3, };
            CustomList<int> MyList2 = new CustomList<int>() { 2, 4, 5 };
            CustomList<int> expected = new CustomList<int>() { 2, 1, 4, 3, 5, };
            CustomList<int> actual;
            //act
            actual = MyList1.Zip(MyList1, MyList2);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void Zip_DoesItZip_FirstListLonger()
        {
            //arrange
            CustomList<int> MyList1 = new CustomList<int>() { 1, 3, 5 };
            CustomList<int> MyList2 = new CustomList<int>() { 2, 4, };
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4, 5 };
            CustomList<int> actual;
            //act
            actual = MyList1.Zip(MyList1, MyList2);
            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
