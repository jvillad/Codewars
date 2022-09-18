using System;
using System.Collections.Generic;

public class Persist 
{
  public static int Persistence(long n) 
  {
    
    if( n < 10)
      return 0;
    
    long num = n;  
     
    int counter = 1;
    
    while (counter != 0) //keep computing until break if single digit
    {
      List<long> list = SplitNum(num);
      
      long result = 1;
      foreach (var item in list)
      {
        result *= item;
      }
      
      num = result;
      
      if (num < 10) 
      {
        break;
      }
      
      counter++;
      
    }
    
    return counter;
    
  }
  
  
  
  
  public static List<long> SplitNum(long num)
  {
    
    long digit = 0;
    List<long> digits = new List<long>();
    while (num != 0)
    {
      digit = num % 10;
      digits.Add(digit);
      num = num / 10;
    }
    
    return digits;
  }
  
}