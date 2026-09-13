int MaxProfit(int[] prices)
{
    var totalProfit = 0;
    for (int i = 0; i < prices.Length - 1; i++)
    {
        if (prices[i] < prices[i + 1])
        {
            totalProfit += prices[i + 1] - prices[i];
        }
    }
    return totalProfit;
}


int[] prices = new int[6] { 7, 1, 5, 3, 6, 4 };

Console.WriteLine(MaxProfit(prices));