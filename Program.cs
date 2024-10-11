using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        public static int[] nums = new int[10];

        public static int[] values()
        {
            var rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                nums[i] = rand.Next(101);

            }
            return nums;
        }

        public static int Min()
        {
            int min = nums[0];
            foreach (int i in nums)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            return min;
        }
        public static int Max()
        {
            int max = nums[0];
            foreach (int i in nums)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            return max;
        }

        static void Main(string[] args)
        {
            values();
            Console.WriteLine(Min());
            Console.WriteLine(Max());
        }
    }
    }

