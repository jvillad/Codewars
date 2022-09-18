using System;
using System.Linq;

public static class Kata 
{
    public static int summation(int num)
    {
      //Code here
      int sum = num;
      for (int i = 1; i < num; i++)
      {
        sum += i; 
      }       
      
      return sum;
      
    }
  
}