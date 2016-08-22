using System;

namespace Analytics.Common
{
  public static class Math
  {
    public static bool IsPrime(long n)
    {
      bool result = false;
      double maxP = Math.Sqrt(n);
       
      if(n == 2) 
      { 
        result = true;
      }
      else
      {
       for(long i=3; i < maxP; i+=2)
       {
         if(n%i == 0) { result = false; break; }
       }
      }
      
      return result;
    }
    
    public static void Main(string[] args)
    {
      Console.WriteLine("IsPrime(17): " + IsPrime(17));
    }
  }
}
