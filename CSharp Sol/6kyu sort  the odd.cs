using System;
using System.Collections.Generic;

public class Kata
{
  public static int[] SortArray(int[] numArr)
  {
    if (numArr.Length == 0)
      return numArr;
    
    List<int> oddList = new List<int>();
    foreach (var num in numArr)
    {
      if (num%2 != 0)
      {
        oddList.Add(num);
      }
    }    
    oddList.Sort();
    
    for (int i = 0; i < numArr.Length; i++)
    {
      if (numArr[i]%2 !=0)
      {
        foreach (var odd in oddList)
        {
          numArr[i] = odd;
          oddList.Remove(odd);
          break;
        }
      }
    }
    
    return numArr;
    
  }
}