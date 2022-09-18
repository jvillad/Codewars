using System.Text;
public static class Kata
{
  public static string AlphabetPosition(string text)
  {
    StringBuilder sbText = new StringBuilder();
    foreach (char c in text)
    {
      if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
      {
        sbText.Append(c);
      }
    }

    string newText = sbText.ToString();    
    StringBuilder sbNewText = new StringBuilder();
    foreach (char letter in newText)
    {
      int asciVal = char.ToUpper(letter) - 64;//index == 1
      sbNewText.Append(asciVal + " ");
    }
    return sbNewText.ToString().Trim();
            
  
  }
}