using System;

namespace Common
{
  public static class Math
  {
    public static bool IsPrimeNumber(long n)
    {
      bool result = true;
      double maxP = System.Math.Sqrt(n);

      if(n < 2) { result = false; }
      else if (n > 2 && n%2 == 0) { result = false; }     
      else 
      { 
       for(long i=3; i <= maxP; i+=2)
       {
         if(n%i == 0) { result = false; break; }
       }
      }
      
      return result;
    }

    public static long FindPrimeNumberN(long n)
    {
      long result = 0;
      long count = 1;

      if(n == 1) { result = 2; }
      else
      {
        for(long i=3; count < n; i+=2)
        {
          if(IsPrimeNumber(i)) { ++count; result = i; }
        }
      }

      return result;
    }
	
	public static double SumOfSquares(int n)
	{
		double result = 0;

		for(int i=1; i<=n; i++)
		{
		  result += System.Math.Pow(i, 2);
		}

		return result;
	}

	public static double SquareOfSum(int n)
	{
		long result = 0;

		for(int i=1; i<=n; i++)
		{
		  result += i; 
		}

		return System.Math.Pow(result, 2);
	}	
	
	public static long FindTriangularNumberN(int n)
	{
	  return n*(n+1)/2;
	}
  }
}