namespace Solution 
{
  using NUnit.Framework;
  using System;

  [TestFixture]
  public class SolutionTest
  {
    [Test, Description("Should return the proper result with fixed tests")]
    public void FixedTest()
    {
      Player greg = new Player();
      greg.Health = 5;
      Assert.AreEqual(true, greg.CheckAlive());
      
      Player joe = new Player();
      joe.Health = 0;
      Assert.AreEqual(false, joe.CheckAlive());
    }
  }
}