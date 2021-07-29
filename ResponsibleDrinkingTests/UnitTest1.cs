using System;
using NUnit.Framework;

namespace CodewarsTests
{

    [TestFixture]
    public class DrinkinTest
    {

        [Test]
        public void drinkinTest1()
        {
            Drinkin drinkin = new Drinkin();
            string expected = "1 glass of water";
            string actual = drinkin.hydrate("1 beer");
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void drinkinTest3()
        {
            Drinkin drinkin = new Drinkin();
            string expected = "10 glasses of water";
            string actual = drinkin.hydrate("1 shot, 5 beers, 2 shots, 1 glass of wine, 1 beer");
            Assert.AreEqual(expected, actual);
        }

    }
}