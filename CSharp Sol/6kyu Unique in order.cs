 using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable) 
  {
    /*List<T> list = new List<T>();


            foreach (var item in iterable)
            {
                list.Add(item);
            }
          var distinct = list.Distinct().ToList();
    
    return distinct;*/

    List<T> result = new List<T>();
    foreach (var item in iterable)
    {
     
      if (result.Count == 0)
      {
        result.Add(item);
      }

      else if (!result[^1].Equals(item))
      {
        result.Add(item);
      }
    }
    return result;
    
  }
}