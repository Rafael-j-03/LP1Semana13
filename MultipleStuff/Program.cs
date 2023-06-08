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

            // Call the GetMaxMin2 method with a class
            SuperList.MaxMin maxMin = list.GetMaxMin2();
            Console.WriteLine($"Version 2 - Max: {maxMin.Max}, Min: {maxMin.Min}");

            // Call the GetMaxMin3 method with a reference tuple
            Tuple<double, double> maxMinTuple = SuperList.GetMaxMin3(list);
            Console.WriteLine($"Version 3 - Max: {maxMinTuple.Item1}, Min: {maxMinTuple.Item2}");
        }
    }
}
