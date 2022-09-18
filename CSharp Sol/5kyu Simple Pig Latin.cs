using System;
using System.Collections.Generic;

public class Kata
{
  public static string PigIt(string str)
  {
    if(str.Length == 0 || str == "!") return str;
    
    string[] strArray = str.Split(' ');
    
    List<string> strList = new List<string>();
    
    string latinWord = " ";
    
    for (int i = 0; i < strArray.Length; i++)
    {
      if (strArray[i] != "!")
      {
        latinWord = strArray[i].Substring(1, strArray[i].Length - 1) + strArray[i].Substring(0, 1) + "ay";
        strList.Add(latinWord);
      } else
        strList.Add(strArray[i]);
    }
    
    var result = string.Join(" ", strList);
    
    return result;
    
  }
}