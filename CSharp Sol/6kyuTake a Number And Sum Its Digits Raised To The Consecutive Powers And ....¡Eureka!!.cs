using System;
using System.Collections.Generic;


public class SumDigPower 
{
  public static long[] SumDigPow(long a, long b) 
    {
      
      List<long> range = new List<long>();
      
      for (long i = a; i < b; i++)
      {
        range.Add(i);
      }
      
      List<long> holderList = new List<long>();
      List<long> resultList = new List<long>();
      
      long holder = 0;
      foreach (var num in range)
      {
        int pow = 1;
        double result = 0;
        
        holder = num;
        
        while (holder != 0 )
        {
          holderList.Add(holder % 10);
          holder = holder / 10;
        }

        holderList.Reverse();
        foreach (var item in holderList)
        {
          result += Math.Pow(item, pow);
          pow++;   
        }
        
        if (result == num)
        {
          resultList.Add(Convert.ToInt64(result));
        }
          
          holderList.Clear();
      }
    
    return resultList.ToArray();
      
    
  }
}