using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewbitAndLitcode
{
    public static class MaxMin
    {
        //https://www.interviewbit.com/problems/max-min-05542f2f-69aa-4253-9cc7-84eb7bf739c4/
        public static int Solve(List<int> A)
        {
            int max = A.Max();
            int min = A.Min();

            return max + min;
        }

    }
}
