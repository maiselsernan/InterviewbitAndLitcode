namespace InterviewbitAndLitcode
{
    //https://leetcode.com/problems/remove-element
    public class RemoveElement
    {
        public int RemoveElementMethod(int[] nums, int val)
        {
            var tempArray = new int[nums.Length];
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    tempArray[j] = nums[i];
                    j++;
                }
            }
            for (int i = 0; i < tempArray.Length; i++)
            {
                nums[i] = tempArray[i];
            }
            return j;
        }
    }
}
