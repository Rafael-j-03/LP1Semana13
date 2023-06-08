using System;

namespace MultipleStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates a SuperList instance containing multiple numbers
            SuperList list = new SuperList() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            
            double max, min;
            // Call the GetMaxMin1 method with out parameters
            list.GetMaxMin1(out max, out min);
            Console.WriteLine($"Version 1 - Max: {max}, Min: {min}");
        }
    }
}
