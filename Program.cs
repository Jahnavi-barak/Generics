using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxTwoNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find Max Num");

            //int output = MaximumIntegerNumber(10,20,30);
            //Console.WriteLine(output);

            //double doubleOutput = MaximumNumberCheck.MaximumFloatNumber(10.23,20.34,33.32);
            //Console.WriteLine(doubleOutput);

            //string stringOutput = MaximumNumberCheck.MaximumStringNumber(10.23,20.34,33.32);
            //Console.WriteLine(stringOutput);

            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.printMaxValue();

            double[] doubleArray = { 11.2, 34.4, 4.32, 55.3, 6, 78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.printMaxValue();

            string[] stringArray = { "111","222","323","425", "543" };
            GenericMaximum<string> genericstring = new GenericMaximum<string>(stringArray);
            genericstring.printMaxValue();
        }
    }
}
