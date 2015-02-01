using System;
using System.Collections.Generic;

class LongestNonDecreasingSubsequence
{
    static void Main()
    {

        string input = Console.ReadLine();
        string[] numbers = input.Split(' '.ToString().ToCharArray(),
                                        StringSplitOptions.RemoveEmptyEntries);
        int[] nums = new int[numbers.Length];
        int max = 0;
        int lastIndex = 0;
        int count = 0;
        int constMax = 0;
        List<int> maxCount = new List<int>();
        List<int> constMaxCount = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = int.Parse(numbers[i]);
        }
        for (int i = 0; i < nums.Length - 1; i++)
        {
            max = 0;
            maxCount = new List<int>();
            maxCount.Add(nums[i]);
            count = 0;
            lastIndex = i;
            for (int j = i; j < nums.Length - 1; j++)
            {
                if (nums[lastIndex] <= nums[lastIndex + 1])
                {
                    max++;
                    maxCount.Add(nums[lastIndex + 1]);
                    count++;
                    lastIndex++;
                }
                else if (count > 0)
                {
                    if (maxCount[count] > nums[j] && maxCount[count - 1] < nums[j])
                    {
                        maxCount[count] = nums[j];
                        lastIndex = j;
                    }
                }
            }
            if (max > constMax)
            {
                constMax = max;
                constMaxCount = maxCount;
            }
        }
        if (nums[nums.Length - 1] > nums[nums.Length - 2])
        {
            constMaxCount.Add(nums[nums.Length - 1]);
        }
        Console.WriteLine(String.Join(" ", constMaxCount));
    }
}


