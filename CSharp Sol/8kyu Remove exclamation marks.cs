using System;
using System.Collections.Generic;

public class Kata
{
  public static string RemoveExclamationMarks(string s)
  {
    if( s == String.Empty ) 
    {
      return String.Empty;
    }
    else 
    {
      return s.Replace("!", String.Empty);
    }
   
  }
}