
using System.Security;

static int RemoveElement(int[] nums, int val)
{
    int currentInValidindex = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] == val)
        {
            continue;
        }
        else
        {
            nums[currentInValidindex] = nums[i];
            currentInValidindex++;
        }
    }

    return currentInValidindex;

}



int k = RemoveElement(new int[8] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2);
Console.WriteLine(k);