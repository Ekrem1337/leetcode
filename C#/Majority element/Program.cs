int MajorityElement(int[] nums)
{
    int maxCount = 0;
    int currentNumber=0;

    for (int i = 0; i < nums.Length; i++)
    {
        if(maxCount == 0)
        {
            currentNumber = nums[i];    
        }
        maxCount += (currentNumber == nums[i]) ? 1 : -1;
    }

    return currentNumber;
}


int[] array = [2, 2, 1, 1, 1, 2, 2];

MajorityElement(array);