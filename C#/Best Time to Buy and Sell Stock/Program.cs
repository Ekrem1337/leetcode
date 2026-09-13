static int MaxProfit(int[] prices)
{
    int max = 0;
    int min = prices[0];

    for (int i = 1; i < prices.Length; i++)
    {
        if (prices[i] < min)
        {
            min = prices[i];
        }

        else if ((prices[i] - min) > max)
        {
            max = prices[i] - min;
        }
    }
    return max;
}


int[] prices = new int[3] { 2, 4, 1 };

Console.WriteLine(MaxProfit(prices));