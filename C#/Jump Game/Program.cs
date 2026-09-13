bool CanJump(int[] nums)
{
    if (nums.Length == 1) return true;
    int reach = 0;
    for (int i = 0; i < nums.Length-1; i++)
    {
        
        if (nums.Length - 1 - i <= nums[i] && reach >= i)
        {
            return true;
        }
        if (reach < i)
        {
            break;
        }
        reach = i + nums[i] > reach ? i + nums[i] : reach;
    }
    return false;
}


int[] prices = new int[5] { 2, 3, 1, 1, 4 };

Console.WriteLine(CanJump(prices));