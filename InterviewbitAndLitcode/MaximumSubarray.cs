namespace InterviewbitAndLitcode
{
    public class MaximumSubarray
    {
        public static void MaximumSubarrayMethod(List<int> values, out int fromIndex, out int toIndex, out int total)
        {
            // Fill this function as an answer for question 2
            // [-2,1,-3,4,-1,2,1,-5,4]
            fromIndex = -1;
            toIndex = -1;
            total = values[0];
            var temp = 0;

            for (int i = 0; i < values.Count; i++)
            {
                if (temp < 0)
                {
                    temp = 0;
                    fromIndex = i;
                }
                temp += values[i];

                if (temp > total)
                {
                    total = temp;
                    toIndex = i;
                }
            }
        }
    }
}
