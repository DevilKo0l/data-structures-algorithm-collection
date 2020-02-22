using System;
using System.Collections;

namespace DynamicArray
{
    public class IntArray : IEnumerable
    {
        private int[] arr;
        private int len = 0;// length of element in the array
        private int capacity;// exact length array size (double than the len)

        //Constructor initialize value
        public IntArray(int capacity)
        {
            if (capacity < 0) { throw new ArgumentException("Illegal Capacity: " + capacity); }
            this.capacity = capacity;
            arr = new int[capacity];
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

        public void set(int number, int index)
        {
            if (index > capacity) { throw new IndexOutOfRangeException($"Index should be less than capacity({capacity})"); }
            arr[index] = number;
        }

        public int get(int index)
        {
            return arr[index];
        }

        public void shrinkSize()
        {
            int[] temp = null;
            if (capacity > 0)
            {
                temp = new int[len];
                for (int i = 0; i < len; i++)
                {
                    temp[i] = arr[i];
                }
                capacity = len;
                arr = temp;
            }
        }

        //Add element at the end of an array
        public void add(int number)
        {
            doubleLength();
            arr[len] = number;
            len++;
        }

        //grow size of an array
        private void doubleLength()
        {
            int[] temp = null;
            if (len == capacity)
            {
                temp = new int[len];
                if (capacity == 0) { capacity = 1; } else { capacity *= 2; };
                temp = arr;
                arr = new int[capacity];
                for (int i = 0; i < len; i++)
                {
                    arr[i] = temp[i];
                }
            }
        }

        public void addAt(int index, int number)
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
                arr[index] = number;
                len++;
            }
        }

        //funtion remove the last number
        public void remove()
        {
            if (capacity > 0)
            {
                arr[len - 1] = 0;
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