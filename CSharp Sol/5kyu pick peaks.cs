using System;
using System.Collections.Generic;
public class PickPeaks
{
    public static Dictionary<string, List<int>> GetPeaks(int[] nums)
    {
            List<int> pos = new List<int>();
            List<int> peaks = new List<int>();
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>()
            {
               
            };

            bool flag = false;
            int x = 0;
           
            for (int i = 1; i < nums.Length - 1; i++)
            {
               
                if (nums[i] != nums[i - 1])
                {
                   flag = false;
                }

                if (nums[i] > nums[i - 1])
                {
                    flag = true;
                    x = i;
                }

                if (nums[i + 1] < nums[i]&& flag )
                {
                    peaks.Add(nums[i]);
                    pos.Add(x);
                }
              }

            result.Add("pos", pos);
            result.Add("peaks", peaks);
              
        return result;
     
    }
}