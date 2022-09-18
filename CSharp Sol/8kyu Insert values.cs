using System.Collections;
namespace Solution
{
  public static class ArraysInversion
  {
    public static int[] InvertValues(int[] numArr)
    {
      
      int[] invNums = new int[numArr.Length];
      
      for (int i = 0; i < numArr.Length; i++)   
       {
        invNums[i] = numArr[i] * -1;
       }
      
      return invNums; 
      
    }
  }
}