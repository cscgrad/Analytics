using System;

namespace Common
{
  public static class Math
  {
    public static bool IsPrime(long n)
    {
      bool result = true;
      double maxP = System.Math.Sqrt(n);

      if(n < 2) { result = false; }        
      else 
      { 
       for(long i=3; i < maxP; i+=2)
       {
         if(n%i == 0) { result = false; break; }
       }
      }
      
      return result;
    }    
  }
}