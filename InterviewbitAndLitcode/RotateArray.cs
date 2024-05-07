namespace InterviewbitAndLitcode
{
    public class RotateArray
    {
        public void RotateArrayMethod(int[] nums, int k)
        {
            k = k % nums.Length;
            int[] temp = new int[nums.Length];

            Array.Copy(nums, nums.Length - k, temp, 0, k);

            Array.Copy(nums, 0, temp, k, nums.Length - k);

            Array.Copy(temp, nums, nums.Length);
        }

       
    }
}
