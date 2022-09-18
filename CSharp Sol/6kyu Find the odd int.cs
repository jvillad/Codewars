namespace Solution
{
  class Kata
  {
    public static int find_it(int[] num)
    {
      
      
      int repNum = 0;
      for (int i = 0; i < num.Length; i++)        
      {       
        int counter = 0;
        for (int n = 0; n < num.Length; n++)
        {          
          if (num[i] == num[n])
          {
            counter = counter + 1;
          }          
        }
        if (counter%2 != 0)
        {
          repNum = num[i];
        }
      }   
      
      return repNum;
      
    }    
  }
}