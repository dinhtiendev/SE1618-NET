using System;
using System.Collections;

namespace Slot4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes a new ArrayList.
            ArrayList myAL = new ArrayList();
            myAL.Add("The");
            myAL.Add("quick");
            myAL.Add(5);
            myAL.Add("fox");
            myAL.Add("jumps");
            myAL.Add("over");
            myAL.Add("the");
            myAL.Add("lazy");
            myAL.Add("dog");

            // Displays the values of the ArrayList.
            Console.WriteLine("The ArrayList initially contains the following values:");
            foreach (Object obj in myAL)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();

            // Sorts the values of the ArrayList.
            myAL.Sort();

            // Displays the values of the ArrayList.
            Console.WriteLine("After sorting:");
            foreach (Object obj in myAL)
                Console.WriteLine("   {0}", obj);
            Console.WriteLine();
        }
    }
}
