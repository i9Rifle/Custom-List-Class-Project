using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListClassProj;

namespace CustomlistTesting
{
    [TestClass]
    public class ToStringUnitTests
    {
        [TestMethod]
        public void MyListToString_DoesitStringifyInts_ThreeValues()
        {
            //arrange
            CustomList<int> MyList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            string expected = "123";
            string actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            actual = MyList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyListToString_StringifyListOfStrings()
        {
            //arrange
            CustomList<bool> MyList = new CustomList<bool>();
            bool value1 = true;
            bool value2 = false;
            bool value3 = true;
            string expected = "TrueFalseTrue";
            string actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            actual = MyList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MyListToString_AddStrings_IncreaseCapacity()
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
            string expected = "1234567";
            string actual;
            //act
            MyList.Add(value1);
            MyList.Add(value2);
            MyList.Add(value3);
            MyList.Add(value4);
            MyList.Add(value5);
            MyList.Add(value6);
            MyList.Add(value7);
            actual = MyList.ToString();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
