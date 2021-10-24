using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsMaxTwoNum
{
    public class GenericMaximum<T> where T : IComparable
    {
        public T[] Value;

        /// <summary>
        /// this method is created for intialise the constructor of instance variable
        /// </summary>
        /// <param name="input_val1"></param>
        /// <param name="input_val2"></param>
        /// <param name="input_val3"></param>
        public GenericMaximum(T[] value)
        {
            this.Value = value;
        }
        /// <summary>
        /// This method is created for finding max for given type
        /// params is used for optional
        /// </summary>
        /// <param name="val1"></param>
        /// <param name="val2"></param>
        /// <param name="val3"></param>
        /// <returns></returns>
        public T MaxValue(params T[] values)
        {
            var sorted_values = (values);
            return sorted_values[1];
        }

        /// <summary>
        /// This method is created calling maxvalue method
        /// </summary>
        /// <returns>max</returns>
        public T MaxMethod()
        {
            var max = MaxValue(this.Value);
            return max;
        }

        /// <summary>
        /// This  method is printing maximum generic value
        /// </summary>
        /// <param name="="values"></param>
        public void printMaxValue()
        {
            var max = MaxValue(this.Value);
            Console.WriteLine("Maximum Value is " + max);
        }
        static void Main(string[] args)
        {
            int[] arr = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(arr);
            generic.printMaxValue();
        }
    }
}