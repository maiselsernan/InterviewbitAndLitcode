using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewbitAndLitcode
{
    public static class PickFromBothSides
    {
        public static int Solve(List<int> A, int B)
        {
            int n = A.Count;
            int maxSum = 0;
            int sum = 0;

            for (int i = 0; i < B; i++)
            {
                sum += A[i];
            }

            maxSum = sum;

            for (int i = 0; i < B; i++)
            {
                sum -= A[B - 1 - i];
                sum += A[n - 1 - i];
                maxSum = Math.Max(maxSum, sum);
            }

            return maxSum;
        }
    }
}
