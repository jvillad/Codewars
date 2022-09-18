using System;
using System.Linq;

public static class Kata
{
  public static int SumOfDifferences(int[] arr)
  {

    if (arr.Length < 1 ) 
    {
      return 0;
    }
    else     
      
    return arr.Max() - arr.Min();
    
  }