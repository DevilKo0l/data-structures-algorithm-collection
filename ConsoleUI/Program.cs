using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DynamicArrayImplementation;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray newDynamicArray = new DynamicArray(2);
            newDynamicArray.add(1);
            newDynamicArray.add(2);
            newDynamicArray.add(3);
            //newDynamicArray.add(4);
            //newDynamicArray.add(5);
            //newDynamicArray.add(6);
            Console.WriteLine(newDynamicArray.size());
            
        }
    }
}
