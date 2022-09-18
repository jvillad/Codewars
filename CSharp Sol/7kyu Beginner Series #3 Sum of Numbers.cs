 using System;
  public class Sum
  {
     public int GetSum(int a, int b)
     {  
       if(a == b) 
       {
         return a;
       }
       else
       { 
         int maxVal = Math.Max(a, b); 
         int minVal = Math.Min(a, b);
         int sum = 0;
         for (int i = minVal; i <= maxVal; i++)
         {
           sum += i;
         }
         return sum;
       }
      
     }
  }