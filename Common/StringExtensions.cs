using System;

namespace Common
{
  public static class StringExtensions
  {     
    public static String Reverse(this String s)
	{
      char[] chars = s.ToCharArray();
      Array.Reverse(chars);

      return new String(chars);	  
	}

    public static bool IsPalindrome(this Int32 i)
    {
      return IsPalindrome(i.ToString()); 
    }		
	
    public static bool IsPalindrome(this String s)
    {
      return s.Equals(Reverse(s)); 
    }	
  }
}