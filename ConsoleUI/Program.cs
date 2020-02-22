using DynamicArray;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Play around with the class here
            GenericArray<string> arr = new GenericArray<string>(3);
            arr.add("fdfdf");
            arr.add("dd");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("remove");
            arr.removeAt(1);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("add");
            arr.add("cac");
            arr.add("lon");
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}