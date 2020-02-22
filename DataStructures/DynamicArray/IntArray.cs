using System;
using System.Collections;

namespace DynamicArray
{
    public class IntArray : IEnumerable
    {
        private int[] arr;
        private int len = 0;// length of element in the array
        private int capacity;// exact length array size (double than the len)

        public IntArray(int capacity)
        {
            if (capacity < 0) { throw new ArgumentException("Illegal Capacity: " + capacity); }
            this.capacity = capacity;
            arr = new int[capacity];
        }

        public int size()
        {
            return len;
        }

        public bool isEmpty()
        {
            bool isEmpty = (len == 0) ? true : false;
            return isEmpty;
        }

        public void set(int number, int index)
        {
            if (index > capacity) { throw new IndexOutOfRangeException($"Index should be less than capacity: {capacity}"); }
            arr[index] = number;
        }

        public int get(int index)
        {
            return arr[index];
        }

        public void add(int number)
        {
            int[] temp = new int[len];
            if (len == capacity)
            {
                if (capacity == 0) { capacity = 1; } else { capacity *= 2; };
                temp = arr;
                arr = new int[capacity];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = temp[i];
                }
            }
            arr[len] = number;
            len++;
        }

        public void removeAt(int index)
        {
            if (len > 0)
            {
                for (int i = index; i < len - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[len - 1] = 0;
                len--;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}