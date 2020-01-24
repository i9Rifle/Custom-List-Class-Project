using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListClassProj
{
    public class CustomList<T>
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
            if(count == capacity)
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
            
        }
    }
}
