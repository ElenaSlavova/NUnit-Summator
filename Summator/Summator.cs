using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summator
{
    public static class Summator
    {

        public static long Sum(int[] arr)
        {
            long sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return sum;

        }

        public static double Average(int[] arr, string operation)
        {
            double sum = 0;
            if (operation == "multiply")
            {
                sum = 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (operation == "add")
                {
                    sum += arr[i];
                }
                else if (operation == "substract")
                {
                    if (i < 1)
                    {
                        sum = arr[0];
                    }
                    if (i + 1 < arr.Length)
                    {
                        sum -= arr[i + 1];
                    }
                }
                else if (operation == "multiply")
                {
                    sum *= arr[i];
                }
            }
            return sum / arr.Length;
        }
    }
}
