public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {

       int ccLength = cc.Length;

            if (ccLength <= 4)
            {
                return cc;
            }

            else
            {
                int lastFour = cc.Length - 4;               

                string convertedString = new string('#', lastFour);

                return(convertedString + cc.Remove(0, lastFour));
            }
  }
}