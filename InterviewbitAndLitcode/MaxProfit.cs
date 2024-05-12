namespace InterviewbitAndLitcode
{
    public class MaxProfit
    {
        //7, 1, 5, 3, 6, 4
        //3,2,6,5,0,3
        public int maxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int minPrice = prices[0];
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++)
            {

                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    continue;
                }
                if ((prices[i] - minPrice) > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;
                }
            }
            return maxProfit;
        }
    }
}
