using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arrNum)
  {
    int sum = 0;
    foreach (var num in arrNum) 
      {
        if (num < 0)
          {
          
          }
        else
        sum += num; 
      }
    return sum;
    
  }
}