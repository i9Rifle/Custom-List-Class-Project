using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomListTesting
{
    [TestClass]
    public class AddUnitTests
    {
        [TestMethod]
        public void Add_TwoValues_Count()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int expected = 2;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            actual = MyList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Add_TwoValues_SecondIndex()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 5;
            int value2 = 10;
            int expected = 10;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            actual = MyList[1];
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_FiveValues_Count()
        {
            //arange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 5;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            actual = MyList.Count;
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_FiveValues_IndexAtTwo()
        {
            //arange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 3;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            actual = MyList[2];
            //assert
            Assert.AreEqual(expected, actual);
        }
        public void Add_FiveValues_IncreasedArrayCapacity()
        {
            //
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int value5 = 5;
            int expected = 8;
            int actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            actual = MyList.Capacity;
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
