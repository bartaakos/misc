using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxSlice
{
    class MaxSlice
    {
        static void Main(string[] args)
        {
            int[] A = { 5, -7, 3, 5, -2, 4, -1 };

            Console.WriteLine(solution(A).ToString());
            Console.ReadLine();
        }

        static int solution(int[] A)
        {
            int max_ending = 0, max_slice = 0;

            foreach (int a in A)
            {
                max_ending = Math.Max(0, max_ending + a);
                max_slice = Math.Max(max_slice, max_ending);
            }

            return max_slice;
        }
    }
}
