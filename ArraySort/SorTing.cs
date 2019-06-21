using System;

namespace ArraySort
{
    public class SorTing
    {
        public int Sort(int a)
        {
            int result;
            int[] nums = new int[] { 1, 2, 7, 4, 5 };
            int temp;
            if (a == 1)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }

            }

            else
            {
               
                {
                    for (int i = 0; i < nums.Length; i++)
                    {
                        for (int j = i + 1; j < nums.Length; j++)
                        {
                            if (nums[i] < nums[j])
                            {
                                temp = nums[i];
                                nums[i] = nums[j];
                                nums[j] = temp;
                            }
                        }
                    }
                }
            }
            
        }
    }
}