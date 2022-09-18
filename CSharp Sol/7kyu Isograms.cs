using System;
using System.Linq;

public class Kata
{
  public static bool IsIsogram(string text) 
  {
    string str = text.ToLower();
    if(str == string.Empty)
    {
      return true;
    }
    for (int i = 0; i < str.Length; i++)
      for (int j = i + 1; j < str.Length; j++)
        if (str[i] == str[j])
        {
          return false;
        }
    return true;
    
    
  }
}