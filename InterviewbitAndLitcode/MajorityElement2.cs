namespace InterviewbitAndLitcode
{
    public class MajorityElement2
    {
        public IList<int> MajorityElementMethod(int[] nums)
        {
            IList<int> result = new List<int>();

            if (nums == null || nums.Length == 0)
                return result;

            int candidate1 = 0, count1 = 0;
            int candidate2 = 0, count2 = 0;

            // Step 1: Find the two potential candidates
            foreach (int num in nums)
            {
                if (num == candidate1)
                {
                    count1++;
                }
                else if (num == candidate2)
                {
                    count2++;
                }
                else if (count1 == 0)
                {
                    candidate1 = num;
                    count1 = 1;
                }
                else if (count2 == 0)
                {
                    candidate2 = num;
                    count2 = 1;
                }
                else
                {
                    count1--;
                    count2--;
                }
            }

            // Step 2: Verify the candidates
            count1 = 0;
            count2 = 0;

            foreach (int num in nums)
            {
                if (num == candidate1)
                    count1++;
                else if (num == candidate2)
                    count2++;
            }

            if (count1 > nums.Length / 3)
                result.Add(candidate1);
            if (count2 > nums.Length / 3)
                result.Add(candidate2);

            return result;
        }
    }
}
