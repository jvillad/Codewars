using System.Collections.Generic;
public class Kata
{
  public static string[] TowerBuilder(int nFloors)
  {
    string[] tree = new string[nFloors];
    
    int star = 1;
    int gap = nFloors - 1;
    
    for (int i = 0; i < nFloors; i++)
    {
      tree[i] = new string(' ', gap) + new string('*', star) + new string(' ', gap);
      star += 2;
      gap--;
    }
    
    return tree;
  }
}