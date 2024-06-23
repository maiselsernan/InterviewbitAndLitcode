namespace InterviewbitAndLitcode
{
    public class MaxProfit2
    {
        public int maxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
