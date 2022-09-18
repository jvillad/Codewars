using System.Text;
using System.Linq;

using System;

public static class Kata
{
  public static string Order(string words)
  {
    if (words == null)
      return words;
    
    string[] subs = words.Split(' ');
    
    StringBuilder sb = new StringBuilder();
    
    int counter = 1;
    foreach (string s in subs)
    {
      
      for (int i = 0; i < subs.Length; i++)
      {             
        string conv = counter.ToString();
        if (subs[i].Contains(conv))
        {
          sb.Append(subs[i] + ' ');
        }
        
      }     
      counter++;
      
    }
    
    return sb.ToString().Trim();
   
  }
}