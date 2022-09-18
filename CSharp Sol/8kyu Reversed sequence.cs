using System;
using System.Collections.Generic;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    
   int[] array = new int[n];
    
   for(int i =0; i < array.Length; i++)
   {
     
     array[i] = array.Length - i;
   }
   return array;
    
  }
}