using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{
    public class SuperList : List<double>
    {
        // return the max and min values in the list with out parameters
        public void GetMaxMin1(out double max, out double min)
        {
            max = this.Max();
            min = this.Min();
        }
        
        //  return the max and min values in the list a specific class
        public MaxMin GetMaxMin2()
        {
            return new MaxMin() { Max = this.Max(), Min = this.Min() };
        }

        public class MaxMin
        {
            public double Max { get; set; }
            public double Min { get; set; }
        }

        // return the max and min values in the list as a reference tuple
        public static Tuple<double, double> GetMaxMin3(SuperList list)
        {
            return new Tuple<double, double>(list.Max(), list.Min());
        }

        // return the max and min values in the list as a value tuple
        public static (double max, double min) GetMaxMin4(SuperList list)
        {
            return (list.Max(), list.Min());
        }
    }
}