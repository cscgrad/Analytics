using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Tests
{
  [TestClass]
  public class MathTests
  {
    [TestMethod]
    public void IsPrimeNeg2False()
    {
      Assert.IsFalse(Common.Math.IsPrimeNumber(-2));
    }

    [TestMethod]
    public void IsPrime0False()
    {
      Assert.IsFalse(Common.Math.IsPrimeNumber(0));
    }

    [TestMethod]
    public void IsPrime1False()
    {
      Assert.IsFalse(Common.Math.IsPrimeNumber(1));
    }

    [TestMethod]
    public void IsPrime2True()
    {
      Assert.IsTrue(Common.Math.IsPrimeNumber(2));
    }

    [TestMethod]
    public void IsPrime17True()
    {
      Assert.IsTrue(Common.Math.IsPrimeNumber(17));
    }

    [TestMethod]
    public void IsPrime200False()
    {
      Assert.IsFalse(Common.Math.IsPrimeNumber(200));
    }

    [TestMethod]
    public void IsPrime15485863True()
    {
      Assert.IsTrue(Common.Math.IsPrimeNumber(15485863));
    }

    [TestMethod]
    public void IsPrime104395301True()
    {
      Assert.IsTrue(Common.Math.IsPrimeNumber(104395301));
    }


    [TestMethod]
    public void FindPrimeN1Equals()
    {
      long result = Common.Math.FindPrimeNumberN(1);
      Console.WriteLine(result);
      Assert.AreEqual(result, 2);
    }

    [TestMethod]
    public void FindPrimeN10Equals()
    {
      long result = Common.Math.FindPrimeNumberN(10);
      Console.WriteLine(result);
      Assert.AreEqual(result, 29);
    }

    [TestMethod]
    public void FindPrimeN100Equals()
    {
      long result = Common.Math.FindPrimeNumberN(100);
      Console.WriteLine(result);
      Assert.AreEqual(result, 541);
    }

    [TestMethod]
    public void FindPrimeN1000000Equals()
    {
      long result = Common.Math.FindPrimeNumberN(1000000);
      Console.WriteLine(result);
      Assert.AreEqual(result, 15485863);
    }
  }
}