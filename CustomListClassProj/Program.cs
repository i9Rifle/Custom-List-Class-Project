using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
