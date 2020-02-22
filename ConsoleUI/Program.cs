using DynamicArray;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IntArray intArray = new IntArray(1);
            intArray.add(1);
            intArray.add(2);
            intArray.add(3);
            intArray.add(4);
            intArray.add(5);
            intArray.add(6);
            intArray.add(7);
            intArray.add(8);
            intArray.add(9);
            intArray.add(10);

            foreach (int item in intArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}