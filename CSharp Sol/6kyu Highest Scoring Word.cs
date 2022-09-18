using System;

public class Kata
{
  public static string High(string str)
  {
    
    string[] arr = str.Split(' ');
    
    
    int total = 0;
    int prevNum = 0;
    string highScoringWord = " ";
    for (int i = 0; i < arr.Length; i++)
    {
      
      foreach (var letter in arr[i])
      {
        int asciVal = char.ToUpper(letter) - 64;//index == 1
        total += asciVal;
      }
      
      if (prevNum < total)
      {
        highScoringWord = arr[i];
        prevNum = total;
      }
      
      total = 0;
    }
    
    return highScoringWord;
    
  }
}