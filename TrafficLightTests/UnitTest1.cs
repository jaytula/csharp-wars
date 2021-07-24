using NUnit.Framework;
using System;

[TestFixture]
public class Tests
{
    [TestCase("green", "yellow")]
    [TestCase("yellow", "red")]
    [TestCase("red", "green")]
    public void BasicTests(string s, string expected)
    {
        Assert.That(Kata.UpdateLight(s), Is.EqualTo(expected));
    }
}