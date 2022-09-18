using System.Collections.Generic;
using System;

public class DigPow 
{
  public static long digPow(int number, int p) 
  {
 
    List<int> digits = new List<int>();
    
    int num = number;
    while (num != 0)
    {
      digits.Add(num % 10);
      num = num / 10;
    }
    digits.Reverse();
    
    double result = 0;
    foreach (var n in digits)
    {
      result += Math.Pow(n, p);
      p++;
    }
    
    double k = result / number;
    if (result % number == 0)
    {
      return Convert.ToInt64(k);
    }
    else
      return -1;
      
  }
}