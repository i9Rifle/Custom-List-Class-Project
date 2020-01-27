using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomlistTesting
{
    [TestClass]
    public class RemoveUnitTests
    {
        [TestMethod]
        public void Remove_TwoValues_Count()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 2;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Remove(value1);
            MyList.Remove(value2);
            actual = MyList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_TwoValues_SecondIndex()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 4;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Remove(value1);
            MyList.Remove(value2);
            actual = MyList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_ThreeValues_Count()
        {
            //arange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 2;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            MyList.Remove(value3);
            MyList.Remove(value4);
            MyList.Remove(value5);
            actual = MyList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_TheeNonsequentialValues_SecondIndex()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 4;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            MyList.Remove(value1);
            MyList.Remove(value3);
            MyList.Remove(value5);
            actual = MyList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Remove_FiveValues_ArrayCapacity()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int value6 = 6;
            int value7 = 7;
            int value8 = 8;
            int value9 = 9;
            int value10 = 10;
            int expected = 16;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            MyList.Add(value6);
            MyList.Add(value7);
            MyList.Add(value8);
            MyList.Add(value9);
            MyList.Add(value10);
            MyList.Remove(value1);
            MyList.Remove(value2);
            MyList.Remove(value3);
            MyList.Remove(value4);
            MyList.Remove(value5);
            actual = MyList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }

    }
}
