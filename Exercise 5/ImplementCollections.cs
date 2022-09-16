using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ImplementCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exercise1 = "Today I will finish my homework on time";

            string[] text = exercise1.Split(" ");

            Stack<string> myStack = new Stack<string>();

            foreach (var item in text)
            {
                myStack.Push(item);
            }

            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

            SortedList<int, string> studentsList = new SortedList<int, string>(new ReverseComparer());
            studentsList.Add(92, "Menganita");
            studentsList.Add(50, "Pepito");
            studentsList.Add(30, "Juanito");

            foreach (KeyValuePair<int, string> item in studentsList)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

        }
    }
    public class ReverseComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return -x.CompareTo(y);
        }
    }
}
