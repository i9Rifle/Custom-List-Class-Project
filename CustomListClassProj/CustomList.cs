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
        public int Capacity { get { return count; } }

        public T this[int index]
        {
            get
            {
                return items[index];
            }
            set
            {
                items[index] = value;
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
            
            if(count >= capacity)
            {
                capacity *= 2;
                {
                    T[] tempArray = new T[capacity];

                    for (int i = 0; i < count; i++) 
                    {
                        tempArray[i] = items[i];
                    }
                    for(int i = 0; i < count; i++)
                    {
                        items[i] = tempArray[i];
                    }
                    //move values to temp array
                    //resize the original array
                    //move values back to OG
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
