using System;
using assignment3;

namespace assignment3
{
    
    public static class Program
    {
        public static bool InArr (int[] arr, int target)
        {
            foreach (int i in arr)
            {
                if (target == i)
                {
                    return true;
                }
            }
            return false;
        }
        static void Main(string[] args)
        {
            int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
            int[] search = { 4, 9, 10, -2 };
            Test unit = new Test(numbers, search);
            unit.Unittest();
        }
    }
}
