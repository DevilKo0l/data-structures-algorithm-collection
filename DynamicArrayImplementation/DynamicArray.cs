using System;

namespace DynamicArrayImplementation
{
    public class DynamicArray
    {
        private int[] arr;
        private int len;// length of element in the array
        private int capacity;// exact length array size (double than the len)

        public DynamicArray(int capacity)
        {
            if (capacity < 0) { throw new ArgumentException("Illegal Capacity: " + capacity); }
            this.capacity = capacity;
            arr = new int[capacity];
            len = 0;
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

        public void add(int number)
        {
            int[] temp = new int[len];
            if (len == capacity)
            {
                temp = arr;
                capacity = capacity * 2;
                arr = new int[capacity];
                arr = temp;
            }
            arr[len] = number;
            len++;
        }
    }
}