namespace Solution {
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual("one-two-three", Kata.ReplaceDots("one.two.three"));
    }
  }
}
