using System;
using NUnit.Framework;

[TestFixture]
public class KataTest
{
  [Test]
  public void SquareDigitsTest()
  {
    Assert.AreEqual(811181, Kata.SquareDigits(9119));
    Assert.AreEqual(0, Kata.SquareDigits(0));
  }
}