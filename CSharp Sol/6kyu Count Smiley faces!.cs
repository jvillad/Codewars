using System;
using System.Collections.Generic;

public static class Kata
{
  public static int CountSmileys(string[] smileArr) 
  {
    if(smileArr.Length == 0)
      return 0;
    
    List<string> listSmile = new List<string>();

    string str = "";
    foreach (var item in smileArr)
    {
      bool flag = item.Contains(' ');
      if (item.Length > 2 && flag == false)     
      {    
        str = item.Substring(0,1) + item.Substring(item.Length - 1); //first and last of string
        listSmile.Add(str);
      }
      else if (item.Length == 2)
      {
        listSmile.Add(item);
      }
    }
    
    int count = 0;
    foreach (var smile in listSmile)
    {
      if (smile == ":)" || smile == ":D" || smile == ";)" || smile == ";D")
      {
        count++;
      }
    }
    
    return count;
    
  }
}