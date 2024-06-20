using System;
using System.Collections.Generic;

namespace GenericClasses
{
    // Generic class definition
    public class GenericList<T>
    {
        private List<T> list = new List<T>();

        // Method to add an item to the list
        public void AddItem(T item)
        {
            list.Add(item);
        }

        // Method to get an item from the list by index
        public T GetItem(int index)
        {
            if (index >= 0 && index < list.Count)
            {
                return list[index];
            }
            throw new IndexOutOfRangeException("Index is out of range");
        }

        // Method to display all items in the list
        public void DisplayItems()
        {
            foreach (T item in list)
            {
                Console.WriteLine(item);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the generic class with int type
            GenericList<int> intList = new GenericList<int>();
            intList.AddItem(1);
            intList.AddItem(2);
            intList.AddItem(3);
            Console.WriteLine("Integer List:");
            intList.DisplayItems();

            // Create an instance of the generic class with string type
            GenericList<string> stringList = new GenericList<string>();
            stringList.AddItem("Hello");
            stringList.AddItem("World");
            Console.WriteLine("String List:");
            stringList.DisplayItems();

            // Create an instance of the generic class with custom type
            GenericList<DateTime> dateList = new GenericList<DateTime>();
            dateList.AddItem(DateTime.Now);
            dateList.AddItem(DateTime.UtcNow);
            Console.WriteLine("DateTime List:");
            dateList.DisplayItems();
        }
    }
}
