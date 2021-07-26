namespace myjinxin
{
    using NUnit.Framework;
    using System;
    
    [TestFixture]
    public class myjinxin
    {
        
        [Test]
        public void TestCase(){
            //return a.Concat(b) ?
            Assert.AreEqual(new int[]{0,1},   new Kata().Testit(new int[]{0},new int[]{1}),  "");
            Assert.AreEqual(new int[]{1,2,3,4},  new Kata().Testit(new int[]{1,2},new int[]{3,4}), "");
            Assert.AreEqual(new int[]{1,2,3,4},  new Kata().Testit(new int[]{1},new int[]{2,3,4}), "");
            Assert.AreEqual(new int[]{1,2,3,4},  new Kata().Testit(new int[]{1,2,3},new int[]{4}), "");
            Assert.AreEqual(new int[]{1,1,2,2},  new Kata().Testit(new int[]{1,2},new int[]{1,2}), "");
            Assert.AreEqual(new int[]{1,1,2},  new Kata().Testit(new int[]{1,1},new int[]{1,2}), "");

            //click "Submit" try more testcase...
            
            
        }        
    }
}	