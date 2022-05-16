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
            myAL.Add("Hello");
            myAL.Add("World");
            myAL.Add("!");

            // Displays the properties and values of the ArrayList.
            Console.WriteLine("myAL");
            Console.WriteLine("    Count:    {0}", myAL.Count);
            Console.Write("    Values:");
            foreach (Object obj in myAL)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
