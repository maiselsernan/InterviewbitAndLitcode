namespace InterviewbitAndLitcode
{
    //https://leetcode.com/problems/jump-game/description/?envType=study-plan-v2&envId=top-interview-150
    public class CanJump
    {
        public bool CanJumpMethod(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > max)
                    return false;
                max = Math.Max(max, i + nums[i]);
            }
            return true;
        }
       
    }
}
