using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leader
{
    class Leader
    {
        static void Main(string[] args)
        {
            int[] A = { 2,6,4,6,6,4,6,6,6,6,8,8,8 };
            Console.WriteLine(solution(A).ToString());
            Console.ReadLine();
        }

        static int solution(int[] A)
        {
            int leader = -1, count = 0, n = A.Length, size = 0, value = A[0], candidate;

            for (int i = 0; i < n; i++)
            {
                if (size == 0)
                {
                    size = 1;
                    value = A[i];
                }
                else
                {
                    if (value != A[i])
                    {
                        size--;
                    }
                    else
                    {
                        size++;
                    }
                }
            }

            candidate = size > 0 ? value : -1;

            for (int i = 0; i < n; i++)
            {
                if (A[i] == candidate)
                {
                    count++;
                }
            }

            if (count > n / 2)
            {
                leader = candidate;
            }

            return leader;
        }
    }
}
