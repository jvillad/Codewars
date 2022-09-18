using System;

public static class Kata
{
  public static string Solution(string str) 
  {
    
    char[] charArray = str.ToCharArray();
    Array.Reverse( charArray );
    string reversedStr = new string(charArray);
    return reversedStr;
  }
  
}