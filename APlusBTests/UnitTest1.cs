namespace Solution {
  using NUnit.Framework;
  using System;  

  [TestFixture]
  public class FirstClassTest 
  {
    [Test]
    public void testSum()
    {
       byte a = 1;
       byte b = 2;       
       Assert.AreEqual(3, FirstClass.sum(a, b));
    }
  }
}