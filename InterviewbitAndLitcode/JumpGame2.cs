using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewbitAndLitcode
{
    public class JumpGame2
    {
        public int Jump(int[] nums)
        {
            int n = nums.Length;
            if (n == 1)
                return 0;
            int[] dp = new int[n];
            dp[0] = 0;
            for (int i = 1; i < n; i++)
            {
                dp[i] = int.MaxValue;
                for (int j = 0; j < i; j++)
                {
                    if (j + nums[j] >= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[j] + 1);
                    }
                }
            }
            return dp[n - 1];
        }
    }
}
