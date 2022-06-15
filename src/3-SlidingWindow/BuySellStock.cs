namespace Algo.SlidingWindow
{
    public class BuySellStock
    {
        // [2,4,9,0,9]
        public static int MaxProfit(int[] prices) {
            int lPtr = 0;
            int rPtr = 1;
            int maxProfit = 0;
            int tmpProfit = 0;

            while(rPtr <prices.Length){
                tmpProfit = prices[rPtr] - prices[lPtr];
                if(tmpProfit < 0){
                    lPtr++;
                }else{
                    rPtr++;
                }

                if(tmpProfit > maxProfit){
                    maxProfit = tmpProfit;
                }
            }
            return maxProfit;
        }
    }
}