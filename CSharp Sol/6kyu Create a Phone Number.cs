using System;
using System.Text;

public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    
    StringBuilder sb = new StringBuilder();
    foreach (var item in numbers)
    {
      sb.Append(item);
    }
    string number = sb.ToString();
    
    string num1 = number.Substring(0, 3);
    string num2 = number.Substring(3, 3);
    string num3 = number.Substring(6, 4);
    
    string finNum = $"({num1})" + " " + num2 + "-" + num3;
    
    
    //string str = sb.ToString();
    //string num= String.Format("{0:(###) ###-####}",Convert.ToInt64(str));
    
    return finNum;
    
    
  }
}