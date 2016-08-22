using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Common.Tests
{
  [TestClass]
  public class MathTests
  {
    [TestMethod]
    public void IsPrime1False()
    {
      Assert.IsFalse(Common.Math.IsPrime(1));
    }

    [TestMethod]
    public void IsPrime2True()
    {
      Assert.IsTrue(Common.Math.IsPrime(2));
    }

    [TestMethod]
    public void IsPrime17True()
    {
      Assert.IsTrue(Common.Math.IsPrime(17));
    }

    [TestMethod]
    public void IsPrime200False()
    {
      Assert.IsFalse(Common.Math.IsPrime(200));
    }
  }
}