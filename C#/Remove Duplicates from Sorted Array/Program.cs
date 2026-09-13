static int RemoveDuplicates(int[] nums)
{
    int i = 0;
    for (int j = 1; j < nums.Length; j++)
    {
        if (nums[i] != nums[j])
        {
            i++;
            nums[i] = nums[j];
        }
    }
    return i + 1;
}

int[] nums = { 1, 1, 1, 2, 2, 3 }   ; // Input array

int k = RemoveDuplicates(nums);