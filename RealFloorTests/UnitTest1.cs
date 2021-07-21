namespace Solution
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual(0, Kata.GetRealFloor(1));
      Assert.AreEqual(4, Kata.GetRealFloor(5));
      Assert.AreEqual(13, Kata.GetRealFloor(15));
    }
  }
}