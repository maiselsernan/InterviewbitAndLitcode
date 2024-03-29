﻿namespace InterviewbitAndLitcode
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii
    public class RemoveDuplicatesFromSortedArray2
    {
        public int RemoveDuplicates(int[] nums)
        {
            //if (nums.Length == 0)
            //{
            //    return 0;
            //}
            //int i = 0;
            //int count = 1;
            //for (int j = 1; j < nums.Length; j++)
            //{
            //    if (nums[j] == nums[i])
            //    {
            //        count++;
            //        if (count <= 2)
            //        {
            //            i++;
            //            nums[i] = nums[j];
            //        }
            //    }
            //    else
            //    {
            //        i++;
            //        nums[i] = nums[j];
            //        count = 1;
            //    }
            //}
            //return i + 1;
            var replaceIndex = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (replaceIndex - 2 >= 0 && nums[replaceIndex - 2] == nums[i])
                {
                    continue;
                }
                nums[replaceIndex] = nums[i];
                replaceIndex++;
            }
            return replaceIndex;
        }
    }
}
