using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewbitAndLitcode
{
    public class BubbleSort
    {
        public void BubbleSortMethod(int[] nums)
        {
            int n = nums.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n -1 - i; j++)
                {
                    if (nums[j] > nums[j+1])
                    {
                        var temp = nums[j];
                        nums[j] = nums[j + 1];
                        nums[j + 1] = temp;
                    }
                }
            }
        }
    }
}
