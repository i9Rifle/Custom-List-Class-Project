using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    public class CustomList<T> : IEnumerable
    {   

        T[] items;
        int capacity;
        int count;
        public int Count { get { return count; } }
        public int Capacity { get { return capacity; } }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    return items[index];
                }
            }
            set
            {
                if (index < 0 || index > count)
                {
                    throw new IndexOutOfRangeException();
                }
                else
                {
                    items[index] = value;
                }
            }
        }
        public CustomList()
        {
            count = 0;
            capacity = 4;
            items = new T[4];
        }
        public void Add(T item)
        {
            if (count == capacity)
            {
                T[] tempArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    tempArray[i] = items[i];
                }
                capacity *= 2;
                items = new T[capacity];
                for (int i = 0; i < count; i++)
                {
                    items[i] = tempArray[i];
                }
            }
            items[count] = item;
            count++;
        }
        public void Remove(T item)
        {
            bool foundValue = false;
            T[] tempArray = new T[capacity];
            for (int i = 0, j = 0; i < count; i++, j++)
            {
                if (!items[i].Equals(item) || foundValue)
                {
                    tempArray[j] = items[i];
                }
                else
                {
                    j--;
                    foundValue = true;
                }
            }
            if (foundValue)
            {
                count--;
            }
            items = tempArray;
        }
        public override string ToString()
        {
            StringBuilder newStringBuild = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                newStringBuild.Append(items[i]);
            }
            return newStringBuild.ToString();
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return items[i];
            }
        }
        public static CustomList<T> operator + (CustomList<T> MyList1, CustomList<T> MyList2)
        {
            CustomList<T> MyList = new CustomList<T>();
            for (int i = 0; i < MyList1.count; i++)
            {
                MyList.Add(MyList1[i]);
            }
            for (int i = 0; i < MyList2.count; i++)
            {
                MyList.Add(MyList2[i]);
            }
            return MyList;
        }
        public static CustomList<T> operator - (CustomList<T> MyList1, CustomList<T> MyList2)
        {
            CustomList<T> MyList = new CustomList<T>();
            for (int i = 0; i < MyList1.count; i++)
            {
                MyList.Add(MyList1[i]);
            }
            for (int i = 0; i < MyList2.count; i++)
            {
                MyList.Remove(MyList2[i]);   
            }
            return MyList;
        }
    }
}
