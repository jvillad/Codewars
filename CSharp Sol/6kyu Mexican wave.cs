using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class Kata
    {
        public List<string> wave(string str)
        {
          StringBuilder sb = new StringBuilder(str);
          List<string> list = new List<string>();
          for (int i = 0; i < str.Length; i++)
          {
            if(sb[i] != ' ')
            {
              sb[i] =  char.ToUpper(str[i]);
              list.Add(str = sb.ToString());
              
              sb[i] = char.ToLower(sb[i]);
              str = sb.ToString();
            }
          }
          return list;
        }
    }
}