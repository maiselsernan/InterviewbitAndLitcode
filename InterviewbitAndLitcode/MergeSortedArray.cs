namespace InterviewbitAndLitcode
{
    //https://leetcode.com/problems/merge-sorted-array/submissions/1202374046/
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {

            var nums1Index = m - 1;
            var nums2Index = n - 1;
            var mergedIndex = m + n - 1;

            while (nums2Index >= 0)
            {
                if (nums1Index >= 0 && nums1[nums1Index] > nums2[nums2Index])
                {
                    nums1[mergedIndex] = nums1[nums1Index];
                    nums1Index--;
                }
                else
                {
                    nums1[mergedIndex] = nums2[nums2Index];
                    nums2Index--;
                }
                mergedIndex--;
            }
        }
    }
}
