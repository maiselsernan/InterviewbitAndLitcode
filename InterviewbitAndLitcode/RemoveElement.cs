namespace InterviewbitAndLitcode
{
    //https://leetcode.com/problems/remove-element
    public class RemoveElement
    {
        public int RemoveElementMethod(int[] nums, int val)
        {
            var offset = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[offset] = nums[i];
                    offset++;
                }
            }
            return offset;
        }
    }
}
