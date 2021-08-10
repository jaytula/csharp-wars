using NUnit.Framework;
using System;

namespace Solution {
  // TODO: Replace examples and use TDD by writing your own tests

  [TestFixture]
  public class SolutionTest
  {
    [Test]
    public void SampleTest()
    {
      Assert.AreEqual(true, Solution.Solve("code*s", "codewars"));
      Assert.AreEqual(true, Solution.Solve("codewar*s", "codewars"));
      Assert.AreEqual(true, Solution.Solve("*c", "c"));
      Assert.AreEqual(true, Solution.Solve("*", "asterisk"));
      Assert.AreEqual(false, Solution.Solve("d*oll", "dual"));
      Assert.AreEqual(false, Solution.Solve("*osd", "asterisk"));
      Assert.AreEqual(false, Solution.Solve("*ea", "bean"));
    }
  }
}
