using NUnit.Framework;
using System;

[TestFixture]
public class KataTests
{
    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("A                         Z", Kata.Speedify("AZ"));
        Assert.AreEqual("A B C", Kata.Speedify("ABC"));
        Assert.AreEqual("A  C  E", Kata.Speedify("ACE"));
        Assert.AreEqual("  A", Kata.Speedify("CBA"));
        Assert.AreEqual("     E H    DLL   OLO   R  W", Kata.Speedify("HELLOWORLD"));
    }
}