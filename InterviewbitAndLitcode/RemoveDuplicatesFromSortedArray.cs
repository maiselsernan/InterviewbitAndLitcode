namespace InterviewbitAndLitcode
{
    //https://leetcode.com/problems/remove-duplicates-from-sorted-array
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            var tempList = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!tempList.Any(x => x == nums[i]))
                {
                    tempList.Add(nums[i]);
                }
            }
            for (int i = 0; i < tempList.Count; i++)
            {
                nums[i] = tempList[i];
            }
            return tempList.Count;
        }
    }
}
