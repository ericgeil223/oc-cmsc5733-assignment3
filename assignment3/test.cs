using System;
using System.Collections.Generic;
using System.Text;
using assignment3;
namespace assignment3
{
    public class Test
    {
        readonly int[] TestArr;
        readonly int[] SearchNums;
        public Test(int[] Arr, int[] Nums)
        {
           TestArr  =Arr;
           SearchNums = Nums;
        }
 
        public void Unittest()
        {
            foreach (int i in SearchNums)
            {
                if (Program.InArr(TestArr, i))
                {
                    System.Console.WriteLine("Found");
                }
                else
                {
                    System.Console.WriteLine("Not Found");
                }
            }

        }

    }
}
