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

        public int Length()
        {
            return len;
        }

        public bool IsEmpty()
        {
            bool isEmpty = (len == 0) ? true : false;
            return isEmpty;
        }

        public void Set(int number, int index)
        {
            if (index > capacity || index < 0) { throw new IndexOutOfRangeException($"Index shouldn't be less than 0 and greater than capacity({capacity})"); }
            arr[index] = number;
        }

        public int Get(int index)
        {
            return arr[index];
        }

        public void ShrinkSize()
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
        public void Add(int number)
        {
            DoubleLength();
            arr[len] = number;
            len++;
        }

        //grow size of an array
        private void DoubleLength()
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

        //Add element at  a specific index
        public void AddAt(int index, int number)
        {
            if (len == capacity)
            {
                DoubleLength();
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
        public void Remove()
        {
            if (capacity > 0)
            {
                arr[len - 1] = 0;
                capacity--;
                len--;
            }
        }

        //funtion remove number at specific index
        //shift all element in the right of given index to the left
        public void RemoveAt(int index)
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