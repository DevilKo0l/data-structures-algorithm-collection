using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class GenericArray<T> : IEnumerable
    {
        private T[] arr;
        private int len = 0;// length of element in the array
        private int capacity;// exact length array size (double than the len)

        //Constructor initialize value
        public GenericArray(int capacity)
        {
            if (capacity < 0) { throw new ArgumentException("Illegal Capacity: " + capacity); }
            this.capacity = capacity;
            arr = new T[capacity];
        }

        public int length()
        {
            return len;
        }

        public bool isEmpty()
        {
            bool isEmpty = (len == 0) ? true : false;
            return isEmpty;
        }

        public void set(T data, int index)
        {
            if (index > capacity||index<0) { throw new IndexOutOfRangeException($"Index shouldn't be less than zero be less than capacity({capacity})"); }
            arr[index] = data;
        }

        public T get(int index)
        {
            return arr[index];
        }

        public void shrinkSize()
        {
            T[] temp = null;
            if (capacity > 0)
            {
                temp = new T[len];
                for (int i = 0; i < len; i++)
                {
                    temp[i] = arr[i];
                }
                capacity = len;
                arr = temp;
            }
        }

        //Add element at the end of an array
        public void add(T data)
        {
            doubleLength();
            arr[len] = data;
            len++;
        }

        //grow size of an array
        private void doubleLength()
        {
            T[] temp = null;
            if (len == capacity)
            {
                temp = new T[len];
                if (capacity == 0) { capacity = 1; } else { capacity *= 2; };
                temp = arr;
                arr = new T[capacity];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = temp[i];
                }
            }
        }

        public void addAt(int index, T data)
        {
            if (len == capacity)
            {
                doubleLength();
            }
            if (capacity > 0)
            {
                for (int i = len - 1; i >= index; i--)
                {
                    arr[i + 1] = arr[i];
                }
                arr[index] = data;
                len++;
            }
        }

        //funtion remove the last number
        public void remove()
        {
            if (capacity > 0)
            {
                arr[len - 1] = default(T);
                capacity--;
            }
        }

        //funtion remove number at specific index
        //shift all element in the right of given index to the left
        public void removeAt(int index)
        {
            if (len > 0)
            {
                for (int i = index; i < len - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[len - 1] = default(T);
                len--;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}
